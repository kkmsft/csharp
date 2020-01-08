namespace k8s
{
    public interface IKubernetesTypes
    {
        string KubeApiVersion { get;}
        
        string KubeKind { get; }
    }
}
