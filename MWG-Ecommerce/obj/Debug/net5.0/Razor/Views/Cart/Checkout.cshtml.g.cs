#pragma checksum "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c566ceb656868928c875a59f6d4c672081e1c58a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
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
#line 99 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
using MWG_Ecommerce.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c566ceb656868928c875a59f6d4c672081e1c58a", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e3622c4ad4370fe527936e717af2e1b232fa314", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CartItem>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
  
    ViewData["Title"] = "CartPage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("CategoryList", async() => {
                WriteLiteral(@"   
   <nav class=""collapse position-absolute navbar navbar-vertical navbar-light align-items-start p-0 border border-top-0 border-bottom-0 bg-light"" id=""navbar-vertical"" style=""width: calc(100% - 30px); z-index: 1;"">
       <div class=""navbar-nav w-100 overflow-hidden"" style=""height: 310px"">      
");
#nullable restore
#line 12 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
             foreach(var item in ViewBag.CategoryList)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a");
                BeginWriteAttribute("href", " href=\"", 528, "\"", 535, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-item nav-link\">");
#nullable restore
#line 14 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                                                Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n");
#nullable restore
#line 15 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
            }                                 

#line default
#line hidden
#nullable disable
                WriteLiteral("       </div>\n   </nav>\n");
            }
            );
            WriteLiteral("\n");
            DefineSection("SupplierList", async() => {
                WriteLiteral("  \n    <div class=\"nav-item dropdown\">\n        <a href=\"#\" class=\"nav-link dropdown-toggle\" data-toggle=\"dropdown\">Thương hiệu</a>\n            <div class=\"dropdown-menu rounded-0 m-0\">\n");
#nullable restore
#line 25 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
             foreach(var item in ViewBag.SupplierList)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a href=\"#\" class=\"dropdown-item\">");
#nullable restore
#line 27 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                                             Write(item.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n");
#nullable restore
#line 28 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
            }            

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\n    </div>  \n");
            }
            );
            WriteLiteral(@" 
<!-- Page Header Start -->
    <div class=""container-fluid bg-secondary mb-5"">
        <div class=""d-flex flex-column align-items-center justify-content-center"" style=""min-height: 300px"">
            <h1 class=""font-weight-semi-bold text-uppercase mb-3"">Thanh toán</h1>           
        </div>
    </div>
    <!-- Page Header End -->


    <!-- Checkout Start -->
    <div class=""container-fluid pt-5"">
        <div class=""row px-xl-5"">
            <div class=""col-lg-8"">
                <div class=""mb-4"">
                    <h4 class=""font-weight-semi-bold mb-4"">Thông tin đơn hàng</h4>
                    <div class=""row"">
");
#nullable restore
#line 49 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                          
                            var user = Context.Session.Get("user");
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-6 form-group\">\n                                <label>Tên người đặt hàng</label>\n                                <input readonly class=\"form-control\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2034, "\"", 2076, 1);
#nullable restore
#line 54 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 2042, Context.Session.GetString("name"), 2042, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2077, "\"", 2091, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            </div>\n                            <div class=\"col-md-6 form-group\">\n                                <label>Tài khoản</label>\n                                <input readonly class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2316, "\"", 2362, 1);
#nullable restore
#line 58 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 2324, Context.Session.GetString("username"), 2324, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2375, "\"", 2389, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            </div>\n                            <div class=\"col-md-6 form-group\">\n                                <label>Email</label>\n                                <input readonly class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2610, "\"", 2653, 1);
#nullable restore
#line 62 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 2618, Context.Session.GetString("email"), 2618, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"email\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2667, "\"", 2681, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            </div>\n                            <div class=\"col-md-6 form-group\">\n                                <label>Địa chỉ</label>\n                                <textarea readonly class=\"form-control\" type=\"text\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2919, "\"", 2933, 0);
            EndWriteAttribute();
            WriteLiteral("></textarea>\n                            </div>\n                            <div class=\"col-md-6 form-group\">\n                                <label>Số điện thoại</label>\n                                <input readonly class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3173, "\"", 3216, 1);
#nullable restore
#line 70 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 3181, Context.Session.GetString("phone"), 3181, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"tel\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3228, "\"", 3242, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>                     
                            <div class=""col-md-6 form-group"">
                                <label>Ngày giao hàng</label>
                                <input class=""form-control"" type=""datetime""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3500, "\"", 3514, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            </div>\n");
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""card border-secondary mb-5"">
                    <div class=""card-header bg-secondary border-0"">
                        <h4 class=""font-weight-semi-bold m-0"">Thanh toán đơn hàng</h4>
                    </div>
                    <div class=""card-body"">
                       <h5 class=""font-weight-medium mb-3"">Sản phẩm</h5>
");
#nullable restore
#line 100 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                        foreach (var item in Context.Session.Get<List<CartItem>>("GioHang"))
                       {                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"d-flex justify-content-between\">\n                                <p>");
#nullable restore
#line 103 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                              Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p>");
#nullable restore
#line 104 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                              Write(String.Format("{0:0,0}", @item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                            </div>         \n");
#nullable restore
#line 106 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                      \n");
            WriteLiteral(@"                    </div>
                    <div class=""card-footer border-secondary bg-transparent"">
                        <div class=""d-flex justify-content-between mt-2"">
                            <h5 class=""font-weight-bold"">Tổng giá trị</h5>
                            <h5 class=""font-weight-bold"">                             
");
#nullable restore
#line 122 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                                  
                                     var data = Context.Session.Get<List<CartItem>>("GioHang");
                                     if (data == null)
                                     {
                                         data = new List<CartItem>();
                                     }
                                 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     ");
#nullable restore
#line 129 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                                Write(String.Format("{0:0,0}", data.Sum(c => c.TotalPrice)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VND
                            </h5>
                        </div>
                    </div>
                </div>
                <div class=""card border-secondary mb-5"">
                    <div class=""card-header bg-secondary border-0"">
                        <h4 class=""font-weight-semi-bold m-0"">Phương thức thanh toán</h4>
                    </div>
                    <div class=""card-body"">
");
#nullable restore
#line 139 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                     foreach (var item in ViewBag.PaymentList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group\">\n                            <div class=\"custom-control custom-radio\">\n                                <input required type=\"radio\" class=\"custom-control-input\" name=\"payment\"");
            BeginWriteAttribute("id", " id=\"", 7530, "\"", 7550, 1);
#nullable restore
#line 143 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 7535, item.PaymentId, 7535, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 7620, "\"", 7641, 1);
#nullable restore
#line 144 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 7626, item.PaymentId, 7626, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 144 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                                                                                     Write(item.PaymentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                            </div>\n                        </div>\n");
#nullable restore
#line 147 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                    }                                               

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                    <div class=\"card-footer border-secondary bg-transparent\">\n");
#nullable restore
#line 152 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                     if(Context.Session.GetInt32("id") == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"button\" id=\"btn\" value=\"Đặt hàng\" class=\"btn btn-lg btn-block btn-primary font-weight-bold my-3 py-3\" />\r\n");
#nullable restore
#line 155 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                        
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <button class=\"btn btn-lg btn-block btn-primary font-weight-bold my-3 py-3\">Đặt hàng</button>\r\n");
#nullable restore
#line 160 "D:\ItFresher\TestProject\MWG-Ecommerce\MWG-Ecommerce\Views\Cart\Checkout.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Checkout End -->

<script language=""javascript"">
    var button = document.getElementById(""btn"");
    button.onclick = function(){
         alert(""Bạn cần đăng nhập để tiến hành thanh toán!"");
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
