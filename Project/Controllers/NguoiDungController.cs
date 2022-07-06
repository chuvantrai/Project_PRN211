using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Models;
using System;
using System.Linq;

namespace Project.Controllers
{
    public class NguoiDungController : Controller
    {
        Bds_CShapContext context;
        public NguoiDungController()
        {
            context = new Bds_CShapContext();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DangNhap()
        {
            return View("/Views/User/Login.cshtml");
        }
        public IActionResult DoDangNhap(string email, string password, bool remember)
        {
            User user = context.Users.FirstOrDefault(x=>x.Email.Equals(email)&&x.Password.Equals(password));
            
            if (user != null)
            {
                if (remember == true)// luu cookie account
                {
                    CookieOptions cookieOptions = new CookieOptions();
                    cookieOptions.Expires = DateTimeOffset.Now.AddSeconds(60*60*24*7);// 1tuan
                    Response.Cookies.Append("email", user.Email, cookieOptions);
                    Response.Cookies.Append("password", user.Password, cookieOptions);
                }
                string jsonStr = JsonConvert.SerializeObject(user);
                HttpContext.Session.SetString("useraccount", jsonStr);
                return Redirect("/trangchu/index");
            }
            else
            {
                string thongbao = "Email hoặc mật khẩu không đúng";
                ViewBag.Thongbao = thongbao;
                return View("/Views/User/Login.cshtml");
            }
        }
    }
}
