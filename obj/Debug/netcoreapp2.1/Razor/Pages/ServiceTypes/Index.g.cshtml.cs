#pragma checksum "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1607cc5290705a4a5f3685834d1aa01dacbb3e5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SparkAuto.Pages.ServiceTypes.Pages_ServiceTypes_Index), @"mvc.1.0.razor-page", @"/Pages/ServiceTypes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ServiceTypes/Index.cshtml", typeof(SparkAuto.Pages.ServiceTypes.Pages_ServiceTypes_Index), null)]
namespace SparkAuto.Pages.ServiceTypes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\_ViewImports.cshtml"
using SparkAuto;

#line default
#line hidden
#line 3 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\_ViewImports.cshtml"
using SparkAuto.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1607cc5290705a4a5f3685834d1aa01dacbb3e5b", @"/Pages/ServiceTypes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f761ca82db339dbc6f65982e3b318e57c2553a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ServiceTypes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 227, true);
            WriteLiteral("\r\n<br />\r\n\r\n<div class=\"backgroundWhite\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <h2 class=\"text-info\">Service Type List</h2>\r\n        </div>\r\n        <div class=\"col-lg-6 text-right\">\r\n            ");
            EndContext();
            BeginContext(323, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44541142d65b4d4d8993e244c3c21a20", async() => {
                BeginContext(368, 45, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i> &nbsp; Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(417, 54, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br/>\r\n\r\n    <div>\r\n");
            EndContext();
#line 21 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
         if (Model.ServiceType.Count == 0)
        {

#line default
#line hidden
            BeginContext(526, 79, true);
            WriteLiteral("            <p>No service types exists. Please create a new service type.</p>\r\n");
            EndContext();
#line 24 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(641, 121, true);
            WriteLiteral("            <table class=\"table table-striped\">\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(763, 54, false);
#line 30 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.ServiceType[0].ServiceName));

#line default
#line hidden
            EndContext();
            BeginContext(817, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(897, 55, false);
#line 33 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.ServiceType[1].ServicePrice));

#line default
#line hidden
            EndContext();
            BeginContext(952, 108, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n                <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
                     foreach (var item in Model.ServiceType)
                    {

#line default
#line hidden
            BeginContext(1145, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1242, 38, false);
#line 42 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
                           Write(Html.DisplayFor(m => item.ServiceName));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1384, 39, false);
#line 45 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
                           Write(Html.DisplayFor(m => item.ServicePrice));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 208, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>                               \r\n                                <div class=\"btn-group\" role=\"group\">\r\n                                    ");
            EndContext();
            BeginContext(1631, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da069797e1f04ddbbf34b82286544dfd", async() => {
                BeginContext(1698, 32, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i> Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
                                                                                 WriteLiteral(item.Id);

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
            BeginContext(1734, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1772, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e0f8dd1bc649ca9dd41dfee0da68de", async() => {
                BeginContext(1840, 39, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i> Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
                                                                                  WriteLiteral(item.Id);

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
            BeginContext(1883, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1921, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fc923bfa35143be88e20521eecccfc4", async() => {
                BeginContext(1991, 39, true);
                WriteLiteral("<i class=\"fas fa-list-alt\"></i> Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
                                                                                    WriteLiteral(item.Id);

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
            BeginContext(2034, 108, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 55 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2165, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 58 "C:\Users\csanders\Projects\SparkAuto\SparkAuto\Pages\ServiceTypes\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2224, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SparkAuto.Pages.ServiceTypes.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SparkAuto.Pages.ServiceTypes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SparkAuto.Pages.ServiceTypes.IndexModel>)PageContext?.ViewData;
        public SparkAuto.Pages.ServiceTypes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
