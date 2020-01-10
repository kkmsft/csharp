using System;
using System.Threading;
using k8s;
using informers;

namespace watch
{
    public class SharedInformer<T, L> : ISharedInformer<T, L>
    {
        IController<T, L> _controller;
        IStore _store;
        public SharedInformer(ListerWatcher<T,L> lw)
        {
            _store = new Store();
            _controller = new Controller<T, L>(lw, _store);

        }
        public void AddEventHandler(Action<WatchEventType> a)
        {
            throw new NotImplementedException();
        }

        public void AddResourceHandlers(Action<WatchEventType, IKubernetesObject> onAdd=null, Action<WatchEventType, IKubernetesObject> onDelete=null, Action<WatchEventType, IKubernetesObject, IKubernetesObject> onUpdate=null)
        {
            // TODO: Raise a user friendly exception.
            if (_controller != null)
                _controller.AddResourceHandlers(onAdd, onDelete, onUpdate);
        }

        public IController<T,L> GetController()
        {
            return _controller;
        }

        public IStore GetStore()
        {
            return _store;
        }

        public string LastSyncedVersion()
        {
            throw new NotImplementedException();
        }

        public void Run(CancellationToken cancellationToken)
        {
            _controller.Run(cancellationToken);            
        }
    }
}

