using System;
using AzureFunctionsDemo.Services.Implementation;
using AzureFunctionsDemo.Services.Interfaces;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsDemo
{
    public class QueueFunction
    {
        [FunctionName("QueueFunction")]
        public void Run([QueueTrigger("demo-items", Connection = "ConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");

            var sumaService = new SumaService();
            var res = sumaService.Suma(1,2);
        }
    }
}
