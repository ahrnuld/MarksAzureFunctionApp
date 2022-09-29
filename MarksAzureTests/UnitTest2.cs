//using Azure.Core.Serialization;
//using Microsoft.Azure.Functions.Worker.Http;
//using Microsoft.Azure.Functions.Worker;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Options;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Text.Json;
//using MarksAzureFunctionApp;
//using Moq;
//using Microsoft.AspNetCore.Http;
//using Newtonsoft.Json;

//namespace MarksAzureTests
//{
//    public class UnitTest2
//    {


//        [Fact]
//        public async Task Test1()
//        {

//            var json = JsonConvert.SerializeObject(body);

//            var memoryStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json));

//            var context = new DefaultHttpContext();
//            var request = context.Request;
//            request.Body = memoryStream;
//            request.ContentType = "application/json";

//            Function1 function1 = new Function1();
//            function1.Run(request);

//        }
//    }
//}
