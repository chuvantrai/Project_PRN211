#pragma checksum "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89fc831d2a5a89dcc0528bbc58ffd668a52a36ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__Layout), @"mvc.1.0.view", @"/Views/_Layout.cshtml")]
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
#line 2 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89fc831d2a5a89dcc0528bbc58ffd668a52a36ab", @"/Views/_Layout.cshtml")]
    #nullable restore
    public class Views__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar7.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 35px; width: 35px; border-radius: 25%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #eee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fc831d2a5a89dcc0528bbc58ffd668a52a36ab6010", async() => {
                WriteLiteral("\r\n\t<meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\" />\r\n\t<title>");
#nullable restore
#line 12 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
	<meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"" />
	<!-- Required meta tags -->
	<!-- css bootstrap 4 -->
	<link rel=""stylesheet""
		  href=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css""
		  integrity=""sha384-zCbKRCUGaJDkqS1kPbPd7TveP5iyJE0EjAuZQTgFLD2ylzuqKfdKlfG/eSrtxUkn""
		  crossorigin=""anonymous"" />
	<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.1/font/bootstrap-icons.css"">
	<script src=""https://cdn.jsdelivr.net/npm/jquery@3.5.1/dist/jquery.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"" integrity=""sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.min.js"" integrity=""sha384-VHvPCCyXqtD5DqJ");
                WriteLiteral("eNxl2dtTyhF78xXNXdkwX1CZeRusQfRKp+tA7hAShOK/B/fQ2\" crossorigin=\"anonymous\"></script>\r\n  \r\n\t<!-- cs js file -->\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "89fc831d2a5a89dcc0528bbc58ffd668a52a36ab7805", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fc831d2a5a89dcc0528bbc58ffd668a52a36ab9778", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
      
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
					<a class=""nav-link"" href=""/batdongsan"">Bất động sản</a>
				</li>
				<li class=""nav-item"">
					<a class=""nav-link"" href=""/tintuc"">Tin Tức</a>
				</li>
");
#nullable restore
#line 55 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
                 if (user != null)
				{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<li class=\"nav-item\">\r\n\t\t\t\t\t\t<a class=\"nav-link\" data-toggle=\"modal\"");
                BeginWriteAttribute("href", " href=\"", 2493, "\"", 2500, 0);
                EndWriteAttribute();
                WriteLiteral(" data-target=\"#exampleModal\">Tư Vấn/Hỗ Trợ</a>\r\n\t\t\t\t\t</li>\r\n");
#nullable restore
#line 60 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
				}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"				<li class=""nav-item dropdown"">
					<a style=""color: blue"" class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink""  data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
						Quyền Admin
					</a>
					<div class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
						<a class=""dropdown-item"" href=""../../listyeucau""> <i class=""bi bi-reply-all-fill""></i> Yêu cầu từ khách hàng</a>
						<a class=""dropdown-item"" href=""/batdongsanadmin/thembatdongsan""><i class=""bi bi-plus""></i><i class=""bi bi-map-fill""></i> Thêm bất động sản</a>
						<a class=""dropdown-item"" href=""/tintucadmin/ThemTinTuc""><i class=""bi bi-plus""></i><i class=""bi bi-newspaper""></i> Thêm tin tức</a>
					</div>
				</li>
			</ul>
");
#nullable restore
#line 72 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
             if (user != null)
			{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t<div class=\"dropdown\">\r\n\t\t\t\t\t<a class=\"btn dropdown\" style=\"list-style: none; padding:0px\" href=\"#\" id=\"dropdownMenuLink\" data-toggle=\"dropdown\" aria-expanded=\"false\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 76 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
                   Write(user.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
                         if (user.ImgAvar == null)
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "89fc831d2a5a89dcc0528bbc58ffd668a52a36ab13737", async() => {
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
#line 80 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
						}
						else
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "89fc831d2a5a89dcc0528bbc58ffd668a52a36ab15248", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3744, "~/myfiles/", 3744, 10, true);
#nullable restore
#line 83 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
AddHtmlAttributeValue("", 3754, user.ImgAvar, 3754, 13, false);

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
#line 84 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
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
#line 93 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
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
#line 102 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
			}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
		</div>
	</nav>
	<div>
	<div class=""toast"" data-autohide=""false"">
    <div class=""toast-header"">
      <strong class=""mr-auto text-primary"">Toast Header</strong>
      <small class=""text-muted"">5 mins ago</small>
      <button type=""button"" class=""ml-2 mb-1 close"" data-dismiss=""toast"">&times;</button>
    </div>
    <div class=""toast-body"">
      Some text inside the toast body
    </div>
  </div>
</div>
		");
#nullable restore
#line 118 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
	</div>

<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Gửi Yêu Cầu</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <form method=""post"" action=""/yeucau/guiyeucau"">
          <div class=""form-group"">
            <label for=""recipient-name"" class=""col-form-label"">Số điện thoại:</label>
");
#nullable restore
#line 134 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
             if(user!=null){

#line default
#line hidden
#nullable disable
                WriteLiteral("<input name=\"phone\"");
                BeginWriteAttribute("value", " value=\"", 5908, "\"", 5927, 1);
#nullable restore
#line 134 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
WriteAttributeValue("", 5916, user.Phone, 5916, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" class=\"form-control\" id=\"recipient-name\" readonly required>");
#nullable restore
#line 134 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
                                                                                                                                             }
            else{

#line default
#line hidden
#nullable disable
                WriteLiteral("<input name=\"phone\"");
                BeginWriteAttribute("value", " value=\"", 6041, "\"", 6049, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" class=\"form-control\" id=\"recipient-name\" required>");
#nullable restore
#line 135 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
                                                                                                              }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"          </div>
          <div class=""form-group"">
            <label for=""message-text"" class=""col-form-label"">Nội dung yêu cầu:</label>
            <textarea name=""content"" class=""form-control"" id=""message-text"" required></textarea>
          </div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Thoát</button>
        <button type=""submit"" class=""btn btn-primary"">Gửi</button>
      </div>
	  </form>
    </div>
  </div>
</div>

");
#nullable restore
#line 151 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
     if (ViewBag.thongbao != null)
	{

#line default
#line hidden
#nullable disable
                WriteLiteral(@"		<div aria-live=""polite"" aria-atomic=""true"" style=""position: relative; min-height: 200px;"">
		  <div class=""toast"" style=""position: absolute; top: 0; right: 0;"">
			<div class=""toast-header"">
			  <img src=""..."" class=""rounded mr-2"" alt=""..."">
			  <strong class=""mr-auto"">Thông báo</strong>
			  <button type=""button"" class=""ml-2 mb-1 close"" data-dismiss=""toast"" aria-label=""Close"">
				<span aria-hidden=""true"">&times;</span>
			  </button>
			</div>
			<div class=""toast-body"">
			  ");
#nullable restore
#line 163 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
         Write(ViewBag.thongbao);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t</div>\r\n\t\t  </div>\r\n\t\t</div>\r\n");
#nullable restore
#line 167 "C:\Users\03623\OneDrive\Máy tính\Project_PRN\Project_PRN211\Project\Views\_Layout.cshtml"
	}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<script>
$(document).ready(function(){
    $('.toast').toast('show');
  });
</script>
	<!-- Footer -->
	<footer class=""page-footer font-small unique-color-dark"">

		<!-- Footer Links -->
		<div class=""container text-center text-md-left mt-5 ket1"">

			<!-- Grid row -->
			<div class=""row mt-3"">

				<!-- Grid column -->
				<div class=""col-md-3 col-lg-4 col-xl-3 mx-auto mb-4"">

					<!-- Content -->
					<h6 class=""text-uppercase font-weight-bold"">Ảnh</h6>
					<hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
					<p>
						Dịch vụ bất động sản hàng đầu tại Nha Trang. Cung cấp sản phẩm và thông tin bất động sản,
						dự án, căn hộ, đất nền tại Nha Trang nhanh nhất và chính xác nhất.
					</p>

				</div>
				<!-- Grid column -->
				<!-- Grid column -->
				<div class=""col-md-2 col-lg-2 col-xl-2 mx-auto mb-4"">

					<!-- Links -->
					<h6 class=""text-uppercase font-weight-bold"">Thông tin</h6>
					<hr class=""deep-purple accent-2 mb-4 mt-");
                WriteLiteral(@"0 d-inline-block mx-auto"" style=""width: 60px;"">
					<p>
						<a href=""#!"">Giới thiệu</a>
					</p>
					<p>
						<a href=""#!"">Nhà phố</a>
					</p>
					<p>
						<a href=""#!"">Đất nền</a>
					</p>
					<p>
						<a href=""#!"">Biệt thự</a>
					</p>
					<p>
						<a href=""#!"">Căn hộ</a>
					</p>
					<p>
						<a href=""#!"">Tin tức</a>
					</p>

				</div>
				<!-- Grid column -->
				<!-- Grid column -->
				<div class=""col-md-3 col-lg-2 col-xl-2 mx-auto mb-4"">

					<!-- Links -->
					<h6 class=""text-uppercase font-weight-bold"">Yêu cầu tư vấn</h6>
					<hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
					<p>
						<a href=""#!"" role=""button"" class=""btn btn-primary"">Liên hệ trực tiếp</a>
					</p>


				</div>
				<!-- Grid column -->
				<!-- Grid column -->
				<div class=""col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4"">

					<!-- Links -->
					<h6 class=""text-uppercase font-weight-bold"">Liên hệ</h6>
					<hr class=""deep");
                WriteLiteral(@"-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
					<p>
						<i class=""bi bi-geo-alt-fill""></i>NV27,Khu đô thị Phước Long, Nha Trang
					</p>
					<p>
						<i class=""bi bi-telephone-fill""></i> 𝟎𝟖𝟕𝟗.𝟖𝟒𝟗.𝟖𝟖𝟖
					</p>
					<p>
						<i class=""bi bi-envelope-fill""></i> &commat;gmail.com
					</p>
					<p>
						<a href=""https://www.facebook.com/profile.php?id=100038788150960""><i class=""bi bi-facebook""></i>Facebook</a>
					</p>
					<p>
						<i class=""bi bi-clock-fill""></i> 24/24 (T2-CN)
					</p>

				</div>
				<!-- Grid column -->

			</div>
			<!-- Grid row -->

		</div>

		<!-- Copyright -->
		<div class=""footer-copyright text-center py-3"">
			Copyright © 2022 ChuVanNgoc: Project Thiết kế web của Trai.
		</div>
		<!-- Copyright -->

	</footer>
  

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
