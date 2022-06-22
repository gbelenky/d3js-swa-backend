using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Collections.Generic;

namespace gbelenky.d3jsswa
{
    public static class GetBarData
    {
        [FunctionName("GetBarData")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,[CosmosDB(
                databaseName: "d3js-swa-frameworks",
                collectionName: "frameworks",
                ConnectionStringSetting = "CosmosDBConnectionString",
                SqlQuery ="SELECT * FROM c ")] IEnumerable<FrameworkDataItem> frameworks,
            ILogger log)
        {
            log.LogInformation("GetBarData function processed a request.");
            
            // needed just to keep the Pascal case formatting 
            string jsonString = JsonSerializer.Serialize(frameworks);
            return new OkObjectResult(jsonString);
        }
    }
}

