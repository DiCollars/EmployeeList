#pragma checksum "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "328e33a0b21a73875cece27190c67b9a9e6ad33d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\_ViewImports.cshtml"
using EmployeeList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\_ViewImports.cshtml"
using EmployeeList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"328e33a0b21a73875cece27190c67b9a9e6ad33d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab4ff3577521d80a7e92fd80c9f0d6f814cca0c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeList.Models.ViewModels.ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Previous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link bg-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Employee list";
    string DecreeViewFormatter(bool status)
    {
        if (status)
        {
            return "10004";
        }
        else
        {
            return "10008";
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Full name</th>
            <th scope=""col"">Position</th>
            <th scope=""col"">Birthday</th>
            <th scope=""col"">Decree</th>
            <th scope=""col"">Characteristic</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 28 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
         foreach (var Employee in Model.Employees)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
               Write(Employee.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
               Write(Employee.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
               Write(Employee.Birthday.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>&#");
#nullable restore
#line 34 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
                 Write(DecreeViewFormatter(Employee.Decree));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
               Write(Employee.Characteristic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<nav aria-label=\"Page navigation example\">\r\n    <ul class=\"pagination\">\r\n\r\n");
#nullable restore
#line 43 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
         if (Model.PageViewModel.HasPreviousPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "328e33a0b21a73875cece27190c67b9a9e6ad33d7450", async() => {
                WriteLiteral("\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                    <span class=\"sr-only\">Previous</span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1250, "~/Home/Index/", 1250, 13, true);
#nullable restore
#line 46 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1263, Model.PageViewModel.PageNumber - 1, 1263, 37, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 51 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
         for (int i = 1; i <= Model.PageViewModel.TotalPages; i++)
        {
            if (@Model.PageViewModel.PageNumber == i)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "328e33a0b21a73875cece27190c67b9a9e6ad33d9856", async() => {
#nullable restore
#line 56 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
                                                                                     Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1720, "~/Home/Index/", 1720, 13, true);
#nullable restore
#line 56 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1733, i, 1733, 2, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 57 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "328e33a0b21a73875cece27190c67b9a9e6ad33d11930", async() => {
#nullable restore
#line 60 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
                                                                             Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1863, "~/Home/Index/", 1863, 13, true);
#nullable restore
#line 60 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1876, i, 1876, 2, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 61 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
         if (Model.PageViewModel.HasNextPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "328e33a0b21a73875cece27190c67b9a9e6ad33d14200", async() => {
                WriteLiteral("\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                    <span class=\"sr-only\">Next</span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2056, "~/Home/Index/", 2056, 13, true);
#nullable restore
#line 66 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2069, Model.PageViewModel.PageNumber + 1, 2069, 37, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 71 "C:\Users\DI\Desktop\EmployeeList\EmployeeList\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeList.Models.ViewModels.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
