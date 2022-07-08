using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class TinTucAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ThemTinTuc()
        {
            return View("/Views/News/NewsDetail.cshtml");
        }
    }
}
