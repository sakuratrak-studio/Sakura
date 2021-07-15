using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Sakura.Model;
using Sakura.Model.Home;

namespace Sakura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        // GET
        [HttpGet]
        public IActionResult Index()
        {
            return Json(new HelloApiResult()
            {
                Code = NiErrCode.Success,
                Message = "Welcome to Sakuratrak Api Server!",
                ServerMode = _webHostEnvironment.EnvironmentName,
                ServerTime = DateTime.UtcNow.Ticks,
                WikiPath = "wiki.sakuratrak.top"
            });
        }
    }
}