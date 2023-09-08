using aspnetcore_upload_file.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_upload_file.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload()
        {
            var files = await Request.ReadFormAsync();
            return RedirectToAction("Index");
        }
    }
}