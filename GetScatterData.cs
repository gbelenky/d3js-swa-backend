using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;


namespace gbelenky.d3jsswa
{
    public static class GetScatterData
    {
        [FunctionName("GetScatterData")] 
        public static  IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("GetScatterData function processed a request.");
            return new OkObjectResult(new FrameworkData().items);
        }
    }
}
