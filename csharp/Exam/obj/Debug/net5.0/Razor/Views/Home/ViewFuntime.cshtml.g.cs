#pragma checksum "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21e8a99e61c47fb240d80ee4c01838076fd0021e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewFuntime), @"mvc.1.0.view", @"/Views/Home/ViewFuntime.cshtml")]
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
#line 1 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/_ViewImports.cshtml"
using Exam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/_ViewImports.cshtml"
using Exam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21e8a99e61c47fb240d80ee4c01838076fd0021e", @"/Views/Home/ViewFuntime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060d26feffd50c5e907d7c2bbddebd29f1c8b0ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewFuntime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Funtime>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21e8a99e61c47fb240d80ee4c01838076fd0021e3258", async() => {
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21e8a99e61c47fb240d80ee4c01838076fd0021e4410", async() => {
                WriteLiteral("\n    <a href=\"/dashboard\">Dashboard</a>\n    <h1>");
#nullable restore
#line 14 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n    <h2>Event Coordinator: ");
#nullable restore
#line 15 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
                      Write(Model.User.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n    <h3>Description</h3>\n    <p>");
#nullable restore
#line 17 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
  Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    <h4>Participants:</h4>\n    <ul>\n");
#nullable restore
#line 20 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
          
            foreach (Guess u in @Model.GessesI)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>");
#nullable restore
#line 23 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
               Write(u.UserI.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n");
#nullable restore
#line 24 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\n");
#nullable restore
#line 27 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
      
            if (Model.UserId == ViewBag.UserID)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a");
                BeginWriteAttribute("href", " href=\"", 698, "\"", 728, 2);
                WriteAttributeValue("", 705, "delete/", 705, 7, true);
#nullable restore
#line 30 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
WriteAttributeValue("", 712, Model.FuntimeId, 712, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Delete</a>");
#nullable restore
#line 30 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
                                                            ;
            }
            else if (Model.GessesI.Any(f => f.UserId == ViewBag.UserID))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a");
                BeginWriteAttribute("href", " href=\"", 869, "\"", 899, 2);
                WriteAttributeValue("", 876, "remove/", 876, 7, true);
#nullable restore
#line 34 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
WriteAttributeValue("", 883, Model.FuntimeId, 883, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Leave</a>\n");
#nullable restore
#line 35 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
                }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td><a");
                BeginWriteAttribute("href", " href=\"", 982, "\"", 1014, 2);
                WriteAttributeValue("", 989, "addguess/", 989, 9, true);
#nullable restore
#line 38 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
WriteAttributeValue("", 998, Model.FuntimeId, 998, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Join</a></td>\n");
#nullable restore
#line 39 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/Exam/Views/Home/ViewFuntime.cshtml"
            }
        

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Funtime> Html { get; private set; }
    }
}
#pragma warning restore 1591
