#pragma checksum "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "451094fcea818aa58a6af1bcde3939bd05ea5f24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkOut_Create), @"mvc.1.0.view", @"/Views/WorkOut/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WorkOut/Create.cshtml", typeof(AspNetCore.Views_WorkOut_Create))]
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
#line 1 "E:\Demo\Listener\Listener\Views\_ViewImports.cshtml"
using Listener;

#line default
#line hidden
#line 2 "E:\Demo\Listener\Listener\Views\_ViewImports.cshtml"
using Listener.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"451094fcea818aa58a6af1bcde3939bd05ea5f24", @"/Views/WorkOut/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad26619572f9937959624b4e72c95766410b5ac", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkOut_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Listener.Models.WorkOut>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml"
  
    ViewBag.Title = "Add";

#line default
#line hidden
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(71, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1800ffc0d4f043d390d355ae34119319", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(123, 282, true);
            WriteLiteral(@"


<div ng-controller=""WorkOutController"" class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <h3 class=""header"">Create With WebApi and Stored Procedure</h3>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
");
            EndContext();
#line 18 "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
            BeginContext(476, 23, false);
#line 20 "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(518, 28, false);
#line 21 "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml"
           Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(550, 314, true);
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-md-6"">

                        <div class=""form-group"">
                            <label for=""cname"" class=""col-sm-4 control-label"">Date:</label>
                            <div class=""col-sm-8 space"">
                                ");
            EndContext();
            BeginContext(865, 69, false);
#line 29 "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml"
                           Write(Html.TextBoxFor(model => model.Date, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(934, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(969, 46, false);
#line 30 "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1176, 307, true);
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""address"" class=""col-sm-4 control-label"">Distance:</label>
                            <div class=""col-sm-8 space"">
                                ");
            EndContext();
            BeginContext(1484, 83, false);
#line 37 "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml"
                           Write(Html.TextAreaFor(model => model.distanceInMenters, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1602, 59, false);
#line 38 "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.distanceInMenters));

#line default
#line hidden
            EndContext();
            BeginContext(1661, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1855, 312, true);
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""country"" class=""col-sm-4 control-label"">Time(Seconds):</label>
                            <div class=""col-sm-8 space"">
                                ");
            EndContext();
            BeginContext(2168, 78, false);
#line 45 "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml"
                           Write(Html.TextBoxFor(model => model.TimeInSeconds, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2246, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2281, 55, false);
#line 46 "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.TimeInSeconds));

#line default
#line hidden
            EndContext();
            BeginContext(2336, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2519, 541, true);
            WriteLiteral(@"                            </div>
                        </div>

                        <br />
                        <div class=""form-group space"">
                            <div class=""col-sm-offset-2 col-sm-10"">
                                <p>
                                    <input type=""submit"" value=""Create"" />
                                </p>

                            </div>
                        </div>
                        <br />

                        <div>
                            ");
            EndContext();
            BeginContext(3061, 40, false);
#line 63 "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml"
                       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(3101, 86, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 67 "E:\Demo\Listener\Listener\Views\WorkOut\Create.cshtml"
            }

#line default
#line hidden
            BeginContext(3202, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Listener.Models.WorkOut> Html { get; private set; }
    }
}
#pragma warning restore 1591
