using System;
using System.Threading;
using k8s.cache;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace k8s.informers
{
    public class Reflector<T, L>: IReflector<T,L> {
        private ListerWatcher<T,L> _listerWatcher;
        private TimeSpan _resyncInterval;
        private Queue<Tuple<WatchEventType, IKubernetesObject>> _fifo;
        private AutoResetEvent _fifoEvent;
        
        public Reflector(ListerWatcher<T,L> l, TimeSpan resyncInterval, Queue<Tuple<WatchEventType, IKubernetesObject>> fifo, AutoResetEvent fifoEvent) {
            _listerWatcher = l;
            _resyncInterval = resyncInterval;
            _fifo = fifo;
            _fifoEvent = fifoEvent;
        }
        public void ReflectorWorker(CancellationToken c) 
        {
            Console.WriteLine("In the ReflectorWorker");
            while (!c.IsCancellationRequested) {
                Console.WriteLine("About to call the lister");
                var response = _listerWatcher.Lister().Result;
                Console.WriteLine("Came out");
                try {
                    var list = (IList<T>)response.Body.GetType().GetProperty("Items").GetValue(response.Body, null);                
                    Console.WriteLine("{0}", list);

                for (var i=0; i<list.Count; i++) {
                    var o = (IKubernetesObject)list[i];                                                            
                    Console.WriteLine("Enqueue");
                    _fifo.Enqueue(new Tuple<WatchEventType, IKubernetesObject>(WatchEventType.Added, o));
                    _fifoEvent.Set();
                }
                using (_listerWatcher.Watcher(
                        (type, item) =>
                                    {
                                        try {
                                        Console.WriteLine("==on watch event==");
                                        Console.WriteLine(type);
                                        var o = (IKubernetesObject)item;                                                                                                                                                          
                                        Console.WriteLine("==on watch event==");
                                        Console.WriteLine("watch Enqueue");
                                        _fifo.Enqueue(new Tuple<WatchEventType, IKubernetesObject>(type, o));
                                        _fifoEvent.Set();
                                        Console.WriteLine("Fifo event set");
                                        if (c.IsCancellationRequested) return;
                                        } catch (Exception ex) {
                                            Console.WriteLine(ex);
                                        }
                                    })){                          
                                       while(!c.IsCancellationRequested) {
                                            Task.Yield();
                                        }

                    }

                } catch (Exception ex) {
                    Console.WriteLine("Caught error: {0}", ex);
                }
            }
        }

        public void Run(CancellationToken c)
        {
            var t = new Task(() => {ReflectorWorker(c);});
            t.Start();            
        }
    }
}

