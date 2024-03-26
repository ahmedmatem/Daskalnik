using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;

namespace Core.Contracts
{
    public interface IAzureBlobService
    {
        public string BlobContainerURL { get; }

        Task<Azure.Response<BlobContentInfo>> UploadFileAsync(IFormFile file);

        Task<List<Azure.Response<BlobContentInfo>>> UploadFilesAsync(List<IFormFile> files);

        Task<List<BlobItem>> GetUploadedBlobsAsync();
    }
}
