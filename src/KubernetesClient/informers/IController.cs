using System;
using System.Threading;

namespace k8s.informers
{
    public interface IController<T, L>{
        void Run(CancellationToken cancellationToken);
        bool HasSynced();
        String LastSyncResourceVersion();
        void AddResourceHandlers(Action<WatchEventType, IKubernetesObject> onAdd, Action<WatchEventType, IKubernetesObject> onDelete, 
                                        Action<WatchEventType, IKubernetesObject, IKubernetesObject> onUpdate);
    }
}

