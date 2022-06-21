using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace gbelenky.d3jsswa
{
    public class FrameworkData
    {
        public FrameworkDataItem[] items = new FrameworkDataItem[]
        {
            new FrameworkDataItem {Framework = "Vue", Stars = "166443", Released = "2014"},
            new FrameworkDataItem {Framework = "React", Stars = "150793", Released = "2013"},
            new FrameworkDataItem {Framework = "Angular", Stars = "62342", Released = "2016"},
            new FrameworkDataItem {Framework = "Backbone", Stars = "27647", Released = "2010"},
            new FrameworkDataItem {Framework = "Ember", Stars = "21471", Released = "2011"},
        };
    }

    public class FrameworkDataItem {
        
        public string Framework { get; set; }
        public string Stars { get; set; }
        public string Released { get; set; }

    }
}