using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace gbelenky.d3jsswa
{
    public static class GetBarData
    {
        [FunctionName("GetBarData")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("GetBarData function processed a request.");
            
            string jsonString = JsonSerializer.Serialize(new FrameworkData().items);
            return new OkObjectResult(jsonString);
        }
    }
}

