using System;
using k8s;
using informers;
using System.Collections.Generic;

namespace watch
{
    public class ControllerConfig<T, L> {
        public Queue<Tuple<WatchEventType, IKubernetesObject>> Fifo;
        public ListerWatcher<T,L> ListerWatcher;
        public IStore Store;
    }
}

