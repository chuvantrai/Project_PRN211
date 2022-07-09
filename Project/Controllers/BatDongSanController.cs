using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project.Controllers
{
    public class BatDongSanController : Controller
    {
        Bds_CShapContext context;
        public BatDongSanController()
        {
            context = new Bds_CShapContext();
        }
        public IActionResult Index(int category,int regional, string sort, string price)
        {
            int Pagesize = 6;
            ViewBag.ListCate = context.Categories.ToList();
            ViewBag.ListRegi = context.Regionals.ToList();
            ViewBag.Cate = 0;
            ViewBag.Regi = 0;
            ViewBag.PageIndex = 1;
            List<Product> pro = context.Products.ToList();
            ViewBag.ListPro = Logic.ExtensionPage.PagingProduct(pro,1, Pagesize);
            ViewBag.PageEnd = Logic.ExtensionPage.PageEndProduct(pro,1);
            return View("/Views/Product/ProductList.cshtml");
        }
    }
}
