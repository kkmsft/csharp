using System;
using System.Threading;
using k8s.cache;

namespace k8s.informers
{
    interface ISharedInformer<T, L> {
        IStore GetStore();
        IController<T, L> GetController();
        void AddResourceHandlers(Action<WatchEventType, IKubernetesObject> onAdd = null, Action<WatchEventType, IKubernetesObject> onDelete = null, 
                                        Action<WatchEventType, IKubernetesObject, IKubernetesObject> onUpdate = null);
        void Run(CancellationToken cancellationToken);
        String LastSyncedVersion();
    }
}

