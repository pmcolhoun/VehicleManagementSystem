#pragma checksum "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\Vehicle\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c24baebe4cc686d0a9fa8d0bb7dd37d90959d495"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_Delete), @"mvc.1.0.view", @"/Views/Vehicle/Delete.cshtml")]
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
#line 1 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\_ViewImports.cshtml"
using VMS.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\_ViewImports.cshtml"
using VMS.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\_ViewImports.cshtml"
using VMS.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c24baebe4cc686d0a9fa8d0bb7dd37d90959d495", @"/Views/Vehicle/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8296bf2ec5498a351980ec33e0259d7efc7efbd", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vehicle>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vehicle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteConfirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- Breadcrumb Navigation -->\r\n<nav aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c24baebe4cc686d0a9fa8d0bb7dd37d90959d4955582", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li class=\"breadcrumb-item\" aria-current=\"page\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c24baebe4cc686d0a9fa8d0bb7dd37d90959d4957034", async() => {
                WriteLiteral("Vehicles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </li>
        <li class=""breadcrumb-item active"" aria-current=""page""> 
            Delete
        </li>
    </ol>
</nav>

<h3 class=""mt-4 mb-4"">Delete Vehicle</h3>

<h4 class=""mb-4"">Are you sure you want to delete this vehicle?</h4>


<div>

    <!--Display the vehicle details -->
    <dl class=""row"">
         <dt class=""col-sm-3"">Make</dt>
        <dd class=""col-sm-9"">");
#nullable restore
#line 28 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\Vehicle\Delete.cshtml"
                        Write(Model.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        \r\n        <dt class=\"col-sm-3\">Model</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 31 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\Vehicle\Delete.cshtml"
                        Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        \r\n        <dt class=\"col-sm-3\">Registration</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 34 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\Vehicle\Delete.cshtml"
                        Write(Model.Registration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        \r\n        <dt class=\"col-sm-3\">Date Of Registration</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 37 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\Vehicle\Delete.cshtml"
                        Write(Model.DateOfReg.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">Age</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 40 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\Vehicle\Delete.cshtml"
                        Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">Fuel Type</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 43 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\Vehicle\Delete.cshtml"
                        Write(Model.Fuel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">Body Type</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 46 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\Vehicle\Delete.cshtml"
                        Write(Model.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">Transmission</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 49 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\Vehicle\Delete.cshtml"
                        Write(Model.Transmission);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">Engine Size</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 52 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\Vehicle\Delete.cshtml"
                        Write(Model.EngineSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        \r\n        <dt class=\"col-sm-3\">No. of Doors</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 55 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\Vehicle\Delete.cshtml"
                        Write(Model.Doors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c24baebe4cc686d0a9fa8d0bb7dd37d90959d49512161", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=", 1802, "", 1825, 1);
#nullable restore
#line 59 "C:\Users\peter\Documents\Assignment-VMS-template\VMS.Web\Views\Vehicle\Delete.cshtml"
WriteAttributeValue("", 1809, Model.VehicleId, 1809, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        \r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\"/>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c24baebe4cc686d0a9fa8d0bb7dd37d90959d49512995", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vehicle> Html { get; private set; }
    }
}
#pragma warning restore 1591
