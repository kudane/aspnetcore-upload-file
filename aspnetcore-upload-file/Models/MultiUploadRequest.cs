using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_upload_file.Models
{
    public class MultiUploadRequest
    {
        public string? Title { get; set; }

        [FromForm]
        public required IFormCollection Items { get; set; }
    }
}
