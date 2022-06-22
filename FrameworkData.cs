using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace gbelenky.d3jsswa
{
    public class FrameworkData
    {
         [JsonPropertyName("Items")]
        public FrameworkDataItem[] items = new FrameworkDataItem[]
        {
        };
    }

    public class FrameworkDataItem
    {
        [JsonPropertyName("Framework")]
        public string Framework { get; set; }
        [JsonPropertyName("Stars")]
        public string Stars { get; set; }
        [JsonPropertyName("Released")]
        public string Released { get; set; }
    }
}