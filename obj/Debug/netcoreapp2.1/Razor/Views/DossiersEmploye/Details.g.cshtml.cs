#pragma checksum "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1addb52a9e4fb0e276b2e61f3999c93c299df37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DossiersEmploye_Details), @"mvc.1.0.view", @"/Views/DossiersEmploye/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DossiersEmploye/Details.cshtml", typeof(AspNetCore.Views_DossiersEmploye_Details))]
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
#line 1 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/_ViewImports.cshtml"
using Garderie;

#line default
#line hidden
#line 2 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/_ViewImports.cshtml"
using Garderie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1addb52a9e4fb0e276b2e61f3999c93c299df37", @"/Views/DossiersEmploye/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fd06d82c8438d05622e08f6556b645a0b156553", @"/Views/_ViewImports.cshtml")]
    public class Views_DossiersEmploye_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Garderie.Models.DossierEmploye>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 128, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>DossierEmploye</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(213, 46, false);
#line 14 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateEntree));

#line default
#line hidden
            EndContext();
            BeginContext(259, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(303, 42, false);
#line 17 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
       Write(Html.DisplayFor(model => model.DateEntree));

#line default
#line hidden
            EndContext();
            BeginContext(345, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(389, 52, false);
#line 20 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NbMoisAnciennete));

#line default
#line hidden
            EndContext();
            BeginContext(441, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(485, 48, false);
#line 23 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
       Write(Html.DisplayFor(model => model.NbMoisAnciennete));

#line default
#line hidden
            EndContext();
            BeginContext(533, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(577, 51, false);
#line 26 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TauxHoraireBrut));

#line default
#line hidden
            EndContext();
            BeginContext(628, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(672, 47, false);
#line 29 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
       Write(Html.DisplayFor(model => model.TauxHoraireBrut));

#line default
#line hidden
            EndContext();
            BeginContext(719, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(763, 43, false);
#line 32 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Visible));

#line default
#line hidden
            EndContext();
            BeginContext(806, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(850, 39, false);
#line 35 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
       Write(Html.DisplayFor(model => model.Visible));

#line default
#line hidden
            EndContext();
            BeginContext(889, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(933, 43, false);
#line 38 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employe));

#line default
#line hidden
            EndContext();
            BeginContext(976, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1020, 49, false);
#line 41 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
       Write(Html.DisplayFor(model => model.Employe.EmployeId));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1113, 47, false);
#line 44 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeContrat));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1204, 57, false);
#line 47 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
       Write(Html.DisplayFor(model => model.TypeContrat.TypeContratId));

#line default
#line hidden
            EndContext();
            BeginContext(1261, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1308, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf02203fbe94edf9c340d2650499e6a", async() => {
                BeginContext(1361, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/DossiersEmploye/Details.cshtml"
                           WriteLiteral(Model.DossierId);

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
            BeginContext(1369, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1377, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cb90d84bb274721857552397de1fbbb", async() => {
                BeginContext(1399, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1415, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Garderie.Models.DossierEmploye> Html { get; private set; }
    }
}
#pragma warning restore 1591
