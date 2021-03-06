#pragma checksum "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f3738a71b743c2ab72ecb8b718bb89947bd61c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_manage_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/manage/Views/Dashboard/Index.cshtml")]
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
#line 2 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\_ViewImports.cshtml"
using Final.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\_ViewImports.cshtml"
using Final.Areas.manage.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f3738a71b743c2ab72ecb8b718bb89947bd61c2", @"/Areas/manage/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"000bdc44b5c2bd6e2c305095c7534288f1a91d53", @"/Areas/manage/Views/_ViewImports.cshtml")]
    public class Areas_manage_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
  
    int orderCounter = 0;
    decimal totalPrice = 0;
    int visitorCount = 0;
    int classic = 0;
    int rap = 0;
    int metal = 0;
    int rock = 0;

    foreach (var item in Model.Albums)
    {
        if(item.GenreId == 1)
        {
            classic++;
        }
        else if(item.GenreId == 2)
        {
            rap++;
        } else if(item.GenreId == 3)
        {
            metal++;
        } else if(item.GenreId == 4)
        {
            rock++;
        }
    }

    int januser = Model.JanuaryyUsers.Count();
    int febuser = Model.FebruaryyUsers.Count();
    int maruser = Model.MarchUsers.Count();
    int apruser = Model.AprilUsers.Count();
    int mayuser = Model.MayUsers.Count();
    int junuser = Model.JuneUsers.Count();
    int juluser = Model.JulyUsers.Count();
    int auguser = Model.AugustUsers.Count();
    int sepuser = Model.SeptemberUsers.Count();
    int octuser = Model.OctoberUsers.Count();
    int novuser = Model.NovemberUsers.Count();
    int decuser = Model.DecemberUsers.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">

    <!--Start Dashboard Content-->

    <div class=""card mt-3"">
        <div class=""card-content"">
            <div class=""row row-group m-0"">
                <div class=""col-12 col-lg-6 col-xl-3 border-light"">
                    <div class=""card-body"">
                        <h5 class=""text-white mb-0"">");
#nullable restore
#line 53 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                               Write(Model.Order.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span class=""float-right""><i class=""fa fa-shopping-cart""></i></span></h5>

                        <p class=""mb-0 text-white small-font"">Total Orders <span class=""float-right""><i class=""zmdi zmdi-long-arrow-up""></i></span></p>
                    </div>
                </div>
                <div class=""col-12 col-lg-6 col-xl-3 border-light"">
                    <div class=""card-body"">
");
#nullable restore
#line 60 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                         foreach (var item in Model.Order)
                        {
                            totalPrice += item.TotalPrice;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5 class=\"text-white mb-0\">");
#nullable restore
#line 64 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                               Write(totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span class=""float-right""><i class=""fa fa-usd""></i></span></h5>


                        <p class=""mb-0 text-white small-font"">Total Revenue <span class=""float-right""> <i class=""zmdi zmdi-long-arrow-up""></i></span></p>
                    </div>
                </div>

                <div class=""col-12 col-lg-6 col-xl-3 border-light"">
                    <div class=""card-body"">
                        <h5 class=""text-white mb-0"">");
#nullable restore
#line 73 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                               Write(Model.Visitors.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span class=""float-right""><i class=""fa fa-eye""></i></span></h5>

                        <p class=""mb-0 text-white small-font"">Visitors <span class=""float-right""> <i class=""zmdi zmdi-long-arrow-up""></i></span></p>
                    </div>
                </div>
                <div class=""col-12 col-lg-6 col-xl-3 border-light"">
                    <div class=""card-body"">

                        <h5 class=""text-white mb-0"">");
#nullable restore
#line 81 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                               Write(Model.Messages.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span class=""float-right""><i class=""fa fa-envira""></i></span></h5>

                        <p class=""mb-0 text-white small-font"">Messages <span class=""float-right""> <i class=""zmdi zmdi-long-arrow-up""></i></span></p>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-12 col-lg-8 col-xl-8"">
            <div class=""card"">
                <div class=""card-header"">
                    Site Traffic
                    <div class=""card-action"">
                        <div class=""dropdown"">
                            <a href=""javascript:void();"" class=""dropdown-toggle dropdown-toggle-nocaret"" data-toggle=""dropdown"">
                                <i class=""icon-options""></i>
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right"">
                                <a class=""dropdown-item"" href=""javascript:void();"">Action</a>
                            ");
            WriteLiteral(@"    <a class=""dropdown-item"" href=""javascript:void();"">Another action</a>
                                <a class=""dropdown-item"" href=""javascript:void();"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""javascript:void();"">Separated link</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-body"">
                    <ul class=""list-inline"">
                        <li class=""list-inline-item""><i class=""fa fa-circle mr-2 text-white""></i>New Visitor</li>

                    </ul>
                    <div class=""chart-container-1"">
                        <canvas id=""chart1""></canvas>
                    </div>
                </div>

                <div class=""row m-0 row-group text-center border-top border-light-3"">
                    <div class=""col-12 col-lg-4"">
                 ");
            WriteLiteral(@"       <div class=""p-3"">
                            <h5 class=""mb-0"">45.87M</h5>
                            <small class=""mb-0"">Overall Visitor <span> <i class=""fa fa-arrow-up""></i> 2.43%</span></small>
                        </div>
                    </div>
                    <div class=""col-12 col-lg-4"">
                        <div class=""p-3"">
                            <h5 class=""mb-0"">15:48</h5>
                            <small class=""mb-0"">Visitor Duration <span> <i class=""fa fa-arrow-up""></i> 12.65%</span></small>
                        </div>
                    </div>
                    <div class=""col-12 col-lg-4"">
                        <div class=""p-3"">
                            <h5 class=""mb-0"">245.65</h5>
                            <small class=""mb-0"">Pages/Visit <span> <i class=""fa fa-arrow-up""></i> 5.62%</span></small>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <div class=""col");
            WriteLiteral(@"-12 col-lg-4 col-xl-4"">
            <div class=""card"">
                <div class=""card-header"">
                    Weekly sales
                    <div class=""card-action"">
                        <div class=""dropdown"">
                            <a href=""javascript:void();"" class=""dropdown-toggle dropdown-toggle-nocaret"" data-toggle=""dropdown"">
                                <i class=""icon-options""></i>
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right"">
                                <a class=""dropdown-item"" href=""javascript:void();"">Action</a>
                                <a class=""dropdown-item"" href=""javascript:void();"">Another action</a>
                                <a class=""dropdown-item"" href=""javascript:void();"">Something else here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""javascript:void();"">Separated link</a>
             ");
            WriteLiteral(@"               </div>
                        </div>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""chart-container-2"">
                        <canvas id=""chart2""></canvas>
                    </div>
                </div>
                <div class=""table-responsive"">
                    <table class=""table align-items-center"">
                        <tbody>
");
#nullable restore
#line 171 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                             foreach (var item in Model.Genres)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td><i class=\"fa fa-circle text-white mr-2\"></i> ");
#nullable restore
#line 175 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 176 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                   Write(item.Albums.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 179 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div><!--End Row-->

    <div class=""row"">
        <div class=""col-12 col-lg-12"">
            <div class=""card"">
                <div class=""card-header"">
                    Recent Order Tables
                    <div class=""card-action"">
                        <div class=""dropdown"">
                            <a href=""javascript:void();"" class=""dropdown-toggle dropdown-toggle-nocaret"" data-toggle=""dropdown"">
                                <i class=""icon-options""></i>
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right"">
                                <a class=""dropdown-item"" href=""javascript:void();"">Action</a>
                                <a class=""dropdown-item"" href=""javascript:void();"">Another action</a>
                                <a class=""dropdown-item"" href=""javascript:void();"">Something el");
            WriteLiteral(@"se here</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""javascript:void();"">Separated link</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""table-responsive"">
                    <table class=""table align-items-center table-flush table-borderless"">
                        <thead>
                            <tr>

                                <th>Product ID</th>
                                <th>Phone Number</th>
                                <th>Order Price</th>
                                <th>Order Date</th>
                                <th>Shipping</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 221 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                             foreach (var order in Model.Order)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n\r\n                                    <td>");
#nullable restore
#line 226 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                   Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 227 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                   Write(order.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 228 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                   Write(order.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 229 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                   Write(order.CreatedAt.ToString("dd-MM-yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 230 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                   Write(order.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 233 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div><!--End Row-->
    <!--End Dashboard Content-->
    <!--start overlay-->
    <div class=""overlay toggle-menu""></div>
    <!--end overlay-->

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        var ctx = document.getElementById(""chart2"").getContext('2d');
        var myChart = new Chart(ctx, {
            type: 'doughnut',
            data: {
                labels: [""Metal"", ""Classic"", ""Rap"", ""Rock""],
                datasets: [{
                    backgroundColor: [
                        ""#ffffff"",
                        ""rgba(255, 255, 255, 0.70)"",
                        ""rgba(255, 255, 255, 0.50)"",
                        ""rgba(255, 255, 255, 0.20)""
                    ],
                    data: [");
#nullable restore
#line 266 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                      Write(metal);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 266 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                              Write(classic);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 266 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                        Write(rap);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 266 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                              Write(rock);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
                    borderWidth: [0, 0, 0, 0]
                }]
            },
            options: {
                maintainAspectRatio: false,
                legend: {
                    position: ""bottom"",
                    display: false,
                    labels: {
                        fontColor: '#ddd',
                        boxWidth: 15
                    }
                }
                ,
                tooltips: {
                    displayColors: false
                }
            }
        });


        $(function () {
            ""use strict"";

            // chart 1

            var ctx = document.getElementById('chart1').getContext('2d');




            var myChart = new Chart(ctx, {
                type: 'line',
                data: {
                    labels: [""Jan"", ""Feb"", ""Mar"", ""Apr"", ""May"", ""Jun"", ""Jul"", ""Aug"", ""Sep"", ""Oct"", ""Nov"", ""Dec""],
                    datasets: [{
                        label: 'New Users',
          ");
                WriteLiteral("              data: [");
#nullable restore
#line 304 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                          Write(januser);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 304 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                    Write(febuser);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 304 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                              Write(maruser);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 304 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                                        Write(apruser);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 304 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                                                  Write(mayuser);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 304 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                                                            Write(junuser);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 304 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                                                                      Write(juluser);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 304 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                                                                                Write(auguser);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 304 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                                                                                          Write(sepuser);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 304 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                                                                                                    Write(octuser);

#line default
#line hidden
#nullable disable
                WriteLiteral(" , ");
#nullable restore
#line 304 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                                                                                                               Write(novuser);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 304 "C:\Users\wacht\OneDrive\Desktop\Final\Final\Areas\manage\Views\Dashboard\Index.cshtml"
                                                                                                                                         Write(decuser);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
                        backgroundColor: '#fff',
                        borderColor: ""transparent"",
                        pointRadius: ""0"",
                        borderWidth: 3
                    }]
                },
                options: {
                    maintainAspectRatio: false,
                    legend: {
                        display: false,
                        labels: {
                            fontColor: '#ddd',
                            boxWidth: 40
                        }
                    },
                    tooltips: {
                        displayColors: false
                    },
                    scales: {
                        xAxes: [{
                            ticks: {
                                beginAtZero: true,
                                fontColor: '#ddd'
                            },
                            gridLines: {
                                display: true,
                                c");
                WriteLiteral(@"olor: ""rgba(221, 221, 221, 0.08)""
                            },
                        }],
                        yAxes: [{
                            ticks: {
                                beginAtZero: true,
                                fontColor: '#ddd'
                            },
                            gridLines: {
                                display: true,
                                color: ""rgba(221, 221, 221, 0.08)""
                            },
                        }]
                    }

                }
            });


            // chart 2






        });

    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
