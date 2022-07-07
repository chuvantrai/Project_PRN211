using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Models;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class TrangChuController : Controller
    {
        public IActionResult Index()
        {
            // lay Acc user
            string jsonStr = HttpContext.Session.GetString("useraccount");
            User user;
            if (jsonStr is null) { user = new User(); }
            else { user = JsonConvert.DeserializeObject<User>(jsonStr); ViewBag.User = user; }

            
            return View("/Views/User/Home.cshtml");
        }
    }
}
