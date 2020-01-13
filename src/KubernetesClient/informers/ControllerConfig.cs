using System;
using System.Collections.Generic;
using k8s.cache;

namespace k8s.informers
{
    public class ControllerConfig<T, L> {
        public Queue<Tuple<WatchEventType, IKubernetesObject>> Fifo;
        public ListerWatcher<T,L> ListerWatcher;
        public IStore Store;
    }
}

