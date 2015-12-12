namespace StringCounterConsoleSelfHost
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using StringCounterService;

    public class Startup
    {
        //You must start console app as Administrator!!!
        public static void Main()
        {
            Uri serviceAddress = new Uri("http://localhost:1234/strings");
            ServiceHost selfHost = new ServiceHost(typeof(StringCounter), serviceAddress);

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);

            using (selfHost)
            {
                selfHost.Open();
                System.Console.WriteLine("The service is started at endpoint " + serviceAddress);

                System.Console.WriteLine("Press [Enter] to exit.");
                System.Console.ReadLine();
            }
        }
    }
}
