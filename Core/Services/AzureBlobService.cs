using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Core.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Core.Services
{
    public class AzureBlobService : IAzureBlobService
    {
        private readonly BlobServiceClient blobServiceClient;
        private readonly BlobContainerClient blobContainerClient;

        public string BlobContainerURL { get; init; }

        public AzureBlobService(BlobServiceClient client, IConfiguration configuration)
        {
            BlobContainerURL = configuration.GetValue<string>("BlobServiceClient:ContainerURL");
            blobServiceClient = client;
            string containerName = configuration.GetValue<string>("BlobServiceClient:ContainerName");
            blobContainerClient = client.GetBlobContainerClient(containerName);
        }

        public async Task<Response<BlobContentInfo>> UploadFileAsync(IFormFile file, string blobName)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                memoryStream.Position = 0;
                return await blobContainerClient.UploadBlobAsync(blobName, memoryStream, default);
            }
        }

        public async Task<List<BlobItem>> GetUploadedBlobsAsync()
        {
            var items = new List<BlobItem>();
            var uploadedFiles = blobContainerClient.GetBlobsAsync();
            await foreach (BlobItem file in uploadedFiles)
            {
                items.Add(file);
            }

            return items;
        }

        private string GetRandomBlobName(IFormFile file)
        {
            var fileExtension = Path.GetExtension(file.FileName);
            return Guid.NewGuid().ToString() + fileExtension;
        }
    }
}
