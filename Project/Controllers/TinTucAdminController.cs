using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System;

namespace Project.Controllers
{
    public class TinTucAdminController : Controller
    {
        Bds_CShapContext context;
        public TinTucAdminController()
        {
            context = new Bds_CShapContext();
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ThemTinTuc(string title,DateTime date,string content, IFormFile img)
        {
            if (title == null|| string.IsNullOrEmpty(content)) { return View("/Views/News/NewsDetail.cshtml"); }
            if (date == null) { date = DateTime.Now; }
            News news = new News();
            string imageName = Logic.ExtensionFile.AddnewImgae(img);
            news.Title = title;
            news.DateUp = date;
            news.Content = content;
            news.ImgAvar = imageName;
            context.News.Add(news);
            context.SaveChanges();
            ViewBag.thongbao = "Đã thêm thành công!";
            return View("/Views/News/NewsDetail.cshtml");
        }
    }
}
