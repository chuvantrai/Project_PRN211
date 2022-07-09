using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System;
using System.Linq;

namespace Project.Controllers
{
    public class BatDongSanAdminController : Controller
    {
        Bds_CShapContext context;
        public BatDongSanAdminController()
        {
            context = new Bds_CShapContext();
        }
        public IActionResult Index()
        {
            return View("/Views/Product/ProductDetail.cshtml");
        }
        public IActionResult ThemBatDongSan(string title,int category,int regional, string content, 
            string letterprice, long noprice, string linkggmap, double area, double horizontal, IFormFile img)
        {
            if (string.IsNullOrEmpty(title)|| string.IsNullOrEmpty(content))
            {
                ViewBag.ListCategory = context.Categories.ToList();
                ViewBag.ListRegional = context.Regionals.ToList();
                return View("/Views/Product/ProductDetail.cshtml");
            }
            else
            {
                Product p = new Product() {ProductName=title,CategoryId=category,RegionalId= regional,
                    Description=content, LetterPrice=letterprice, NoPrice=noprice, LinkGgmap=linkggmap, 
                    AreaM2=area, HorizontalM=horizontal};

                string filename = Logic.ExtensionFile.AddnewImgae(img);
                p.ImgAvar = filename;
                p.DateUp = DateTime.Now;
                p.Status = true;
                context.Products.Add(p);
                context.SaveChanges();
                ViewBag.ListCategory = context.Categories.ToList();
                ViewBag.ListRegional = context.Regionals.ToList();
                ViewBag.thongbao = "Đã thêm BĐS thành công!";
                return View("/Views/Product/ProductDetail.cshtml");
            }
        }
    }
}
