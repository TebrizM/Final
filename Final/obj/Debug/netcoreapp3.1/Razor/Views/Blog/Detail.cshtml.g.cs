#pragma checksum "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe88d25edbded0727696202268ca00f211045a0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe88d25edbded0727696202268ca00f211045a0d", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3173816865eda74b4589f2a6907367c40a0e549c", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("author-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/media/Blog/author.jpg.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<style>
    textarea {
        margin-bottom: 60px;
    }
    .sbmnt-btn {
        margin-bottom: 200px;
        display: inline-block;
        font-size: 14px;
        padding: 17px 33px 15px;
        min-width: 149px;
   
        line-height: 1;
        text-align: center;
        font-weight: 700;
        border: none;
        text-transform: uppercase;
        background: linear-gradient(45deg, #503aca 0%, #ea34ff 100%);
    }
        .sbmnt-btn button {
            color: #fff !important;
        }
</style>

<main>
    <section id=""blog-detail"">

        <div class=""container"">
            <div class=""row breadcrumb-row"">
                <div class=""col-12 col-lg-12"">
                    <div class=""breadcrumb"">
                        <div class=""br-icon"">
                            <i class=""bi bi-headphones""></i>
                        </div>
                        <div class=""br-title"">
                            <h1>Blog</h1>
                        </div>");
            WriteLiteral("\n                        <div class=\"br-subtitle\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe88d25edbded0727696202268ca00f211045a0d6024", async() => {
                WriteLiteral("Home > <span>Blog</span>");
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
                <div class=""col-12 col-lg-12"">
                    <div class=""blog-detail-header"">
                        <h1>");
#nullable restore
#line 49 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Blog\Detail.cshtml"
                       Write(Model.Blogs.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    </div>
                    <div class=""blog-detail-metas"">
                        <p>by <span>Admin</span></p> |
                        <p>Aug15, 2022</p> |
                        <p>20 Comment</p>
                    </div>
                    <div class=""blog-detail-image"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fe88d25edbded0727696202268ca00f211045a0d8246", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1836, "~/uploads/blogs/", 1836, 16, true);
#nullable restore
#line 57 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 1852, Model.Blogs.Image, 1852, 18, false);

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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"blog-detail-info\">\r\n                        <p>");
#nullable restore
#line 60 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Blog\Detail.cshtml"
                      Write(Model.Blogs.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    \r\n                        <blockquote>\r\n\r\n                            <h4>");
#nullable restore
#line 64 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Blog\Detail.cshtml"
                           Write(Model.Blogs.Quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n             \r\n                        </blockquote>\r\n                   \r\n                   \r\n                        <div class=\"author-card\">\r\n                            <div class=\"author-card-text\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fe88d25edbded0727696202268ca00f211045a0d10762", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <h4>LENA MOLLEIN.</h4>\r\n                                <p>");
#nullable restore
#line 73 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Blog\Detail.cshtml"
                              Write(Model.Blogs.Quote);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <div class=""author-socials"">

                                </div>
                            </div>
                        </div>
                        <div class=""comment-wrap"">
                            <h2>Comments</h2>
");
#nullable restore
#line 81 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Blog\Detail.cshtml"
                             foreach (var item in Model.Blogs.BlogComments)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"comment-list\">\r\n                                    <div class=\"comment-header\">\r\n                                        <h4>");
#nullable restore
#line 85 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Blog\Detail.cshtml"
                                       Write(item.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    </div>\r\n                                    <div class=\"comment-body\">\r\n                                        <p>");
#nullable restore
#line 88 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Blog\Detail.cshtml"
                                      Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"comment-footer\">\r\n                                        <p>");
#nullable restore
#line 91 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Blog\Detail.cshtml"
                                      Write(item.CreatedAt.ToString("MMMM dd,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n\r\n\r\n                                </div>\r\n");
#nullable restore
#line 96 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Blog\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"comment-title\">\r\n                            <h2>LEAVE A COMMENT</h2>\r\n                            ");
#nullable restore
#line 101 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Views\Blog\Detail.cshtml"
                       Write(Html.Partial("_BlogComment", Model.BlogComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
