#pragma checksum "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f04c5b4e0865afe60c7dc25cfc225d713954cda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductDetail), @"mvc.1.0.view", @"/Views/Product/ProductDetail.cshtml")]
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
#line 2 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f04c5b4e0865afe60c7dc25cfc225d713954cda", @"/Views/Product/ProductDetail.cshtml")]
    #nullable restore
    public class Views_Product_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/css/adminlte.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/summernote/summernote-bs4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/myform.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar7.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 35px; width: 35px; border-radius: 25%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/summernote/summernote-bs4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: #f7f7ff;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f04c5b4e0865afe60c7dc25cfc225d713954cda7656", async() => {
                WriteLiteral(@"
	<meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
	<title>Thêm bất động sản</title>
	<meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"" />
	<!-- Required meta tags -->
	<!-- css bootstrap 4 -->
	<link rel=""stylesheet""
		  href=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css""
		  integrity=""sha384-zCbKRCUGaJDkqS1kPbPd7TveP5iyJE0EjAuZQTgFLD2ylzuqKfdKlfG/eSrtxUkn""
		  crossorigin=""anonymous"" />
	<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.1/font/bootstrap-icons.css"">


	<!-- Google Font: Source Sans Pro -->
	<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
	<!-- Theme style -->
	");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f04c5b4e0865afe60c7dc25cfc225d713954cda8722", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t<!-- summernote -->\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f04c5b4e0865afe60c7dc25cfc225d713954cda9924", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f04c5b4e0865afe60c7dc25cfc225d713954cda11101", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f04c5b4e0865afe60c7dc25cfc225d713954cda12989", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
      
		string jsonStr = Context.Session.GetString("useraccount");
		User user = null;
		if (jsonStr != null) user = JsonConvert.DeserializeObject<User>(jsonStr);
		List<Category> listcate = ViewBag.ListCategory;
		List<Regional> listregi = ViewBag.ListRegional;
	

#line default
#line hidden
#nullable disable
                WriteLiteral(@"	<nav class=""navbar navbar-expand-lg navbar-light"" style=""background-color:#e3f2fd;"">
		<a class=""navbar-brand"" href=""/trangchu"">LOGO</a>
		<button class=""navbar-toggler""
				type=""button""
				data-toggle=""collapse""
				data-target=""#navbarNavDropdown""
				aria-controls=""navbarNavDropdown""
				aria-expanded=""false""
				aria-label=""Toggle navigation"">
			<span class=""navbar-toggler-icon""></span>
		</button>
		<div class=""collapse navbar-collapse"" id=""navbarNavDropdown"">
			<ul class=""navbar-nav mr-auto mt-2 mt-lg-0"">
				<li class=""nav-item"">
					<a class=""nav-link"" href=""#"">Bất động sản</a>
				</li>
				<li class=""nav-item"">
					<a class=""nav-link"" href=""/tintuc"">Tin Tức</a>
				</li>
				<li class=""nav-item"">
					<a class=""nav-link"" href=""#"">Tư Vấn/Hỗ Trợ</a>
				</li>
				<li class=""nav-item dropdown"">
					<a class=""nav-link dropdown-toggle""
					   href=""#""
					   id=""navbarDropdownMenuLink""
					   data-toggle=""dropdown""
					   aria-haspopup=""true""
					   aria-expanded=");
                WriteLiteral(@"""false"">
						Khu Vực
					</a>
					<div class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
						<a class=""dropdown-item"" href=""#"">Action</a>
						<a class=""dropdown-item"" href=""#"">Another action</a>
						<a class=""dropdown-item"" href=""#"">Something else here</a>
					</div>
				</li>
			</ul>
");
#nullable restore
#line 78 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
             if (user != null)
			{


#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t<div class=\"dropdown\">\r\n\t\t\t\t\t<a class=\"btn dropdown\" style=\"list-style: none; padding:0px\" href=\"#\" id=\"dropdownMenuLink\" data-toggle=\"dropdown\" aria-expanded=\"false\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 83 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
                   Write(user.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 84 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
                         if (user.ImgAvar == null)
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f04c5b4e0865afe60c7dc25cfc225d713954cda16231", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
						}
						else
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f04c5b4e0865afe60c7dc25cfc225d713954cda17756", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3233, "~/myfiles/", 3233, 10, true);
#nullable restore
#line 90 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
AddHtmlAttributeValue("", 3243, user.ImgAvar, 3243, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 91 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
						}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
					</a>
					<div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuLink"">
						<a class=""dropdown-item"" href=""/nguoidung/thongtincanhan""><i class=""bi bi-file-person-fill"" style=""font-size: 21px;""></i>Thông tin cá nhân</a>
						<a class=""dropdown-item"" href=""/nguoidung/doimatkhau""><i class=""bi bi-file-earmark-lock2-fill"" style=""font-size: 21px;""></i>Đổi mật khẩu</a>
						<a class=""dropdown-item"" href=""/nguoidung/dangxuat""><i class=""bi bi-box-arrow-right"" style=""font-size: 21px;""></i>Đăng xuất</a>
					</div>
				</div>
");
#nullable restore
#line 100 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"




			}
			else
			{

#line default
#line hidden
#nullable disable
                WriteLiteral(@"				<button onclick=""window.location.href='/nguoidung/dangky'"" class=""btn btn-outline-secondary my-2 my-sm-0"" type=""submit"">
					Đăng ký
				</button>
				<button onclick=""window.location.href='/nguoidung/dangnhap'"" class=""btn btn-outline-secondary my-2 my-sm-0"" type=""submit"">
					Đăng Nhập
				</button>
");
#nullable restore
#line 113 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
			}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t</div>\r\n\t</nav>\r\n");
#nullable restore
#line 117 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
     if (@ViewBag.thongbao != null)
	{

#line default
#line hidden
#nullable disable
                WriteLiteral(@"		<div class=""container"">
			<div class=""row""><br></div>
			<div class=""row"">
				<div class=""col"">
				</div>
				<div class=""col-8"">
					<div class=""alert alert-info alert-dismissible fade show"" id='tempAlert' role=""alert"">
						<button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
							<span aria-hidden=""true"">&times;</span>
						</button>
						<strong>Thông báo</strong> ");
#nullable restore
#line 129 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
                                              Write(ViewBag.thongbao);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col\">\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 136 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
	}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"	<div class=""container"" style=""margin-top: 20px"">
		<div class=""col-md-12 shadow p-3 mb-5 bg-light rounded"">
			<h3>Thêm thông tin Bất động sản</h3>
			<form action=""/batdongsanadmin/Thembatdongsan"" method=""POST"" enctype=""multipart/form-data"">
				<div class=""form-row"">
					<div class=""form-group col-md-8"">
						<label for=""inputEmail4"">Tên bất động sản</label>
						<input type=""text"" class=""form-control"" id=""inputEmail4"" name=""title"" required>
					</div>
					<div class=""form-group col-md-2"">
						<label for=""inputPassword4"">Loại BĐS</label>
						<select name=""category"" class=""custom-select col-12"" id=""inlineFormCustomSelectPref"">
");
#nullable restore
#line 149 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
                             foreach (Category c in listcate)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<option");
                BeginWriteAttribute("value", " value=\"", 5551, "\"", 5572, 1);
#nullable restore
#line 151 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 5559, c.CategoryId, 5559, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >");
#nullable restore
#line 151 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
                                                          Write(c.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\n");
#nullable restore
#line 152 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t</select>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"form-group col-md-2\">\r\n\t\t\t\t\t\t<label for=\"inputPassword4\">Khu vực BĐS</label>\r\n\t\t\t\t\t\t<select name=\"regional\" class=\"custom-select col-12\" id=\"inlineFormCustomSelectPref\">\r\n");
#nullable restore
#line 158 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
                             foreach (Regional r in listregi)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<option");
                BeginWriteAttribute("value", " value=\"", 5893, "\"", 5914, 1);
#nullable restore
#line 160 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 5901, r.RegionalId, 5901, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >");
#nullable restore
#line 160 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
                                                          Write(r.RegionalName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\n");
#nullable restore
#line 161 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\Product\ProductDetail.cshtml"
							}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"						</select>
					</div>
				</div>
				<div class=""form-group"">
					<label for=""exampleFormControlTextarea1"">Thông tin chi tiết:</label>
					<div class=""card-body"">
						<textarea id=""summernote"" name=""content"" required>
					</textarea>
					</div>
				</div>
				<div class=""form-row"">
					<div class=""form-group col-md-6"">
						<label for=""inputEmail4"">*Giá bằng chữ</label>
						<input type=""text"" class=""form-control"" id=""inputEmail4"" name=""letterprice"" required>
					</div>
					<div class=""form-group col-md-6"">
						<label for=""inputEmail4"">*Giá bằng số</label>
						<input type=""number"" class=""form-control"" id=""inputEmail4"" name=""noprice"" required>
					</div>
				</div>
				<div class=""form-group col-md-11"">
					<label for=""inputEmail4"">*Link GG Map</label>
					<input type=""text"" class=""form-control"" id=""inputEmail4"" name=""linkggmap"">
				</div>
				<div class=""form-row"">
					<div class=""form-group col-md-6"">
						<label for=""inputEmail4"">*Diện tính (m&sup2;)</lab");
                WriteLiteral(@"el>
						<input type=""number"" class=""form-control"" id=""inputEmail4"" name=""area"" required>
					</div>
					<div class=""form-group col-md-6"">
						<label for=""inputEmail4"">*Mặt tiền (mét)</label>
						<input type=""number"" class=""form-control"" id=""inputEmail4"" name=""horizontal"" required>
					</div>
				</div>
				<div class=""form-group col-md-12"">
					<label for=""inputEmail4"">Ảnh chính của tin tức (ảnh bé hơn 25MB)</label><br>
					<input type=""file"" name=""img"" accept="".jpg, .jpeg, .png"" placeholder=""Image"" required>
				</div>
				<div style=""padding-bottom: 25px;""> <button type=""submit"" class=""btn btn-primary btn-lg"">Thêm</button></div>

			</form>
	</div>
	</div>


	");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f04c5b4e0865afe60c7dc25cfc225d713954cda27826", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f04c5b4e0865afe60c7dc25cfc225d713954cda28924", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f04c5b4e0865afe60c7dc25cfc225d713954cda30022", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t<script>\r\n\t\t$(function () {\r\n\t\t  // Summernote\r\n\t\t  $(\'#summernote\').summernote()\r\n\r\n\t\t  // CodeMirror\r\n\t\t  CodeMirror.fromTextArea(document.getElementById(\"codeMirrorDemo\"), {\r\n\t\t\tmode: \"htmlmixed\",\r\n\t\t\ttheme: \"monokai\"\r\n\t\t  });\r\n\t\t})\r\n\t</script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
