using System;
using System.IO;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MarksAzureFunctionApp
{
    public class BlobFunction
    {
        private readonly ILogger _logger;

        public BlobFunction(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<BlobFunction>();
        }

        [Function("BlobFunction")]
        public void Run([BlobTrigger("samples-workitems/{name}", Connection = "")] string myBlob, string name)
        {
            _logger.LogInformation($"C# Blob trigger function Processed blob\n Name: {name} \n Data: {myBlob}");
        }
    }
}
