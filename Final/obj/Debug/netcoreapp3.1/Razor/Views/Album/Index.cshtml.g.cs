#pragma checksum "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9653c8ed1f1a9cca1e67b2951617b09e43428aea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Album_Index), @"mvc.1.0.view", @"/Views/Album/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9653c8ed1f1a9cca1e67b2951617b09e43428aea", @"/Views/Album/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3173816865eda74b4589f2a6907367c40a0e549c", @"/Views/_ViewImports.cshtml")]
    public class Views_Album_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlbumViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("singer-name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "album", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
   
    int counter = (ViewBag.PageIndex - 1) * 6;
    var temp = -1;
    if (ViewBag.PageIndex == 1)
    {
        temp = 0;
    }
    if (temp == ViewBag.TotalPages)
    {
        temp = -2;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <style>

        .album-page-title-inner {
            display: flex;
            flex-direction: column;
          
        }
        .singer-name {
            color: white;
            text-decoration: none;
            font-size:30px;
        }
        footer {
            top: 162px !important;
        }
    </style>
");
            WriteLiteral(@"<main>
    <section id=""albumList"">
        <div class=""container"">
            <div class=""row breadcrumb-row"">
                <div class=""col-12 col-lg-12"">
                    <div class=""breadcrumb"">
                        <div class=""br-icon"">
                            <i class=""bi bi-headphones""></i>
                        </div>
                        <div class=""br-title"">
                            <h1>Albums</h1>
                        </div>
                        <div style=""right: 133px;"" class=""br-subtitle"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9653c8ed1f1a9cca1e67b2951617b09e43428aea6464", async() => {
                WriteLiteral("Home > <span>Album</span>");
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
                <div class=""album-page-header"">
                    <h2>DISCOVER OUR NEWEST MUSICALBUMS AND SINGLES</h2>
                </div>
            </div>
            <div class=""row"">
");
#nullable restore
#line 55 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
                 foreach (var item in Model.Albums)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12 col-lg-4 col-md-6\">\r\n                        <div class=\"album-page-card\">\r\n                            <div class=\"album-pics\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9653c8ed1f1a9cca1e67b2951617b09e43428aea8648", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1851, "~/uploads/albums/", 1851, 17, true);
#nullable restore
#line 60 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
AddHtmlAttributeValue("", 1868, item.Image, 1868, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                <div class=\"album-page-title\">\r\n                                    <div class=\"album-page-title-inner\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9653c8ed1f1a9cca1e67b2951617b09e43428aea10399", async() => {
#nullable restore
#line 64 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
                                                                                                                             Write(item.Singer.Name);

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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
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
            WriteLiteral("\r\n                                        <a>");
#nullable restore
#line 65 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 72 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n\r\n                    <div class=\"site-pagination\">\r\n                        \r\n                  \r\n");
#nullable restore
#line 82 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
                         if (ViewBag.PageIndex > 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("class", " class=\"", 2745, "\"", 2753, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2754, "\"", 2803, 1);
#nullable restore
#line 84 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
WriteAttributeValue("", 2761, Url.Action("index","album",new { page=1}), 2761, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Back</a>\r\n");
#nullable restore
#line 85 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
                         for (int i = 1; i <= 3; i++, temp++)
                        {
                            if ((ViewBag.PageIndex + temp) != 0 && (ViewBag.PageIndex + temp) != -1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 3101, "\"", 3172, 1);
#nullable restore
#line 91 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
WriteAttributeValue("", 3108, Url.Action("index","album", new { page=ViewBag.PageIndex+temp}), 3108, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3173, "\"", 3248, 1);
#nullable restore
#line 91 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
WriteAttributeValue("", 3181, ViewBag.PageIndex+temp==ViewBag.PageIndex?"active-pagination":"", 3181, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 91 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
                                                                                                                                                                                    Write(ViewBag.PageIndex+temp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 92 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
                         if (ViewBag.PageIndex < ViewBag.TotalPages)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"Next\"");
            BeginWriteAttribute("href", " href=\"", 3480, "\"", 3546, 1);
#nullable restore
#line 96 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
WriteAttributeValue("", 3487, Url.Action("index","album", new {page=ViewBag.TotalPages}), 3487, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n");
#nullable restore
#line 97 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Album\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </section>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlbumViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
