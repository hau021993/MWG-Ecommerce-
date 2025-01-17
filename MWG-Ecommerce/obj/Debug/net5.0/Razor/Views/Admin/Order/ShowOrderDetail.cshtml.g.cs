#pragma checksum "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f5fc787914265f97a835da9564ae9a43905f682"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Order_ShowOrderDetail), @"mvc.1.0.view", @"/Views/Admin/Order/ShowOrderDetail.cshtml")]
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
#line 1 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f5fc787914265f97a835da9564ae9a43905f682", @"/Views/Admin/Order/ShowOrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3622c4ad4370fe527936e717af2e1b232fa314", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Order_ShowOrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MWG_Ecommerce.Models.Order>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
  
    ViewData["Title"] = "ShowOrderDetail";
     

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
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
#line 19 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
                     foreach(var item in ViewBag.CategoryList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 893, "\"", 900, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">");
#nullable restore
#line 21 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
                                                        Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 22 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
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
#line 32 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
                     foreach(var item in ViewBag.SupplierList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a href=\"#\" class=\"dropdown-item\">");
#nullable restore
#line 34 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
                                                     Write(item.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 35 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
                    }            

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n            </div>  \r\n        ");
            }
            );
#nullable restore
#line 38 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align:center"">Chi tiết đơn hàng</h1>

<p>
    <a class=""btn btn-success btn btn-success text-white"" onclick=""goBack()""> <i class=""fa fa-reply""></i> Quay trở lại</a>
    <a class=""btn btn-info btn btn-success text-white"">Tổng giá trị đơn hàng: ");
#nullable restore
#line 46 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
                                                                         Write(String.Format("{0:0,0}",@ViewData["TotalMoney"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VND</a>
</p>

 <div class=""table-responsive rounded-top rounded-bottom"">
    <table style=""text-align:center"" class=""table table-bordered"" id=""myTable"">
        <thead>
            <tr class=""table-warning"">
                <th style="" width:5%"" scope=""col"">
                   Mã đơn hàng 
                </th>
                <th style="" width:15%"" scope=""col"">
                   Tên sản phẩm
                </th>          
                <th style="" width:15%"" scope=""col"">Hình ảnh</th>
                <th style="" width:10%"" scope=""col"">
                   Đơn giá 
                </th> 
                 <th style="" width:5%"" scope=""col"">
                   Số lượng đặt 
                </th>
                 <th style="" width:10%"" scope=""col"">
                   Khuyến mãi 
                </th> 
                 <th style="" width:10%"" scope=""col"">
                   Tổng tiền 
                </th> 
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 75 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
         foreach (var item in Model.OrderDetails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
               Write(Html.DisplayFor(modelItem => item.Product.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>  \r\n                <td class=\"align-middle text-center\">\r\n                    <img style=\"height:120px;width:auto;\" class=\"card-img-top \"");
            BeginWriteAttribute("src", " src=", 3350, "", 3376, 1);
#nullable restore
#line 85 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
WriteAttributeValue("", 3355, item.Product.Picture, 3355, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                         alt=\"Card image cap\">\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
               Write(String.Format("{0:0,0}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND\r\n                </td> \r\n                <td>\r\n                    ");
#nullable restore
#line 92 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td> \r\n                <td>\r\n                    ");
#nullable restore
#line 95 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiscountId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>  \r\n                <td>\r\n                    ");
#nullable restore
#line 98 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
               Write(String.Format("{0:0,0}", item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND\r\n                </td>                \r\n            </tr>\r\n");
#nullable restore
#line 101 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Admin\Order\ShowOrderDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n<T></T>\r\n</div>\r\n\r\n\r\n<script>\r\n      function goBack(){\r\n          window.history.back();\r\n      }\r\n  </script>\r\n\r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MWG_Ecommerce.Models.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
