#pragma checksum "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Color\ColorManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7860814fc02d089c0cbfb0de0e92edabe707eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Color_ColorManager), @"mvc.1.0.view", @"/Views/Admin/Color/ColorManager.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7860814fc02d089c0cbfb0de0e92edabe707eb", @"/Views/Admin/Color/ColorManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3622c4ad4370fe527936e717af2e1b232fa314", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Color_ColorManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MWG_Ecommerce.Models.Color>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_pagercolor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return ajaxDelete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Color\ColorManager.cshtml"
  
    ViewData["Title"] = "ColorManager";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

    Pager pager = new Pager();

    int pageNo = 0;

    if(ViewBag.Pager != null)
    {
        pager = ViewBag.Pager;
        pageNo = pager.CurrentPage;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-align:center\">Quản lí màu sắc sản phẩm</h1>\r\n\r\n<p>\r\n    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 399, "\"", 518, 5);
            WriteAttributeValue("", 409, "generalShowInPopup(\'", 409, 20, true);
#nullable restore
#line 21 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Color\ColorManager.cshtml"
WriteAttributeValue("", 429, Url.Action("AddOrEditColor","ColorManager",null,Context.Request.Scheme), 429, 72, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 501, "\',\'Thêm", 501, 7, true);
            WriteAttributeValue(" ", 508, "màu", 509, 4, true);
            WriteAttributeValue(" ", 512, "sắc\')", 513, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn btn-success text-white\"> <i class=\"fas fa-random\"></i> Thêm màu sắc</a>\r\n</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef7860814fc02d089c0cbfb0de0e92edabe707eb6211", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 24 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Color\ColorManager.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = pager;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!-- TABLE VIEW -->
<div class=""table-responsive rounded-top rounded-bottom"">
    <table style=""text-align:center"" class=""table table-bordered"" id=""myTable"">
        <thead>
            <tr class=""table-warning"">
                <th style="" width:15%"" scope=""col"">
                   Mã số
                </th>
                <th style="" width:15%"" scope=""col"">
                    Màu sắc
                </th>              
                <th class=""align-middle"" style="" width:15%;"" scope=""col"">Hoạt động</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 41 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Color\ColorManager.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Color\ColorManager.cshtml"
               Write(Html.DisplayFor(modelItem => item.ColorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Color\ColorManager.cshtml"
               Write(Html.DisplayFor(modelItem => item.Color1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>         \r\n                <td class=\"align-middle text-center\">\r\n                    <button type=\"button\" class=\"btn btn-info text-white\"");
            BeginWriteAttribute("onclick", " \r\n                            onclick=\"", 1682, "\"", 1843, 5);
            WriteAttributeValue("", 1722, "showInPopup(\'", 1722, 13, true);
#nullable restore
#line 52 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Color\ColorManager.cshtml"
WriteAttributeValue("", 1735, Url.Action("AddOrEditColor","ColorManager",new { id= item.ColorId },Context.Request.Scheme), 1735, 92, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1827, "\',\'Sửa", 1827, 6, true);
            WriteAttributeValue(" ", 1833, "màu", 1834, 4, true);
            WriteAttributeValue(" ", 1837, "sắc\')", 1838, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-pencil-alt\"></i>\r\n                    </button>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef7860814fc02d089c0cbfb0de0e92edabe707eb10397", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-danger\">\r\n                        <i style=\"color:black;\" class=\"far fa-trash-alt\"></i>\r\n                    </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Color\ColorManager.cshtml"
                                                WriteLiteral(item.ColorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 62 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Color\ColorManager.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef7860814fc02d089c0cbfb0de0e92edabe707eb13519", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 67 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Color\ColorManager.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = pager;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MWG_Ecommerce.Models.Color>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591