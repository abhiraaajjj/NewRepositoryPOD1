#pragma checksum "C:\Users\Abhi\source\repos\Audit Management System - POD1\AuditManagementPortalClientMVC\Views\Home\Checklist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3269ef54b88f48ffd25c8f7ff78a2aa4c327bd41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Checklist), @"mvc.1.0.view", @"/Views/Home/Checklist.cshtml")]
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
#line 1 "C:\Users\Abhi\source\repos\Audit Management System - POD1\AuditManagementPortalClientMVC\Views\_ViewImports.cshtml"
using AuditManagementPortalClientMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abhi\source\repos\Audit Management System - POD1\AuditManagementPortalClientMVC\Views\_ViewImports.cshtml"
using AuditManagementPortalClientMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3269ef54b88f48ffd25c8f7ff78a2aa4c327bd41", @"/Views/Home/Checklist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d6869f38201b3cd0daebbe0fa6ea487d04170ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Checklist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AuditManagementPortalClientMVC.Models.CQuestions>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Severity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family:\'Times New Roman\'"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Abhi\source\repos\Audit Management System - POD1\AuditManagementPortalClientMVC\Views\Home\Checklist.cshtml"
   Layout = "_Authenticated"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abhi\source\repos\Audit Management System - POD1\AuditManagementPortalClientMVC\Views\Home\Checklist.cshtml"
   ViewData["Title"] = "Checklist"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 7 "C:\Users\Abhi\source\repos\Audit Management System - POD1\AuditManagementPortalClientMVC\Views\Home\Checklist.cshtml"
   int count = 0; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3269ef54b88f48ffd25c8f7ff78a2aa4c327bd415454", async() => {
                WriteLiteral(@"

    <h1 style=""font-family:'Times New Roman'"">Enter Project Details</h1>
    <div class=""form-group"">
        <label class=""pname control-label"">Project Name<span style=""color:red;"">*</span></label>
        <input required type=""text"" id=""projName"" name=""projName"" class=""pname form-control"" />
    </div>
    <div class=""form-group"">
        <label class=""mname control-label"">Project Manager Name<span style=""color:red;"">*</span></label>
        <input required type=""text"" id=""mngrName"" name=""mngrName"" class=""mname form-control"" />
    </div>
    <div class=""form-group"">
        <label class=""oname control-label"">Application Owner Name<span style=""color:red;"">*</span></label>
        <input required type=""text"" id=""appOwnerName"" name=""appOwnerName"" class=""oname form-control"" />
    </div>
    <div class=""form-group"">
        <label class=""datee control-label"">Date<span style=""color:red;"">*</span></label>
        <input required type=""date"" id=""audDate"" name=""audDate"" class=""datee form-control"" />
    </div>

");
                WriteLiteral("\n    <h1>Checklist Questions</h1>\n    <table class=\"table\">\n");
                WriteLiteral("        <tbody>\n");
#nullable restore
#line 41 "C:\Users\Abhi\source\repos\Audit Management System - POD1\AuditManagementPortalClientMVC\Views\Home\Checklist.cshtml"
             foreach (var item in Model)
            {
                count = count + 1;
                string j = "q" + count.ToString();


#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\n\n    <td>\n        ");
#nullable restore
#line 49 "C:\Users\Abhi\source\repos\Audit Management System - POD1\AuditManagementPortalClientMVC\Views\Home\Checklist.cshtml"
   Write(Html.DisplayFor(modelItem => item.Question));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </td>\n    <td><input value=\"true\" type=\"checkbox\" class=\"form-group\"");
                BeginWriteAttribute("id", " id=\"", 1870, "\"", 1877, 1);
#nullable restore
#line 51 "C:\Users\Abhi\source\repos\Audit Management System - POD1\AuditManagementPortalClientMVC\Views\Home\Checklist.cshtml"
WriteAttributeValue("", 1875, j, 1875, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1878, "\"", 1887, 1);
#nullable restore
#line 51 "C:\Users\Abhi\source\repos\Audit Management System - POD1\AuditManagementPortalClientMVC\Views\Home\Checklist.cshtml"
WriteAttributeValue("", 1885, j, 1885, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\n</tr>");
#nullable restore
#line 52 "C:\Users\Abhi\source\repos\Audit Management System - POD1\AuditManagementPortalClientMVC\Views\Home\Checklist.cshtml"
     }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\n    </table>\n\n    <div class=\"form-group\">\n        <input type=\"submit\" value=\"Submit\" class=\"btn btn-success\" />\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AuditManagementPortalClientMVC.Models.CQuestions>> Html { get; private set; }
    }
}
#pragma warning restore 1591
