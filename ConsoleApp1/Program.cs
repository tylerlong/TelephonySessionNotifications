using System;
using System.Threading.Tasks;
using RingCentral;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            ))
            {
                Task.Run(async () =>
                {
                    await rc.Authorize(
                        Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                        Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                        Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                    );

                    var eventFilters = new[]
                    {
                        "/restapi/v1.0/account/~/telephony/sessions"
                    };
                    
                    var subscription = new Subscription(rc, eventFilters, message =>
                    {
                        Console.WriteLine(message);
                    });
                    await subscription.Subscribe();
                    await Task.Delay(999999999);
                }).GetAwaiter().GetResult();
            }
        }
    }
}