using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace aspnetcore_upload_file.Models
{
    public class SingleUploadRequest
    {
        [FromBody]
        public string? Title { get; set; }

        [FromForm]
        public IFormCollection? Items { get; set; }
    }
}
