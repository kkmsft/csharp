using System;
using k8s;
using System.Collections.Generic;

namespace watch
{
    interface IThreadSafeStore {
        void Add(string key, IKubernetesObject value);
        IKubernetesObject Update(string key, IKubernetesObject value);
        void Delete(string key);
        IKubernetesObject Get(string key);
        List<IKubernetesObject> List();
        List<String> ListKeys();
        void Resync();
    }
}

