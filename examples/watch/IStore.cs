using System;
using k8s;
using System.Collections.Generic;

namespace watch
{
    public interface IStore {
        void Add(IKubernetesObject o);
        void Delete(IKubernetesObject o);
        IKubernetesObject Update(IKubernetesObject o);
        List<IKubernetesObject> List();
        List<String> ListKeys();
        Tuple<IKubernetesObject, bool> Get(IKubernetesObject o);
        Tuple<IKubernetesObject, bool> GetByKey(string key);
        void Replace(IKubernetesObject[] objects);
        void Resync();        
    }
}

