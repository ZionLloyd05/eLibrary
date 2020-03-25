#pragma checksum "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "097c556d49ba0b25047c7fd95a169947b0fbf8f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patron_Detail), @"mvc.1.0.view", @"/Views/Patron/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patron/Detail.cshtml", typeof(AspNetCore.Views_Patron_Detail))]
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
#line 1 "C:\dotnetdev\Newbies\eLibrary.UI\Views\_ViewImports.cshtml"
using eLibrary.UI;

#line default
#line hidden
#line 2 "C:\dotnetdev\Newbies\eLibrary.UI\Views\_ViewImports.cshtml"
using eLibrary.UI.Models;

#line default
#line hidden
#line 1 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
using eLibrary.UI.Models.Patron;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"097c556d49ba0b25047c7fd95a169947b0fbf8f8", @"/Views/Patron/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d38c9a900e556af2768fef4a324203bba2d7a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Patron_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
  
    ViewBag.Title = @Model.LastName + ", " + @Model.FirstName;

#line default
#line hidden
            BeginContext(105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(124, 607, true);
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            BeginContext(734, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(752, 224, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css\" integrity=\"sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ\" crossorigin=\"anonymous\">\r\n");
                EndContext();
            }
            );
            BeginContext(979, 283, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Patron Information</h2>
    </div>
    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div>
                    <h2>");
            EndContext();
            BeginContext(1263, 14, false);
#line 24 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                   Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1277, 117, true);
            WriteLiteral("</h2>\r\n                    <div class=\"patronContact\">\r\n                        <div id=\"patronTel\">Library Card ID: ");
            EndContext();
            BeginContext(1395, 19, false);
#line 26 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                                                        Write(Model.LibraryCardId);

#line default
#line hidden
            EndContext();
            BeginContext(1414, 65, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronAddress\">Address: ");
            EndContext();
            BeginContext(1480, 13, false);
#line 27 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                                                    Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1493, 63, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronTel\">Telephone: ");
            EndContext();
            BeginContext(1557, 15, false);
#line 28 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                                                  Write(Model.Telephone);

#line default
#line hidden
            EndContext();
            BeginContext(1572, 67, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronDate\">Member Since: ");
            EndContext();
            BeginContext(1640, 17, false);
#line 29 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                                                      Write(Model.MemberSince);

#line default
#line hidden
            EndContext();
            BeginContext(1657, 70, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronLibrary\">Home Library: ");
            EndContext();
            BeginContext(1728, 17, false);
#line 30 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                                                         Write(Model.HomeLibrary);

#line default
#line hidden
            EndContext();
            BeginContext(1745, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 31 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                         if (@Model.OverdueFees > 0)
                        {

#line default
#line hidden
            BeginContext(1834, 71, true);
            WriteLiteral("                            <div id=\"patronHasFees\">Current Fees Due: $");
            EndContext();
            BeginContext(1906, 17, false);
#line 33 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                                                                  Write(Model.OverdueFees);

#line default
#line hidden
            EndContext();
            BeginContext(1923, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 34 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2015, 81, true);
            WriteLiteral("                            <div id=\"patronNoFees\">No Fees Currently Due.</div>\r\n");
            EndContext();
#line 38 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"

                        }

#line default
#line hidden
            BeginContext(2125, 163, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently Checked Out</h4>\r\n");
            EndContext();
#line 45 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                 if (@Model.AssetsCheckedOut.Count > 0)
                {

#line default
#line hidden
            BeginContext(2364, 75, true);
            WriteLiteral("                    <div id=\"patronAssets\">\r\n                        <ul>\r\n");
            EndContext();
#line 49 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                             foreach (var checkout in @Model.AssetsCheckedOut)
                            {

#line default
#line hidden
            BeginContext(2550, 74, true);
            WriteLiteral("                                <li>\r\n                                    ");
            EndContext();
            BeginContext(2625, 27, false);
#line 52 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                               Write(checkout.LibraryAsset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2652, 22, true);
            WriteLiteral(" - (Library Asset ID: ");
            EndContext();
            BeginContext(2675, 24, false);
#line 52 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                                                                                 Write(checkout.LibraryAsset.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2699, 142, true);
            WriteLiteral(")\r\n                                    <ul>\r\n                                        <li>\r\n                                            Since: ");
            EndContext();
            BeginContext(2842, 14, false);
#line 55 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                                              Write(checkout.Since);

#line default
#line hidden
            EndContext();
            BeginContext(2856, 144, true);
            WriteLiteral("\r\n                                        </li>\r\n                                        <li>\r\n                                            Due: ");
            EndContext();
            BeginContext(3001, 14, false);
#line 58 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                                            Write(checkout.Until);

#line default
#line hidden
            EndContext();
            BeginContext(3015, 131, true);
            WriteLiteral("\r\n                                        </li>\r\n                                    </ul>\r\n                                </li>\r\n");
            EndContext();
#line 62 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(3177, 59, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
            EndContext();
#line 65 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3296, 64, true);
            WriteLiteral("                    <div>No items currently checked out.</div>\r\n");
            EndContext();
#line 69 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"

                }

#line default
#line hidden
            BeginContext(3381, 109, true);
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently On Hold</h4>\r\n");
            EndContext();
#line 75 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                 if (@Model.Holds.Count > 0)
                {

#line default
#line hidden
            BeginContext(3555, 74, true);
            WriteLiteral("                    <div id=\"patronHolds\">\r\n                        <ul>\r\n");
            EndContext();
#line 79 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                             foreach (var hold in @Model.Holds)
                            {

#line default
#line hidden
            BeginContext(3725, 36, true);
            WriteLiteral("                                <li>");
            EndContext();
            BeginContext(3762, 23, false);
#line 81 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                               Write(hold.LibraryAsset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3785, 10, true);
            WriteLiteral(" - Placed ");
            EndContext();
            BeginContext(3796, 44, false);
#line 81 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                                                                 Write(hold.HoldPlaced.ToString("yy-dd-MM - HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(3840, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 82 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(3878, 59, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
            EndContext();
#line 85 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3997, 50, true);
            WriteLiteral("                    <div>No items on hold.</div>\r\n");
            EndContext();
#line 89 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Patron\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(4066, 54, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
