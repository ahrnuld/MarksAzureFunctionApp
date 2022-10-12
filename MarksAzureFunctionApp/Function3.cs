using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MarksAzureFunctionApp
{
    public class Function3
    {
        private readonly ILogger _logger;

        public Function3(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Function3>();
        }

        [Function("Function3")]
        [QueueOutput("orderedproducts")]
        public ProductDTO Run([QueueTrigger("products", Connection = "")] ProductDTO product)
        {
            return product;
        }
    }
}
