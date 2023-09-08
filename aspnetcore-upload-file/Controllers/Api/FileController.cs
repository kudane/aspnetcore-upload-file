using aspnetcore_upload_file.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_upload_file.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController : ControllerBase
    {
        [HttpPost("Upload")]
        public async Task<IActionResult> Uploads()
        {
            var files = await Request.ReadFormAsync();
            return Ok("Uploads");
        }
    }
}