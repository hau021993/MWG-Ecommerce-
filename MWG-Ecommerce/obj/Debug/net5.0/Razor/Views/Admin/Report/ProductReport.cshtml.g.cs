#pragma checksum "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da4ba6fe9291a07b7682641c94ddae9d60efd94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Report_ProductReport), @"mvc.1.0.view", @"/Views/Admin/Report/ProductReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da4ba6fe9291a07b7682641c94ddae9d60efd94", @"/Views/Admin/Report/ProductReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3622c4ad4370fe527936e717af2e1b232fa314", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Report_ProductReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MWG_Ecommerce.Models.OrderDetail>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrderManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowOrderDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
  
    ViewData["Title"] = "ProductReport";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-align:center\">Thống kê theo sản phẩm</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da4ba6fe9291a07b7682641c94ddae9d60efd946222", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <input name=""fromDate"" required min=""2022-01-01"" type=""date"" class=""form-control"" />
                    </div>
                </div>
                <div class=""col-md-1"">
                    <div class=""form-group"">
                        <a class=""btn btn-info btn btn-success text-white""> Đến </a>                        
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <input name=""toDate"" required min=""2022-01-01"" type=""date"" class=""form-control"" />
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""form-group"">
                        <button type=""submit"" class=""btn btn-success"">
                        <i style=""color:black;"" class=""fas fa-clock""></i> Chọn mốc thời gia");
                WriteLiteral("n\r\n                    </button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <br />\r\n\r\n         <div class=\"form-group\">\r\n             <a class=\"btn btn-warning btn btn-success text-white\" style=\"text-align:left\">    \r\n                 Tổng số sản phẩm được đặt trong khoảng thời gian đã chọn là ");
#nullable restore
#line 42 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
                                                                        Write(ViewData["GetCountProductByDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sản phẩm.\r\n                 Tổng số lượng sản phẩm được đặt trong khoảng thời gian đã chọn là ");
#nullable restore
#line 43 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
                                                                              Write(ViewData["GetSumQuanlityProductByDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sản phẩm.\r\n                 Tổng doanh thu trong khoảng thời gian đã chọn là ");
#nullable restore
#line 44 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
                                                             Write(String.Format("{0:0,0}", @ViewData["GetTotalMoneyOrderByDate"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND. \r\n                 Tổng số sản phẩm được đặt hiện có là ");
#nullable restore
#line 45 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
                                                 Write(ViewData["GetAllCountProduct"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sản phẩm.\r\n                 Tổng số lượng sản phẩm được đặt hiện có là ");
#nullable restore
#line 46 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
                                                       Write(ViewData["GetAllSumQuanlityProduct"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sản phẩm.\r\n                 Tổng doanh thu hiện có là ");
#nullable restore
#line 47 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
                                      Write(String.Format("{0:0,0}", @ViewData["GetAllTotalMoney"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VND.
             </a>                        
         </div>

        <br />

    </div>
</div>

 <div class=""table-responsive rounded-top rounded-bottom"">
    <table style=""text-align:center"" class=""table table-bordered"" id=""myTable"">
        <thead>
            <tr class=""table-warning"">
                <th style="" width:10%"" scope=""col"">
                   Mã đơn hàng 
                </th>
                <th style="" width:10%"" scope=""col"">
                   Mã sản phẩm 
                </th>
                <th style="" width:15%"" scope=""col"">
                   Tên sản phẩm 
                </th>          
                <th style="" width:15%"" scope=""col"">Hình ảnh</th>
                <th style="" width:15%"" scope=""col"">
                    Thời gian đặt 
                </th>               
                <th class=""align-middle"" style="" width:15%;"" scope=""col"">Hoạt động</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 77 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
         foreach (var item in Model) 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 84 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 87 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.Product.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>  \r\n                <td class=\"align-middle text-center\">\r\n                    <img style=\"height:120px;width:auto;\" class=\"card-img-top \"");
            BeginWriteAttribute("src", " src=", 3866, "", 3892, 1);
#nullable restore
#line 90 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
WriteAttributeValue("", 3871, item.Product.Picture, 3871, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                         alt=\"Card image cap\">\r\n                </td>\r\n                <td>\r\n                   ");
#nullable restore
#line 94 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
              Write(String.Format("{0:dd/MM/yyyy}", item.Order.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("                  \r\n                </td> \r\n                <td class=\"align-middle text-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da4ba6fe9291a07b7682641c94ddae9d60efd9415074", async() => {
                WriteLiteral("                           \r\n                        <i class=\"fas fa-list\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
                                                                                                                                  WriteLiteral(item.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <button type=\"button\" class=\"btn btn-info text-white\"");
            BeginWriteAttribute("onclick", " \r\n                            onclick=\"", 4497, "\"", 4670, 6);
            WriteAttributeValue("", 4537, "showInPopup(\'", 4537, 13, true);
#nullable restore
#line 101 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
WriteAttributeValue("", 4550, Url.Action("AddOrEditProduct","ProductManager",new { id= item.ProductId },Context.Request.Scheme), 4550, 98, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4648, "\',\'Chi", 4648, 6, true);
            WriteAttributeValue(" ", 4654, "tiết", 4655, 5, true);
            WriteAttributeValue(" ", 4659, "sản", 4660, 4, true);
            WriteAttributeValue(" ", 4663, "phẩm\')", 4664, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fa fa-info-circle\"></i>\r\n                    </button>\r\n                    \r\n                </td>           \r\n            </tr>\r\n");
#nullable restore
#line 107 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Report\ProductReport.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MWG_Ecommerce.Models.OrderDetail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
