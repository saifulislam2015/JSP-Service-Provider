#pragma checksum "E:\Demo\Listener\Listener\Views\WorkOut\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "243c22584c550d99528d6b0a13e4ad94b1f1a51f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkOut_Index), @"mvc.1.0.view", @"/Views/WorkOut/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WorkOut/Index.cshtml", typeof(AspNetCore.Views_WorkOut_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243c22584c550d99528d6b0a13e4ad94b1f1a51f", @"/Views/WorkOut/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad26619572f9937959624b4e72c95766410b5ac", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkOut_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Listener.Models.WorkOut>>
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Demo\Listener\Listener\Views\WorkOut\Index.cshtml"
  
    ViewBag.Title = "WorkOut";

#line default
#line hidden
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(88, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ada1095ea29419f83de1164aebcdbd3", async() => {
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
            BeginContext(140, 51, true);
            WriteLiteral("\r\n<div class=\"form-horizontal\">\r\n\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(192, 40, false);
#line 11 "E:\Demo\Listener\Listener\Views\WorkOut\Index.cshtml"
Write(Html.ActionLink("Add WorkOut", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(232, 426, true);
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""table-responsive"">
                <table class=""table table-bordered table-hover"" style=""width: 800px; margin-left: 170px;"">
                    <tr>
                        <th>Date</th>
                        <th>Distance</th>
                        <th>Time</th>
                        <th>Actions</th>
                    </tr>
");
            EndContext();
#line 22 "E:\Demo\Listener\Listener\Views\WorkOut\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(731, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(828, 39, false);
#line 26 "E:\Demo\Listener\Listener\Views\WorkOut\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(867, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(971, 52, false);
#line 29 "E:\Demo\Listener\Listener\Views\WorkOut\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.distanceInMenters));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1127, 48, false);
#line 32 "E:\Demo\Listener\Listener\Views\WorkOut\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TimeInSeconds));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 303, true);
            WriteLiteral(@"
                            </td>

                            <td>
                                    <p><a ng-click=""edit()"" href=""javascript:void(0);"">Edit</a> | <a ng-click=""delete()"" href=""javascript:void(0);"">Delete</a></p>
                            </td>
                        </tr>
");
            EndContext();
#line 39 "E:\Demo\Listener\Listener\Views\WorkOut\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1501, 74, true);
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2578, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Listener.Models.WorkOut>> Html { get; private set; }
    }
}
#pragma warning restore 1591
