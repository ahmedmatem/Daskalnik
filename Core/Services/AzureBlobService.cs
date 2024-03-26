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
            blobServiceClient = client;
            string containerName = configuration.GetValue<string>("BlobServiceClient:ContainerName");
            BlobContainerURL = configuration.GetValue<string>("BlobServiceClient:ContainerURL");
            blobContainerClient = client.GetBlobContainerClient(containerName);
        }

        public async Task<Response<BlobContentInfo>> UploadFileAsync(IFormFile file)
        {
            string blobName = file.FileName;
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                memoryStream.Position = 0;
                return await blobContainerClient.UploadBlobAsync(blobName, memoryStream, default);
            }
        }

        public async Task<List<Response<BlobContentInfo>>> UploadFilesAsync(List<IFormFile> files)
        {
            var azureResponse = new List<Response<BlobContentInfo>>();

            foreach (var file in files)
            {
                string blobName = file.FileName;
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyTo(memoryStream);
                    memoryStream.Position = 0;
                    var client = await blobContainerClient.UploadBlobAsync(blobName, memoryStream, default);
                    azureResponse.Add(client);
                }
            }

            return azureResponse;
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
    }
}
