
using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MarksAzureTests
{
    public class BlobTest
    {
        private const string Content = "Some Data inside file Content";

        private const string DefaultEndpointsProtocol = "http";
        private const string AccountName = "devstoreaccount1";
        private const string AccountKey = "Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==";
        private const string BlobEndpoint = "http://127.0.0.1:10000/devstoreaccount1";
        private const string ConnectionString = $"DefaultEndpointsProtocol={DefaultEndpointsProtocol};AccountName={AccountName};AccountKey={AccountKey};BlobEndpoint={BlobEndpoint};";

        private const string Container = "container-1";

        private BlobServiceClient blobServiceClient;
        BlobContainerClient client;

        public BlobTest()
        {
            blobServiceClient = new BlobServiceClient(ConnectionString);
            client = blobServiceClient.GetBlobContainerClient("container");
        

        [Fact]
        public async Task AzureBlobStorageTest()
        {
            // Arrange
            client.cre
            await azureBlobStorage.CreateTextFile("file.txt", Encoding.UTF8.GetBytes(Content))!;

            // Act
            var readTextFile = await azureBlobStorage.ReadTextFile("file.txt");

            // Assert
            Assert.Equal(Content, readTextFile);

            // Finalizing
            await azureBlobStorage.DeleteTextFile("file.txt");
        }
    }
}
