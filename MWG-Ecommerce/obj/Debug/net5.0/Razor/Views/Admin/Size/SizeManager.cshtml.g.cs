#pragma checksum "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "135e2183dcbb76f06ed9c82ecb4be6aa0733ceb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Size_SizeManager), @"mvc.1.0.view", @"/Views/Admin/Size/SizeManager.cshtml")]
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
#line 3 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"135e2183dcbb76f06ed9c82ecb4be6aa0733ceb0", @"/Views/Admin/Size/SizeManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3622c4ad4370fe527936e717af2e1b232fa314", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Size_SizeManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MWG_Ecommerce.DTO.SizePagingDTO>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return ajaxDelete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-links btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SizeManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-currentPageIndex", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
  
    ViewData["Title"] = "SizeManager";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 style=\"text-align:center\">Quản lí kích cỡ sản phẩm</h1>\r\n\r\n<p>\r\n    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 301, "\"", 418, 5);
            WriteAttributeValue("", 311, "generalShowInPopup(\'", 311, 20, true);
#nullable restore
#line 15 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
WriteAttributeValue("", 331, Url.Action("AddOrEditSize","SizeManager",null,Context.Request.Scheme), 331, 70, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 401, "\',\'Thêm", 401, 7, true);
            WriteAttributeValue(" ", 408, "kích", 409, 5, true);
            WriteAttributeValue(" ", 413, "cỡ\')", 414, 5, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success btn btn-success text-white""> <i class=""fas fa-random""></i> Thêm kích cỡ</a>
</p>

<!-- TABLE VIEW -->
<div class=""table-responsive rounded-top rounded-bottom"">
    <table style=""text-align:center"" class=""table table-bordered"" id=""myTable"">
        <thead>
            <tr class=""table-warning"">
                <th style="" width:15%"" scope=""col"">
                   Mã số
                </th>
                <th style="" width:15%"" scope=""col"">
                    Kích thước
                </th>              
                <th class=""align-middle"" style="" width:15%;"" scope=""col"">Hoạt động</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 33 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
         foreach (var item in Model.Sizes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
               Write(Html.DisplayFor(modelItem => item.SizeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
               Write(Html.DisplayFor(modelItem => item.Size1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>         \r\n                <td class=\"align-middle text-center\">\r\n                    <button type=\"button\" class=\"btn btn-info text-white\"");
            BeginWriteAttribute("onclick", " \r\n                            onclick=\"", 1540, "\"", 1705, 5);
            WriteAttributeValue("", 1580, "generalShowInPopup(\'", 1580, 20, true);
#nullable restore
#line 44 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
WriteAttributeValue("", 1600, Url.Action("AddOrEditSize","SizeManager",new { id= item.SizeId },Context.Request.Scheme), 1600, 89, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1689, "\',\'Sửa", 1689, 6, true);
            WriteAttributeValue(" ", 1695, "kích", 1696, 5, true);
            WriteAttributeValue(" ", 1700, "cỡ\')", 1701, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-pencil-alt\"></i>\r\n                    </button>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "135e2183dcbb76f06ed9c82ecb4be6aa0733ceb09849", async() => {
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
#line 47 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
                                                WriteLiteral(item.SizeId);

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
#line 54 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 58 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
 if (Model.PageCount > 1)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row col-sm-10\">\r\n            <div class=\"col-sm-2\">\r\n                Total Items: ");
#nullable restore
#line 63 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
                        Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n             <div class=\"col-sm-10\">\r\n          \r\n");
#nullable restore
#line 67 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
             if (Model.CurrentPageIndex > 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "135e2183dcbb76f06ed9c82ecb4be6aa0733ceb013912", async() => {
                WriteLiteral("First");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentPageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 70 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"btn btn-outline-primary active\">First</span>\r\n");
#nullable restore
#line 75 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 77 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
             for (int i = 1; i <= Model.PageCount; i++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
                 if (Model.CurrentPageIndex != i)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "135e2183dcbb76f06ed9c82ecb4be6aa0733ceb016995", async() => {
#nullable restore
#line 81 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
                                                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentPageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
                                                                                                                                  WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentPageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 82 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"btn btn-outline-primary active\">");
#nullable restore
#line 86 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 87 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 91 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
             if (Model.CurrentPageIndex < Model.PageCount)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "135e2183dcbb76f06ed9c82ecb4be6aa0733ceb021200", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentPageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
                                                                                                                               WriteLiteral(Model.CurrentPageIndex+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentPageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 94 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"btn btn-outline-primary active\">Next </span>\r\n");
#nullable restore
#line 99 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 102 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
             if (Model.CurrentPageIndex < Model.PageCount)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "135e2183dcbb76f06ed9c82ecb4be6aa0733ceb024652", async() => {
                WriteLiteral("Last");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentPageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
                                                                                                                              WriteLiteral(Model.PageCount);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentPageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 105 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"btn btn-outline-primary active\">Last</span>\r\n");
#nullable restore
#line 110 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 114 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Size\SizeManager.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MWG_Ecommerce.DTO.SizePagingDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
