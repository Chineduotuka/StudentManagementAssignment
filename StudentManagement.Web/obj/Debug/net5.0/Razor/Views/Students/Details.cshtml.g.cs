#pragma checksum "C:\Users\solan\OneDrive\Desktop\obia's class project\StudentManagement (1)\StudentManagement\StudentManagement.Web\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6a1f5343bf4333b562b2a143d7d2569afbd2638"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
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
#line 1 "C:\Users\solan\OneDrive\Desktop\obia's class project\StudentManagement (1)\StudentManagement\StudentManagement.Web\Views\_ViewImports.cshtml"
using StudentManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\solan\OneDrive\Desktop\obia's class project\StudentManagement (1)\StudentManagement\StudentManagement.Web\Views\_ViewImports.cshtml"
using StudentManagement.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a1f5343bf4333b562b2a143d7d2569afbd2638", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd207fc3d1c1377e55dc262f93440052706cc60", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagement.Dtos.StudentDtos.StudentResponseDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\solan\OneDrive\Desktop\obia's class project\StudentManagement (1)\StudentManagement\StudentManagement.Web\Views\Students\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\solan\OneDrive\Desktop\obia's class project\StudentManagement (1)\StudentManagement\StudentManagement.Web\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</br>\r\n            ");
#nullable restore
#line 15 "C:\Users\solan\OneDrive\Desktop\obia's class project\StudentManagement (1)\StudentManagement\StudentManagement.Web\Views\Students\Details.cshtml"
       Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "C:\Users\solan\OneDrive\Desktop\obia's class project\StudentManagement (1)\StudentManagement\StudentManagement.Web\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FavouriteQuote));

#line default
#line hidden
#nullable disable
            WriteLiteral("</br>\r\n            ");
#nullable restore
#line 19 "C:\Users\solan\OneDrive\Desktop\obia's class project\StudentManagement (1)\StudentManagement\StudentManagement.Web\Views\Students\Details.cshtml"
       Write(Model.FavouriteQuote);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\solan\OneDrive\Desktop\obia's class project\StudentManagement (1)\StudentManagement\StudentManagement.Web\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</br>\r\n            ");
#nullable restore
#line 23 "C:\Users\solan\OneDrive\Desktop\obia's class project\StudentManagement (1)\StudentManagement\StudentManagement.Web\Views\Students\Details.cshtml"
       Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\solan\OneDrive\Desktop\obia's class project\StudentManagement (1)\StudentManagement\StudentManagement.Web\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastUpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</br>\r\n            ");
#nullable restore
#line 27 "C:\Users\solan\OneDrive\Desktop\obia's class project\StudentManagement (1)\StudentManagement\StudentManagement.Web\Views\Students\Details.cshtml"
       Write(Model.LastUpdatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>  \r\n           \r\n    </dl>\r\n</div>\r\n<div>\r\n");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6a1f5343bf4333b562b2a143d7d2569afbd26386998", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n    \r\n \r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentManagement.Dtos.StudentDtos.StudentResponseDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
