#pragma checksum "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/CRUDelicious/Views/Home/View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "744d636fbd835a85177dbbf04c7cc9bc368f5ab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_View), @"mvc.1.0.view", @"/Views/Home/View.cshtml")]
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
#line 1 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"744d636fbd835a85177dbbf04c7cc9bc368f5ab5", @"/Views/Home/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4779ab41f2eae97fa15e3c80143eae3630cac17", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "744d636fbd835a85177dbbf04c7cc9bc368f5ab53691", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Document</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "744d636fbd835a85177dbbf04c7cc9bc368f5ab54841", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "744d636fbd835a85177dbbf04c7cc9bc368f5ab55099", async() => {
                    WriteLiteral("Home");
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
                WriteLiteral("\n    <div class=\"top\">\n    <h1>");
#nullable restore
#line 12 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/CRUDelicious/Views/Home/View.cshtml"
   Write(ViewBag.DisH.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n    <h4>");
#nullable restore
#line 13 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/CRUDelicious/Views/Home/View.cshtml"
   Write(ViewBag.DisH.ChefName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n    </div>\n    <p><b>Description:</b>   ");
#nullable restore
#line 15 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/CRUDelicious/Views/Home/View.cshtml"
                        Write(ViewBag.DisH.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    <p><b>Calories:</b>   ");
#nullable restore
#line 16 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/CRUDelicious/Views/Home/View.cshtml"
                     Write(ViewBag.DisH.Calories);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    <p><b>Taistiness:</b>   ");
#nullable restore
#line 17 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/CRUDelicious/Views/Home/View.cshtml"
                       Write(ViewBag.DisH.Tastiness);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n\n    <a");
                BeginWriteAttribute("href", " href=\"", 554, "\"", 587, 2);
                WriteAttributeValue("", 561, "/edit/", 561, 6, true);
#nullable restore
#line 19 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/CRUDelicious/Views/Home/View.cshtml"
WriteAttributeValue("", 567, ViewBag.DisH.DishId, 567, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success btn-sm\">Edit</a>  |  <a");
                BeginWriteAttribute("href", " href=\"", 635, "\"", 670, 2);
                WriteAttributeValue("", 642, "/delete/", 642, 8, true);
#nullable restore
#line 19 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/CRUDelicious/Views/Home/View.cshtml"
WriteAttributeValue("", 650, ViewBag.DisH.DishId, 650, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger btn-sm\">Delete</a>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
