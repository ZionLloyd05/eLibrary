#pragma checksum "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b12ca2229181bb3208798c05c20aead2144d2741"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Checkout), @"mvc.1.0.view", @"/Views/Catalog/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Checkout.cshtml", typeof(AspNetCore.Views_Catalog_Checkout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b12ca2229181bb3208798c05c20aead2144d2741", @"/Views/Catalog/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d38c9a900e556af2768fef4a324203bba2d7a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eLibrary.UI.Models.Checkout.CheckoutModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Checkout.cshtml"
  
    ViewBag.Title = @Model.Title;

#line default
#line hidden
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(113, 607, true);
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            BeginContext(723, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(741, 224, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css\" integrity=\"sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ\" crossorigin=\"anonymous\">\r\n");
                EndContext();
            }
            );
            BeginContext(968, 304, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Checkout Library Item</h2>
    </div>

    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div>
                    <p id=""itemTitle"">");
            EndContext();
            BeginContext(1273, 11, false);
#line 27 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Checkout.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1284, 50, true);
            WriteLiteral("</p>\r\n                    <img class=\"detailImage\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1334, "\"", 1355, 1);
#line 28 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Checkout.cshtml"
WriteAttributeValue("", 1340, Model.ImageUrl, 1340, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1356, 49, true);
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n");
            EndContext();
            BeginContext(1454, 36, true);
            WriteLiteral("            <div class=\"col-md-9\">\r\n");
            EndContext();
#line 34 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Checkout.cshtml"
                 using (Html.BeginForm("PlaceCheckout", "Catalog", FormMethod.Post))
                {
                    

#line default
#line hidden
            BeginContext(1711, 30, false);
#line 36 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Checkout.cshtml"
               Write(Html.HiddenFor(a => a.AssetId));

#line default
#line hidden
            EndContext();
            BeginContext(1743, 109, true);
            WriteLiteral("                    <div>\r\n                        Please insert a Library Card ID.\r\n                        ");
            EndContext();
            BeginContext(1853, 37, false);
#line 39 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Checkout.cshtml"
                   Write(Html.TextBoxFor(a => a.LibraryCardId));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1992, 234, true);
            WriteLiteral("                    </div>\r\n                    <div>\r\n                        <button type=\"submit\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect btn-success\">Check out</button>\r\n                    </div>\r\n");
            EndContext();
#line 45 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Checkout.cshtml"
                }

#line default
#line hidden
            BeginContext(2245, 54, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eLibrary.UI.Models.Checkout.CheckoutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
