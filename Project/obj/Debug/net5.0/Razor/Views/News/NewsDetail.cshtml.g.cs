#pragma checksum "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "032eaa8ede9ba06fd522a1ab8f7ec8aef347711b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_NewsDetail), @"mvc.1.0.view", @"/Views/News/NewsDetail.cshtml")]
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
#line 2 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"032eaa8ede9ba06fd522a1ab8f7ec8aef347711b", @"/Views/News/NewsDetail.cshtml")]
    #nullable restore
    public class Views_News_NewsDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/css/adminlte.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/summernote/summernote-bs4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar7.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 35px; width: 35px; border-radius: 25%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/summernote/summernote-bs4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: #f7f7ff;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "032eaa8ede9ba06fd522a1ab8f7ec8aef347711b7252", async() => {
                WriteLiteral(@"
	<meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
	<title>Thêm tin tức</title>
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "032eaa8ede9ba06fd522a1ab8f7ec8aef347711b8313", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "032eaa8ede9ba06fd522a1ab8f7ec8aef347711b9515", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "032eaa8ede9ba06fd522a1ab8f7ec8aef347711b11402", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml"
      
		string jsonStr = Context.Session.GetString("useraccount");
		User user = null;
		if (jsonStr != null) user = JsonConvert.DeserializeObject<User>(jsonStr);

	

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
					<a class=""nav-link"" href=""#"">Tin Tức</a>
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
					   aria-expanded=""false");
                WriteLiteral(@""">
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
#line 76 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml"
             if (user != null)
			{


#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t<div class=\"dropdown\">\r\n\t\t\t\t\t<a class=\"btn dropdown\" style=\"list-style: none; padding:0px\" href=\"#\" id=\"dropdownMenuLink\" data-toggle=\"dropdown\" aria-expanded=\"false\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 81 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml"
                   Write(user.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml"
                         if (user.ImgAvar == null)
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "032eaa8ede9ba06fd522a1ab8f7ec8aef347711b14514", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 85 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml"
						}
						else
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "032eaa8ede9ba06fd522a1ab8f7ec8aef347711b16033", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3072, "~/myfiles/", 3072, 10, true);
#nullable restore
#line 88 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml"
AddHtmlAttributeValue("", 3082, user.ImgAvar, 3082, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 89 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml"
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
#line 98 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml"




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
#line 111 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\News\NewsDetail.cshtml"
			}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
		</div>
	</nav>

	<div class=""container"" style=""margin-top: 20px"">
		<div class=""col-md-12 shadow p-3 mb-5 bg-light rounded"">
		<h3>Thêm Tin Tức mới vào trang web</h3>
		<form action=""insert"" method=""POST"" onsubmit=""return checkForm3()"" enctype=""multipart/form-data"">
			<div class=""form-row"">
				<div class=""form-group col-md-6"">
					<label for=""inputEmail4"">Tiêu đề tin tức</label>
					<input type=""text"" class=""form-control"" id=""inputEmail4"" name=""tieude"">
				</div>
				<div class=""form-group col-md-6"">
					<label for=""inputPassword4"">Ngày của tin tức</label>
					<input type=""date"" class=""form-control"" id=""inputPassword4"" name=""ngay"">
				</div>
			</div>
			<div class=""form-group"">
				<label for=""exampleFormControlTextarea1"">Nội dung tin tức:</label>
				<div class=""card-body"">
					<textarea id=""summernote"">
					</textarea>
				</div>
			</div>
			<div class=""form-group col-md-12"">
				<label for=""inputEmail4"">Ảnh chính của tin tức (ảnh bé hơn 25MB)</label><br>
				<input");
                WriteLiteral(@" type=""file"" name=""img"" accept="".jpg, .jpeg, .png"" placeholder=""Image"" style=""width: 90%"">
			</div>
			<div style=""padding-bottom: 25px;""> <button type=""submit"" class=""btn btn-primary btn-lg"">Thêm</button></div>
			
		</form>
		</div>
	</div>


	");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "032eaa8ede9ba06fd522a1ab8f7ec8aef347711b20758", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "032eaa8ede9ba06fd522a1ab8f7ec8aef347711b21856", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "032eaa8ede9ba06fd522a1ab8f7ec8aef347711b22954", async() => {
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
                WriteLiteral("\r\n\t<script>\r\n\t\t$(function () {\r\n\t\t  // Summernote\r\n\t\t  $(\'#summernote\').summernote()\r\n\r\n\t\t  // CodeMirror\r\n\t\t  CodeMirror.fromTextArea(document.getElementById(\"codeMirrorDemo\"), {\r\n\t\t\tmode: \"htmlmixed\",\r\n\t\t\ttheme: \"monokai\"\r\n\t\t  });\r\n\t\t})\r\n\t</script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
