#pragma checksum "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/chefandDishes/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63a75369a9cd2fb87d85b7fc5d457ad87aa74210"
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
#line 1 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/chefandDishes/Views/_ViewImports.cshtml"
using chefandDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/chefandDishes/Views/_ViewImports.cshtml"
using chefandDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a75369a9cd2fb87d85b7fc5d457ad87aa74210", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ce33df1a845925d269c1f7c35af3f51c6ca50ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/chefandDishes/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex justify-content-between align-items-center text-center"" style=""width: 200px;"">
    <a href=""/""><h3>Chefs</h3><a>  | <a href=""dishes""><h3 class=""ms-3"">Dishes</h3></a>
</div>
|  <a href=""newchef"">Add Chef</a> |
<div class=""text-center"">
    <h2>ALL CHEFS</h2>
    <table class=""table table-success table-striped"">
        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Age</th>
                <th scope=""col""># of Dishes</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/chefandDishes/Views/Home/Index.cshtml"
              
                foreach (Chef u in ViewBag.AllChefs)
                {
                    int age = ViewBag.Today.Year - u.DateOfBirth.Year;
                    if(age < 0)
                    {
                        age = 0;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td scope=\"row\">");
#nullable restore
#line 29 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/chefandDishes/Views/Home/Index.cshtml"
                                   Write(u.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 29 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/chefandDishes/Views/Home/Index.cshtml"
                                                 Write(u.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 30 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/chefandDishes/Views/Home/Index.cshtml"
                       Write(age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 31 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/chefandDishes/Views/Home/Index.cshtml"
                       Write(u.ChefDidhes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 33 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/chefandDishes/Views/Home/Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n");
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
