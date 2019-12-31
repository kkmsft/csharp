using System;
using System.Threading;
using k8s;
using k8s.Models;

namespace watch
{

    internal class Program
    {
       
        public static void Main(string[] args)
        {
            var config = KubernetesClientConfiguration.BuildConfigFromConfigFile();

            IKubernetes client = new Kubernetes(config);

          /*  ListWatcher lw = new ListWatcher();
            lw.InitSerialization();
            var response = lw.List<V1PodList>("default", "v1", "pods").Result;            
            Console.WriteLine("{0}", response.Body.Items.Count);
            for (var i=0; i<response.Body.Items.Count; i++) {
                Console.WriteLine("{0}", response.Body.Items[i].Metadata.Name);
            }
           */ 
            //var w = lw.List<V1PodList>("default", "v1", "pods", watch:true); 
            
            var podlistResp = client.ListNamespacedPodWithHttpMessagesAsync("default", watch: true);
            using (podlistResp.Watch<V1Pod, V1PodList>((type, item) =>
            {
                Console.WriteLine("==on watch event==");
                Console.WriteLine(type);
                Console.WriteLine(item.Metadata.Name);
                Console.WriteLine("==on watch event==");
            }))
            {
                Console.WriteLine("press ctrl + c to stop watching");

                var ctrlc = new ManualResetEventSlim(false);
                Console.CancelKeyPress += (sender, eventArgs) => ctrlc.Set();
                ctrlc.Wait();
            }
        }
    }
}
