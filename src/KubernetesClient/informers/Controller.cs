using System;
using System.Threading;
using k8s.cache;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace k8s.informers
{
    public class Controller<T, L> : IController<T, L>
    {
        public IReflector<T,L> _reflector;       
        public IStore _store;
        private Queue<Tuple<WatchEventType, IKubernetesObject>> _fifo;
        private AutoResetEvent _fifoEvent;
        private Action<WatchEventType, IKubernetesObject> _onAdd;
        private Action<WatchEventType, IKubernetesObject> _onDelete;
        private Action<WatchEventType, IKubernetesObject, IKubernetesObject> _onUpdate;

        public Controller(ListerWatcher<T,L> lw, IStore s) 
        {            
            _store = s;
            _fifo = new Queue<Tuple<WatchEventType, IKubernetesObject>>();
            _fifoEvent = new AutoResetEvent(false);
            _reflector = new Reflector<T, L>(lw, TimeSpan.FromMinutes(1), _fifo, _fifoEvent);
            
        }

        public void AddResourceHandlers(Action<WatchEventType, IKubernetesObject> onAdd, Action<WatchEventType, IKubernetesObject> onDelete, 
                                        Action<WatchEventType, IKubernetesObject, IKubernetesObject> onUpdate) {
            // TODO: Add locking to ensure that we insert the callback after the current events are processed.
            _onAdd = onAdd;
            _onDelete = onDelete;
            _onUpdate = onUpdate;
        }

        private void OnAdd(WatchEventType eventType, IKubernetesObject obj) {
            if (_onAdd != null) {
                _onAdd(eventType, obj);
            }
        }

        private void OnDelete(WatchEventType eventType, IKubernetesObject deletedObj) {
            if (_onDelete != null) {
                _onDelete(eventType, deletedObj);
            }
        }

        private void OnUpdate(WatchEventType eventType, IKubernetesObject oldObj, IKubernetesObject newObj) {
            if (_onUpdate != null) {
                _onUpdate(eventType, oldObj, newObj);
            }
        }


        public bool HasSynced()
        {
            throw new NotImplementedException();
        }

        public string LastSyncResourceVersion()
        {
            throw new NotImplementedException();
        }


        public void ControllerWorker(CancellationToken cancellationToken) 
        {       
            Console.WriteLine("Controller started!!");     
            while (!cancellationToken.IsCancellationRequested) {                
                Console.WriteLine("Checking count fifo");
                if (_fifoEvent.WaitOne()) {
                 while (_fifo.Count != 0) {
                    var element = _fifo.Dequeue();
                    Console.WriteLine("Operations on fifo");
                    switch (element.Item1) {
                        case WatchEventType.Added:
                            // TODO: Handle the exception here.
                            _store.Add(element.Item2);
                            OnAdd(element.Item1, element.Item2);
                            break;
                        case WatchEventType.Deleted:
                            _store.Delete(element.Item2);
                            OnDelete(element.Item1, element.Item2);
                            break;
                        case WatchEventType.Modified:
                            var oldVal = _store.Update(element.Item2);
                            OnUpdate(element.Item1, oldVal, element.Item2);
                            break;
                        case WatchEventType.Error:
                            Console.WriteLine("Error: Got watch even error"); 
                            break;
                    }
                 }
                }               
            }

        }

        public void Run(CancellationToken cancellationToken)
        {           
           _reflector.Run(cancellationToken);
            // Start the Controller thread.
            var t = new Task(() => {ControllerWorker(cancellationToken);});
            t.Start();  
        }
    }
}

