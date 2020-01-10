using System;
using System.Threading;
using k8s;

namespace watch
{
    public interface IController<T, L>{
        void Run(CancellationToken cancellationToken);
        bool HasSynced();
        String LastSyncResourceVersion();
        
        public void AddResourceHandlers(Action<WatchEventType, IKubernetesObject> onAdd, Action<WatchEventType, IKubernetesObject> onDelete, 
                                        Action<WatchEventType, IKubernetesObject, IKubernetesObject> onUpdate);
    }
}

