using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Models;
using System;

namespace Project.Controllers
{
    public class YeuCauController : Controller
    {
        Bds_CShapContext context;
        public YeuCauController()
        {
            context = new Bds_CShapContext();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GuiYeuCau(string content)
        {
            string jsonStr = HttpContext.Session.GetString("useraccount");
            User user;
            if (jsonStr is null) user = new User();
            else user = JsonConvert.DeserializeObject<User>(jsonStr);
            UserRequest r = new UserRequest() {UseId=user.UserId, Content=content,DateRequest=DateTime.Now,Status=true };
            context.UserRequests.Add(r);
            context.SaveChanges();
            string thongbao = "1";
            return Redirect("/trangchu?tb="+thongbao);
        }
    }
}
