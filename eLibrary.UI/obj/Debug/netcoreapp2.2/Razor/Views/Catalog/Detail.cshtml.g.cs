#pragma checksum "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de9c99276f41b0e4bbae618c3ffbf6d96f6fe6ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Detail), @"mvc.1.0.view", @"/Views/Catalog/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Detail.cshtml", typeof(AspNetCore.Views_Catalog_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de9c99276f41b0e4bbae618c3ffbf6d96f6fe6ed", @"/Views/Catalog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d38c9a900e556af2768fef4a324203bba2d7a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkFound", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Hold", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
  
    ViewBag.Title = Model.Title;

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(64, 607, true);
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            BeginContext(674, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(692, 224, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css\" integrity=\"sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ\" crossorigin=\"anonymous\">\r\n");
                EndContext();
            }
            );
            BeginContext(919, 297, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""page-header clearfix detailHeading"">
        <h2 class=""text-muted"">View Library Item</h2>
    </div>
</div>

<div class=""jumbotron"">
    <div class=""row"">
        <div class=""col-md-4"">
            <div>
                <img class=""detailImage""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1216, "\"", 1237, 1);
#line 27 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
WriteAttributeValue("", 1222, Model.ImageUrl, 1222, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1238, 126, true);
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <div>\r\n                <p id=\"itemTitle\">");
            EndContext();
            BeginContext(1365, 11, false);
#line 32 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                             Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1376, 41, true);
            WriteLiteral("</p>\r\n                <p id=\"itemAuthor\">");
            EndContext();
            BeginContext(1418, 22, false);
#line 33 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                              Write(Model.AuthorOrDirector);

#line default
#line hidden
            EndContext();
            BeginContext(1440, 41, true);
            WriteLiteral("</p>\r\n                <p id=\"itemStatus\">");
            EndContext();
            BeginContext(1482, 12, false);
#line 34 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                              Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1494, 39, true);
            WriteLiteral("</p>\r\n                <p id=\"itemType\">");
            EndContext();
            BeginContext(1534, 10, false);
#line 35 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                            Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1544, 43, true);
            WriteLiteral("</p>\r\n                <p id=\"itemLocation\">");
            EndContext();
            BeginContext(1588, 21, false);
#line 36 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                                Write(Model.CurrentLocation);

#line default
#line hidden
            EndContext();
            BeginContext(1609, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 38 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                 if (Model.Status == "Lost")
                {

#line default
#line hidden
            BeginContext(1682, 127, true);
            WriteLiteral("                    <p>This item has been lost. It cannot be checked out</p>\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(1809, 305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de9c99276f41b0e4bbae618c3ffbf6d96f6fe6ed11017", async() => {
                BeginContext(2100, 10, true);
                WriteLiteral("Mark Found");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                             WriteLiteral(Model.AssetId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2114, 28, true);
            WriteLiteral("\r\n                    </p>\r\n");
            EndContext();
#line 48 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(2161, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 50 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                 if (Model.Status == "Checked Out")
                {

#line default
#line hidden
            BeginContext(2235, 55, true);
            WriteLiteral("                    <p id=\"itemPatron\">Checked Out By: ");
            EndContext();
            BeginContext(2291, 16, false);
#line 52 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                                                  Write(Model.PatronName);

#line default
#line hidden
            EndContext();
            BeginContext(2307, 55, true);
            WriteLiteral("</p>\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(2362, 299, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de9c99276f41b0e4bbae618c3ffbf6d96f6fe6ed14702", async() => {
                BeginContext(2649, 8, true);
                WriteLiteral("Check In");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                             WriteLiteral(Model.AssetId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2661, 77, true);
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(2738, 301, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de9c99276f41b0e4bbae618c3ffbf6d96f6fe6ed17463", async() => {
                BeginContext(3025, 10, true);
                WriteLiteral("Place Hold");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                             WriteLiteral(Model.AssetId);

#line default
#line hidden
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
            EndContext();
            BeginContext(3039, 28, true);
            WriteLiteral("\r\n                    </p>\r\n");
            EndContext();
#line 67 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(3086, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 69 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                 if (Model.Status == "Available")
                {

#line default
#line hidden
            BeginContext(3158, 49, true);
            WriteLiteral("                    <p>\r\n                        ");
            EndContext();
            BeginContext(3207, 301, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de9c99276f41b0e4bbae618c3ffbf6d96f6fe6ed20729", async() => {
                BeginContext(3495, 9, true);
                WriteLiteral("Check Out");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                             WriteLiteral(Model.AssetId);

#line default
#line hidden
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
            EndContext();
            BeginContext(3508, 28, true);
            WriteLiteral("\r\n                    </p>\r\n");
            EndContext();
#line 78 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(3555, 223, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"col-md-4 detailInfo\">\r\n            <table>\r\n                <tr>\r\n                    <td class=\"itemLabel\">ISBN: </td>\r\n                    <td class=\"itemValue\">");
            EndContext();
            BeginContext(3779, 10, false);
#line 87 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                                     Write(Model.ISBN);

#line default
#line hidden
            EndContext();
            BeginContext(3789, 156, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"itemLabel\">Call Number: </td>\r\n                    <td class=\"itemValue\">");
            EndContext();
            BeginContext(3946, 21, false);
#line 91 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                                     Write(Model.DeweyCallNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3967, 161, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"itemLabel\">Replacement Cost: </td>\r\n                    <td class=\"itemValue\">");
            EndContext();
            BeginContext(4129, 10, false);
#line 95 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                                     Write(Model.Cost);

#line default
#line hidden
            EndContext();
            BeginContext(4139, 504, true);
            WriteLiteral(@"</td>
                </tr>
            </table>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-6"">
        <h4>Checkout History</h4>
        <table class=""mdl-data-table mdl-js-data-table mdl-data-table--selectable mdl-shadow--2dp"">
            <thead>
                <tr>
                    <th>Date Loaned</th>
                    <th>Date Returned</th>
                    <th>Card Id</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 113 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                 foreach (var checkout in @Model.CheckoutHistories)
                {

#line default
#line hidden
            BeginContext(4731, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4816, 19, false);
#line 117 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                       Write(checkout.CheckedOut);

#line default
#line hidden
            EndContext();
            BeginContext(4835, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4927, 18, false);
#line 120 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                       Write(checkout.CheckedIn);

#line default
#line hidden
            EndContext();
            BeginContext(4945, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5037, 23, false);
#line 123 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                       Write(checkout.LibraryCard.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5060, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 126 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(5139, 401, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""col-lg-6"">
        <h4>Current Holds</h4>
        <table class=""mdl-data-table mdl-js-data-table mdl-data-table--selectable mdl-shadow--2dp"">
            <thead>
                <tr>
                    <th>Hold Placed</th>
                    <th>Patron</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 140 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                 foreach (var hold in @Model.CurrentHolds)
                {

#line default
#line hidden
            BeginContext(5619, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5704, 15, false);
#line 144 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                       Write(hold.HoldPlaced);

#line default
#line hidden
            EndContext();
            BeginContext(5719, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5811, 15, false);
#line 147 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                       Write(hold.PatronName);

#line default
#line hidden
            EndContext();
            BeginContext(5826, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 150 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(5905, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
