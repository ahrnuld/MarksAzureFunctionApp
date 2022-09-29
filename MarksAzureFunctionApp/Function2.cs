using System.Collections.Generic;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Models;
using Newtonsoft.Json;

namespace MarksAzureFunctionApp
{
    public class Function2
    {
        private readonly ILogger _logger;

        public Function2(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Function2>();
        }

        [Function("Function2")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            HelloBody data = JsonConvert.DeserializeObject<HelloBody>(requestBody);

            string name = data.Name;

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString($"Welcome to Azure Functions {name}!");

            return response;
        }
    }
}
