#pragma checksum "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Order\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8edeb796137563028f8f52381739eeb4bb7eea7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Checkout), @"mvc.1.0.view", @"/Views/Order/Checkout.cshtml")]
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
#line 2 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\_ViewImports.cshtml"
using Final.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8edeb796137563028f8f52381739eeb4bb7eea7b", @"/Views/Order/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3173816865eda74b4589f2a6907367c40a0e549c", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckoutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .checkout-row {
        margin-bottom: 200px;
        position: relative;
        top: 167px;
    }
    .br-subtitle {
        right: 153px !important;
    }
    footer {
        top: 315px;
        background-color: #0c061700;
    }
   tbody tr td{
        color:black;
    }
   thead tr th{
       color:black !important;
   }
</style>

<main>
    <section id=""checkoutPage"">
        <div class=""container"">
            <div class=""row breadcrumb-row"">
                <div class=""col-12 col-lg-12"">
                    <div class=""breadcrumb"">
                        <div class=""br-icon"">
                            <i class=""bi bi-headphones""></i>
                        </div>
                        <div class=""br-title"">
                            <h1>Checkout</h1>
                        </div>
                        <div class=""br-subtitle"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8edeb796137563028f8f52381739eeb4bb7eea7b5220", async() => {
                WriteLiteral("Home > <span>Checkout</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row checkout-row"">
                <div class=""col-12 col-lg-6"">
                    <div class=""checkout-billing"">
                        <h3>Billing Address</h3>
                        <div class=""billing-form"">
                            ");
#nullable restore
#line 50 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Order\Checkout.cshtml"
                       Write(Html.Partial("_CheckoutFormPartial", Model.Order));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-lg-6"">
                    <div class=""checkout-summary"">
                        <h3>Your Order Summary</h3>
                        <div class=""summary"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th>Products</th>
                                        <th>Total</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 66 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Order\Checkout.cshtml"
                                     foreach (var item in Model.Orders.OrderItems)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8edeb796137563028f8f52381739eeb4bb7eea7b8392", async() => {
#nullable restore
#line 70 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Order\Checkout.cshtml"
                                                                                                                         Write(item.Tours.Info);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <strong>");
#nullable restore
#line 70 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Order\Checkout.cshtml"
                                                                                                                                                  Write(item.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Order\Checkout.cshtml"
                                                                                                  WriteLiteral(item.Tours.Id);

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
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>$");
#nullable restore
#line 72 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Order\Checkout.cshtml"
                                             Write((item.Tours.DiscountPercent>0? (item.Tours.SalePrice*(1-item.Tours.DiscountPercent/100))*item.Count :item.Tours.SalePrice*item.Count).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 74 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Order\Checkout.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                                <tfoot>\r\n                                    <tr>\r\n                                        <td>Total Amount</td>\r\n                                        <td><strong>$");
#nullable restore
#line 79 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Order\Checkout.cshtml"
                                                Write(Model.Orders.TotalPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></td>
                                    </tr>
                                </tfoot>
                            </table>
                        </div>
                        <button type=""submit"" form=""order-form"" class=""order-btn"">Place Order</button>
                    </div>
                </div>
            </div>
        </div>
    </section>
</main>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
