#pragma checksum "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Tours\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "805a1b2bf71428e7e9899a052bbc4f875b2f14dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tours_Index), @"mvc.1.0.view", @"/Views/Tours/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"805a1b2bf71428e7e9899a052bbc4f875b2f14dc", @"/Views/Tours/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3173816865eda74b4589f2a6907367c40a0e549c", @"/Views/_ViewImports.cshtml")]
    public class Views_Tours_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToursViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "tours", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<style>
    .tour-desc{
        font-size: 17px !important;
    }
    .adding-btn {
        position: relative;
        top: 20px;
    }
    .tour-btn a {
        text-decoration: none;
        position: relative;
        float: right;
        font-size: 14px;
        padding: 20px 33px 15px;
        min-width: 149px;
        color: #fff;
        line-height: 1;
        text-align: center;
        font-weight: 700;
        border: none;
        text-transform: uppercase;
        background: linear-gradient(45deg, #503aca 0%, #ea34ff 100%);
    }
</style>
<main>
    <section id=""tour"">
        <div class=""container"">
            <div class=""row breadcrumb-row"">
                <div class=""col-12 col-lg-12"">
                    <div class=""breadcrumb"">
                        <div class=""br-icon"">
                            <i class=""bi bi-headphones""></i>
                        </div>
                        <div class=""br-title"">
                            <h1>
        ");
            WriteLiteral("                        Tours\r\n                            </h1>\r\n\r\n                        </div>\r\n                        <div class=\"br-subtitle\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805a1b2bf71428e7e9899a052bbc4f875b2f14dc6120", async() => {
                WriteLiteral("Home > <span>Tours</span>");
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
            <div class=""row"">
                <div class=""row"">
                    <div class=""col-12 col-lg-8"">
                        <div class=""tours-title"">
                            <div class=""sub-title"">
                                <p>Upcoming Shows</p>
                            </div>
                            <h2>WHEN WE ALL FALL ASLEEP</h2>
                        </div>
                    </div>
                    <div class=""col-12 col-lg-4"">
                        <div class=""tour-btn"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805a1b2bf71428e7e9899a052bbc4f875b2f14dc8180", async() => {
                WriteLiteral("Go To Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            <div class=""row"">
                <div class=""col-12 col-lg-12"">
                    <div class=""tours-list"">
                        <ul>
");
#nullable restore
#line 70 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Tours\Index.cshtml"
                             foreach (var item in Model.Tours)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <div class=\"tour-date\">\r\n                                        <h2>");
#nullable restore
#line 74 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Tours\Index.cshtml"
                                       Write(item.Date.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <span>");
#nullable restore
#line 75 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Tours\Index.cshtml"
                                         Write(item.Date.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div class=\"tour-info\">\r\n                                        <p>\r\n\r\n                                            ");
#nullable restore
#line 80 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Tours\Index.cshtml"
                                       Write(item.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                        <span>\r\n\r\n                                            ");
#nullable restore
#line 84 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Tours\Index.cshtml"
                                       Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </span>
                                    </div>
                                    <div class=""tour-location"">
                                        <p>
                                            <i class=""bi bi-geo-alt-fill""></i>
                                            ");
#nullable restore
#line 90 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Tours\Index.cshtml"
                                       Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                        </p>
                                    </div>
                                    <div class=""tour-date"">
                                        <p>
                                            <i class=""bi bi-clock""></i>
                                            ");
#nullable restore
#line 97 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Tours\Index.cshtml"
                                       Write(item.Date.ToString("hh:ff"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                        </p>\r\n                                    </div>\r\n                                    <div>\r\n                                        <p>");
#nullable restore
#line 102 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Tours\Index.cshtml"
                                      Write(item.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n                                    </div>\r\n                                    <div class=\"ticket-btn\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805a1b2bf71428e7e9899a052bbc4f875b2f14dc13401", async() => {
#nullable restore
#line 105 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Tours\Index.cshtml"
                                                                                                            Write(item.BtnText);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Tours\Index.cshtml"
                                                                                           WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 108 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Tours\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToursViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
