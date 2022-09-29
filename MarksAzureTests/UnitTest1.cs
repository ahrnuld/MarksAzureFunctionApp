using MarksAzureFunctionApp;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Models;
using Moq;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using Xunit;

namespace MarksAzureTests
{
public class HelloTests 
{
    private HttpClient Client { get; }

    public HelloTests()
    {
        string HostName = Environment.GetEnvironmentVariable("functionHostName");

        if (HostName == null)
        {
            HostName = $"http://localhost:{7061}"; // Fallback for local debugging purposes
        } 

        Client = new HttpClient();
        Client.BaseAddress = new Uri(HostName);
    }

        [Fact]
        public void AlwaysPass()
        {
            Assert.True(true);
        }


        [Fact]
        public async Task Test1()
        {
            // arrange - nothing yet

            // act
            HttpResponseMessage Response = await Client.GetAsync($"/api/Function1");
            string Message = await Response.Content.ReadAsStringAsync();

            // assert
            Assert.Equal(HttpStatusCode.OK, Response.StatusCode);
            Assert.Equal("Welcome to Azure Functions!", Message);
        }

        [Fact]
        public async Task MySecondTest()
        {
            // arrange
            HelloBody body = new HelloBody("Mark");           
            HttpContent data = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

            // act
            HttpResponseMessage Response = await Client.PostAsync($"api/Function2", data);
            string Message = await Response.Content.ReadAsStringAsync();

            // assert
            Assert.Equal(HttpStatusCode.OK, Response.StatusCode);
            Assert.Equal("Welcome to Azure Functions Mark!", Message);
        }

    }
}