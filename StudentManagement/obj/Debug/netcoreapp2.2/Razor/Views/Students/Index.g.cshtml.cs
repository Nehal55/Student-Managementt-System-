#pragma checksum "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cde75c5f4cd5c1c161dcf370e033888beeb1072"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Index.cshtml", typeof(AspNetCore.Views_Students_Index))]
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
#line 1 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement;

#line default
#line hidden
#line 1 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml"
using StudentManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cde75c5f4cd5c1c161dcf370e033888beeb1072", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bb6102ef74a0920854243dc02f5efb2e491047", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Students>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 174, true);
            WriteLiteral("\r\n<br /><br />\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6\">\r\n        <h2 class=\"text-info\">Student Details</h2>\r\n    </div>\r\n    <div class=\"col-sm-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(279, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cde75c5f4cd5c1c161dcf370e033888beeb10724311", async() => {
                BeginContext(323, 49, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; Add New Student");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(376, 225, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\" id=\"myTable\">\r\n        <thead>\r\n            <tr class=\"table-info\">\r\n\r\n\r\n                <\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(602, 32, false);
#line 29 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(634, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(702, 35, false);
#line 32 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Address));

#line default
#line hidden
            EndContext();
            BeginContext(737, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(805, 41, false);
#line 35 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.AdmissionDate));

#line default
#line hidden
            EndContext();
            BeginContext(846, 69, true);
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(916, 39, false);
#line 39 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.ClassNameId));

#line default
#line hidden
            EndContext();
            BeginContext(955, 137, true);
            WriteLiteral("\r\n                </th>\r\n\r\n                <th></th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
            EndContext();
#line 48 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1149, 56, true);
            WriteLiteral("            <tr>\r\n                \r\n                <td>");
            EndContext();
            BeginContext(1206, 9, false);
#line 52 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1215, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1243, 12, false);
#line 53 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml"
               Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1255, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1283, 18, false);
#line 54 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml"
               Write(item.AdmissionDate);

#line default
#line hidden
            EndContext();
            BeginContext(1301, 45, true);
            WriteLiteral("</td>\r\n                \r\n                <td>");
            EndContext();
            BeginContext(1347, 27, false);
#line 56 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml"
               Write(item.StudentClass.ClassName);

#line default
#line hidden
            EndContext();
            BeginContext(1374, 30, true);
            WriteLiteral("</td>\r\n\r\n\r\n            </tr>\r\n");
            EndContext();
#line 60 "C:\Users\youtechBD\Desktop\managment\StudentManagement\StudentManagement\Views\Students\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1419, 44, true);
            WriteLiteral("        </tbody>\r\n\r\n\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Students>> Html { get; private set; }
    }
}
#pragma warning restore 1591
