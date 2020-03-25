#pragma checksum "C:\dotnetdev\Newbies\eLibrary.UI\Views\Branch\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bb9e056695b9db5f7697d282f6459c4363bfeaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branch_Index), @"mvc.1.0.view", @"/Views/Branch/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Branch/Index.cshtml", typeof(AspNetCore.Views_Branch_Index))]
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
#line 1 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Branch\Index.cshtml"
using eLibrary.UI.Models.Branch;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bb9e056695b9db5f7697d282f6459c4363bfeaf", @"/Views/Branch/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d38c9a900e556af2768fef4a324203bba2d7a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Branch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Branch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Branch\Index.cshtml"
  
    ViewBag.Title = "Branch Index";

#line default
#line hidden
            BeginContext(80, 427, true);
            WriteLiteral(@"<h3>Branch Index</h3>
<div id=""branchIndex"">
    <table class=""mdl-data-table mdl-js-data-table mdl-data-table--selectable mdl-shadow--2dp customTable"" id=""branchIndexTable"">
        <thead>
            <tr>
                <th>Branch Name</th>
                <th>Open Now</th>
                <th>Number Of Assets</th>
                <th>Number of Patrons</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 18 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Branch\Index.cshtml"
             foreach (var branch in Model.Branches)
            {

#line default
#line hidden
            BeginContext(575, 63, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"strongTd\">");
            EndContext();
            BeginContext(638, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bb9e056695b9db5f7697d282f6459c4363bfeaf4874", async() => {
                BeginContext(712, 17, false);
#line 21 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Branch\Index.cshtml"
                                                                                                             Write(branch.BranchName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Branch\Index.cshtml"
                                                                                          WriteLiteral(branch.Id);

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
            BeginContext(733, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(765, 13, false);
#line 22 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Branch\Index.cshtml"
                   Write(branch.IsOpen);

#line default
#line hidden
            EndContext();
            BeginContext(778, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(810, 21, false);
#line 23 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Branch\Index.cshtml"
                   Write(branch.NumberOfAssets);

#line default
#line hidden
            EndContext();
            BeginContext(831, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(863, 22, false);
#line 24 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Branch\Index.cshtml"
                   Write(branch.NumberOfPatrons);

#line default
#line hidden
            EndContext();
            BeginContext(885, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 26 "C:\dotnetdev\Newbies\eLibrary.UI\Views\Branch\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(930, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
