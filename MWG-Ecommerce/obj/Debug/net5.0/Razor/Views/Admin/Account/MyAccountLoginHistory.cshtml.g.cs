#pragma checksum "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fae80da6ac608c72c5ee2ea1a06330f1a369f0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Account_MyAccountLoginHistory), @"mvc.1.0.view", @"/Views/Admin/Account/MyAccountLoginHistory.cshtml")]
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
#line 1 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\_ViewImports.cshtml"
using MWG_Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\_ViewImports.cshtml"
using MWG_Ecommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fae80da6ac608c72c5ee2ea1a06330f1a369f0e", @"/Views/Admin/Account/MyAccountLoginHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3622c4ad4370fe527936e717af2e1b232fa314", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Account_MyAccountLoginHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MWG_Ecommerce.Models.User>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMyLoginHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return ajaxDelete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
  
    ViewData["Title"] = "MyAccountLoginHistory";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
     if(@HttpContextAccessor.HttpContext.Session.GetString("role") == "ROLE_ADMIN")
    {
        Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

    }
    else
    {
        Layout = "~/Views/Shared/_Layout.cshtml";
        

#line default
#line hidden
#nullable disable
            DefineSection("CategoryList", async() => {
                WriteLiteral(@"   
           <nav class=""collapse position-absolute navbar navbar-vertical navbar-light align-items-start p-0 border border-top-0 border-bottom-0 bg-light"" id=""navbar-vertical"" style=""width: calc(100% - 30px); z-index: 1;"">
               <div class=""navbar-nav w-100 overflow-hidden"" style=""height: 310px"">      
");
#nullable restore
#line 19 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
                     foreach(var item in ViewBag.CategoryList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 897, "\"", 904, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">");
#nullable restore
#line 21 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
                                                        Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 22 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
                    }                                 

#line default
#line hidden
#nullable disable
                WriteLiteral("               </div>\r\n           </nav>\r\n        ");
            }
            );
            DefineSection("SupplierList", async() => {
                WriteLiteral("  \r\n            <div class=\"nav-item dropdown\">\r\n                <a href=\"#\" class=\"nav-link dropdown-toggle\" data-toggle=\"dropdown\">Thương hiệu</a>\r\n                    <div class=\"dropdown-menu rounded-0 m-0\">\r\n");
#nullable restore
#line 32 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
                     foreach(var item in ViewBag.SupplierList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a href=\"#\" class=\"dropdown-item\">");
#nullable restore
#line 34 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
                                                     Write(item.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 35 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
                    }            

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n            </div>  \r\n        ");
            }
            );
#nullable restore
#line 38 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align:center"">Lịch sử đăng nhập</h1>

<!-- TABLE VIEW -->
<div class=""table-responsive rounded-top rounded-bottom"">
    <table style=""text-align:center"" class=""table table-bordered"" id=""myTable"">
        <thead>
            <tr class=""table-warning"">
                <th style="" width:5%"" scope=""col"">
                   Mã số
                </th>
                 <th style="" width:15%"" scope=""col"">
                   Tên người dùng
                </th>   
                <th style="" width:15%"" scope=""col"">
                   Tên đăng nhập
                </th>          
                <th style="" width:15%"" scope=""col"">
                   Thời gian đăng nhập
                </th>    
                <th class=""align-middle"" style="" width:15%;"" scope=""col"">Hoạt động</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 66 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
         foreach (var item in Model.LoginHistories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.HistoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>                \r\n                <td>\r\n                    ");
#nullable restore
#line 73 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.User.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.User.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>  \r\n                <td>\r\n                    ");
#nullable restore
#line 79 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>  \r\n                <td class=\"align-middle text-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fae80da6ac608c72c5ee2ea1a06330f1a369f0e11209", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-danger\">\r\n                        <i style=\"color:black;\" class=\"far fa-trash-alt\"></i>\r\n                    </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
                                                              WriteLiteral(item.HistoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 89 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Account\MyAccountLoginHistory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MWG_Ecommerce.Models.User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
