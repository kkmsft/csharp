using System;
using System.Threading;
using k8s;
using k8s.Models;
using informers;

namespace watch
{

    internal class Program
    {
       
        public static void Main(string[] args)
        {
            var config = KubernetesClientConfiguration.BuildConfigFromConfigFile(Environment.GetEnvironmentVariable("KUBECONFIG"));

            IKubernetes client = new Kubernetes(config);
            var lw = new ListWatcher<V1Pod, V1PodList>(client); 

            var response = lw.Lister().Result;

            Console.WriteLine("{0}", response.Body.Items.Count);
            for (var i=0; i<response.Body.Items.Count; i++) {
                Console.WriteLine("{0}", response.Body.Items[i].Metadata.Name);
            }

            using (lw.Watcher(
                        (type, item) =>
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
