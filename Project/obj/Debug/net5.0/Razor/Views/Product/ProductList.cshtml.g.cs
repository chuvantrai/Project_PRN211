#pragma checksum "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e57e217bf9a85317000576d1ee5b1f252612d41e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductList), @"mvc.1.0.view", @"/Views/Product/ProductList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e57e217bf9a85317000576d1ee5b1f252612d41e", @"/Views/Product/ProductList.cshtml")]
    #nullable restore
    public class Views_Product_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Product.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
  
	ViewBag.Title = "Bất động sản Nha Trang";
	Layout = "~/Views/_Layout.cshtml";
	List<Category> listcate = ViewBag.ListCate;
	List<Regional> listregi = ViewBag.ListRegi;
	int cate = ViewBag.Cate;
	int regi = ViewBag.Regi;
	List<Product> ListPro= ViewBag.ListPro;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
  
	List<Product> NewsList = ViewBag.ProductList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e57e217bf9a85317000576d1ee5b1f252612d41e4958", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"wrapper\">\r\n\t<form action=\"tatca\" method=\"GET\" id=\"searchFrm\">\r\n\t\t<div class=\"d-lg-flex align-items-lg-center pt-2\">\r\n\t\t\t<div class=\"form-inline d-flex align-items-center my-2 mr-lg-2 radio bg-light border\">\r\n");
#nullable restore
#line 23 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                 foreach (Category c in listcate)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                     if (cate == @c.CategoryId)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<label class=\"options\">");
#nullable restore
#line 27 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                                          Write(c.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"radio\" name=\"category\"");
            BeginWriteAttribute("value", " value=\"", 932, "\"", 953, 1);
#nullable restore
#line 27 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 940, c.CategoryId, 940, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" checked> <span class=\"checkmark\"></span> </label>\r\n");
#nullable restore
#line 28 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
					}
					else
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<label class=\"options\">");
#nullable restore
#line 31 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                                          Write(c.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"radio\" name=\"category\"");
            BeginWriteAttribute("value", " value=\"", 1113, "\"", 1134, 1);
#nullable restore
#line 31 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 1121, c.CategoryId, 1121, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <span class=\"checkmark\"></span> </label>\r\n");
#nullable restore
#line 32 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                     
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                 if (cate == 0)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<label class=\"options\">Tất cả <input type=\"radio\" name=\"category\" value=\"0\" checked> <span class=\"checkmark\"></span> </label>\r\n");
#nullable restore
#line 37 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<label class=\"options\">Tất cả <input type=\"radio\" name=\"category\" value=\"0\"> <span class=\"checkmark\"></span> </label>\r\n");
#nullable restore
#line 41 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			</div>
			<div class=""form-inline d-flex align-items-center my-2 checkbox bg-light border mx-lg-2"">
				<label>
					Sắp xếp
				</label>
				<select name=""sort"" id=""country"" class=""bg-light"" onchange=""this.form.submit()"">
					<option value=""desdate"" selected=""selected"">Mới nhất</option>
					<option value=""asedate"">Cũ-mới</option>
					<option value=""aseprice"">Giá từ thấp tới cao</option>
					<option value=""desprice"">Giá từ cao tới thấp</option>
				</select>
			</div>

		</div>
		<section id=""sidebar"">
			<div class=""py-3"">
				<h5 class=""font-weight-bold"">Khu vực BDS</h5>
				<ul class=""list-group"">
					<label class=""options"">Tất cả <input type=""radio"" name=""regional""");
            BeginWriteAttribute("value", " value=\"", 2212, "\"", 2220, 0);
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 2221, "\"", 2231, 0);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"checkmark\"></span> </label>\r\n");
#nullable restore
#line 61 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                     foreach (Regional r in listregi)
					{
						

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                         if (regi == @r.RegionalId)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<label class=\"options\">");
#nullable restore
#line 65 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                                              Write(r.RegionalName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"radio\" name=\"regional\"");
            BeginWriteAttribute("value", " value=\"", 2449, "\"", 2470, 1);
#nullable restore
#line 65 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 2457, r.RegionalId, 2457, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 2471, "\"", 2481, 0);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"checkmark\"></span> </label>\r\n");
#nullable restore
#line 66 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
						}
						else
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<label class=\"options\">");
#nullable restore
#line 69 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                                              Write(r.RegionalName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"radio\" name=\"regional\"");
            BeginWriteAttribute("value", " value=\"", 2637, "\"", 2658, 1);
#nullable restore
#line 69 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 2645, r.RegionalId, 2645, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <span class=\"checkmark\"></span> </label>\r\n");
#nullable restore
#line 70 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                         
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"py-3\">\r\n\t\t\t\t<h5 class=\"font-weight-bold\">Mức giá</h5>\r\n\t\t\t\t<ul class=\"list-group\">\r\n\t\t\t\t\t<label class=\"options\">Tất cả <input type=\"radio\" name=\"price\"");
            BeginWriteAttribute("value", " value=\"", 2908, "\"", 2916, 0);
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 2917, "\"", 2927, 0);
            EndWriteAttribute();
            WriteLiteral(@">  <span class=""checkmark""></span> </label>
					<label class=""options"">&lt; 500 triệu <input type=""radio"" name=""price"" value=""<500""> <span class=""checkmark""></span> </label>
					<label class=""options"">500 - 800 triệu <input type=""radio"" name=""price"" value=""500-800""> <span class=""checkmark""></span> </label>
					<label class=""options"">800 triệu - 1 tỷ <input type=""radio"" name=""price"" value=""800-1t""> <span class=""checkmark""></span> </label>
					<label class=""options"">1 - 3 tỷ <input type=""radio"" name=""price"" value=""1-3t""> <span class=""checkmark""></span> </label>
					<label class=""options"">3 - 7 tỷ <input type=""radio"" name=""price"" value=""3-7t""> <span class=""checkmark""></span> </label>
					<label class=""options"">7 - 10 tỷ <input type=""radio"" name=""price"" value=""7-10t""> <span class=""checkmark""></span> </label>
					<label class=""options"">10 - 20 tỷ <input type=""radio"" name=""price"" value=""10-20t""> <span class=""checkmark""></span> </label>
					<label class=""options"">≥ 20 tỷ<input type=""radio"" name=""pric");
            WriteLiteral("e\" value=\">20t\"> <span class=\"checkmark\"></span> </label>\r\n\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\r\n\t\t</section> <!-- Products Section -->\r\n\r\n\t</form>\r\n\t<div class=\"col-mb-12\">\r\n\t\t<section id=\"products\">\r\n\t\t\t<div class=\"container py-3\">\r\n\t\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 96 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                     foreach (Product p in ListPro)
				   {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t   <div class=\"col-lg-4  col-sm-10 offset-md-0 offset-sm-1 pt-md-0  sanpham1\">\r\n\t\t\t\t\t\t<div class=\"card\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e57e217bf9a85317000576d1ee5b1f252612d41e16448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4391, "~/myfiles/", 4391, 10, true);
#nullable restore
#line 100 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
AddHtmlAttributeValue("", 4401, p.ImgAvar, 4401, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
							<div class=""card-body"" style=""height: 185px;"">
								<i class=""bi bi-star-fill"" style=""color: #feba45""></i> <i class=""bi bi-star-fill"" style=""color: #feba45""></i> <i class=""bi bi-star-fill"" style=""color: #feba45""></i> <i class=""bi bi-star-fill"" style=""color: #feba45""></i> <i class=""bi bi-star-fill"" style=""color: #feba45""></i>
								<span style=""color: #aaa;float: right; font-size: 14px""><i class=""bi bi-geo-alt-fill""></i> ");
#nullable restore
#line 103 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                                                                                                                      Write(p.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n\t\t\t\t\t\t\t\t<h6 class=\"font-weight-bold pt-1\">\r\n\t\t\t\t\t\t\t\t\t<div style=\"height: 58px;overflow:hidden;\">\r\n\t\t\t\t\t\t\t\t\t\t#");
#nullable restore
#line 106 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                                    Write(p.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 106 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                                                 Write(p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									</div>
								</h6>
								<div class=""d-flex align-items-center product""> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""far fa-star""></span> </div>
								<div class=""d-flex align-items-center justify-content-between pt-3"">
									<div class=""d-flex flex-column"">
										<div class=""h6 font-weight-bold"">");
#nullable restore
#line 112 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                                                                    Write(p.LetterPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"bi bi-cash-coin\" style=\"color: #49be25\"></i></div>\r\n\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 5562, "\"", 5569, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration: none;\"><div class=\"btn btn-outline-primary\">Xem</div></a>\r\n\r\n\r\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 5669, "\"", 5676, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration: none;\" class=\"btn btn-outline-danger\"><i class=\"bi bi-trash3-fill\"></i></a>\r\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 5790, "\"", 5797, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration: none;\" class=\"btn btn-outline-success\"><i class=\"bi bi-pencil-square\"></i></a>\r\n\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n");
#nullable restore
#line 125 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
				   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</section>\r\n\t\t\r\n\t</div>\r\n\t<!--        </div>-->\r\n\t<nav aria-label=\"...\" style=\"margin-top: 850px;margin-left: 480px;\">\r\n\t\t\t<ul class=\"pagination\">\r\n");
#nullable restore
#line 134 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                 if(ViewBag.PageEnd!=0){
						

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                         if(ViewBag.PageIndex>2){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t\t\t<a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6265, "\"", 6342, 4);
            WriteAttributeValue("", 6272, "/tintuc/danhsach?Pageindex=1&sort=", 6272, 34, true);
#nullable restore
#line 137 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 6306, ViewBag.sort, 6306, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6319, "&search=", 6319, 8, true);
#nullable restore
#line 137 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 6327, ViewBag.search, 6327, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đầu</a>\r\n\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 139 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                         if (ViewBag.PageIndex !=1){int j =ViewBag.PageIndex-1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6495, "\"", 6573, 6);
            WriteAttributeValue("", 6502, "/tintuc/danhsach?Pageindex=", 6502, 27, true);
#nullable restore
#line 142 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 6529, j, 6529, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6531, "&sort=", 6531, 6, true);
#nullable restore
#line 142 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 6537, ViewBag.sort, 6537, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6550, "&search=", 6550, 8, true);
#nullable restore
#line 142 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 6558, ViewBag.search, 6558, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 142 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                                                                                                                                                 Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 143 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<li class=\"page-item active\" aria-current=\"page\">\r\n\t\t\t\t\t\t\t<a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6689, "\"", 6696, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 146 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                                                    Write(ViewBag.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 149 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                         if (ViewBag.PageIndex != ViewBag.PageEnd){int i =ViewBag.PageIndex+1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6864, "\"", 6942, 6);
            WriteAttributeValue("", 6871, "/tintuc/danhsach?Pageindex=", 6871, 27, true);
#nullable restore
#line 150 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 6898, i, 6898, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6900, "&sort=", 6900, 6, true);
#nullable restore
#line 150 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 6906, ViewBag.sort, 6906, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6919, "&search=", 6919, 8, true);
#nullable restore
#line 150 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 6927, ViewBag.search, 6927, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 150 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                                                                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 151 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                         if (ViewBag.PageIndex <= ViewBag.PageEnd-1){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t\t\t\t<a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 7087, "\"", 7179, 6);
            WriteAttributeValue("", 7094, "/tintuc/danhsach?Pageindex=", 7094, 27, true);
#nullable restore
#line 155 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 7121, ViewBag.PageEnd, 7121, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7137, "&sort=", 7137, 6, true);
#nullable restore
#line 155 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 7143, ViewBag.sort, 7143, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7156, "&search=", 7156, 8, true);
#nullable restore
#line 155 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 7164, ViewBag.search, 7164, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuối</a>\r\n\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 157 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductList.cshtml"
                         
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</ul>\r\n\t\t</nav>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591