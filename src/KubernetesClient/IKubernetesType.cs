using System.Collections.Generic;

namespace k8s
{
    public interface IKubernetesTypes
    {
        string KubeApiVersion { get;}
        
        string KubeKind { get; }

      
    }

    public interface IKubernetesListTypes<T>
    {
          IList<T> Items {get;set;}
    }
}
