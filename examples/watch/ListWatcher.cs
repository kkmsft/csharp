using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using k8s;
using k8s.Models;
using System;

namespace informers
{
    public delegate Task<HttpOperationResponse<T>> ListerD<T>(string namespaceParameter, string apiVersionParameter, string kindParameter, CancellationToken cancellationToken, bool watch);
    public delegate Watcher<T> WatcherD<T, L>(Action<WatchEventType, T> onEvent, Action<Exception> onError, Action onClosed);

    public class ListWatcher<T, L>
    {
        
        //public delegate Task ListerD(IKubernetes c, string ns, string version, string kind, CancellationToken t, bool watch);

        public ListerD<T> Lister;
        public WatcherD<T,L> Watcher;
        string _apiVersion;
        string _nameSpace;
        string _kindParameter;
        CancellationToken _cancellationToken;   
        
        public ListWatcher(IKubernetes client) {                  
            Lister = delegate(string nameSpace, string apiVersion, string kindParameter, CancellationToken cancellationToken, bool watch) 
                    { 
                        return client.List<T>(_nameSpace, _apiVersion, _kindParameter, _cancellationToken, false);
                    };
            Watcher = delegate(Action<WatchEventType, T> onEvent, Action<Exception> onError, Action onClosed)
                    {
                        return client.List<T>("default", "v1", "pods", watch:true).Watch(onEvent, onError, onClosed);                         
                    };
        }
    }        
}
