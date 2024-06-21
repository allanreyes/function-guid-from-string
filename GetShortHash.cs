using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace function_guid_from_string
{
    public static class GetShortHash
    {
        [FunctionName("GetShortHash")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string input = req.Query["input"];
            return new OkObjectResult(String.Format("{0:X}", input.GetHashCode()));
        }
    }
}
