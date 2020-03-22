#pragma checksum "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bfad550ad0134fbf648880d4b0e44112c0db580"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seattle_Index), @"mvc.1.0.view", @"/Views/Seattle/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Seattle/Index.cshtml", typeof(AspNetCore.Views_Seattle_Index))]
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
#line 5 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml"
using BestRestaurant.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bfad550ad0134fbf648880d4b0e44112c0db580", @"/Views/Seattle/Index.cshtml")]
    public class Views_Seattle_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BestRestaurant.Models.Seattle>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(110, 73, true);
            WriteLiteral("\r\n<div class=\"seattleIndex\">\r\n\r\n    <h1>List of Areas in Seattle</h1>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml"
     if (TempData.ContainsKey("ErrorMessage"))  {

#line default
#line hidden
            BeginContext(234, 24, true);
            WriteLiteral("    <h3>Error message: \"");
            EndContext();
            BeginContext(259, 24, false);
#line 13 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml"
                   Write(TempData["ErrorMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(283, 8, true);
            WriteLiteral("\"</h3>\r\n");
            EndContext();
#line 14 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(298, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 15 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml"
     if(Model.Count == 0)
    {

#line default
#line hidden
            BeginContext(332, 47, true);
            WriteLiteral("        <h3>No Area have been added yet.</h3>\r\n");
            EndContext();
#line 18 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml"
    }

    else
    {

#line default
#line hidden
            BeginContext(405, 32, true);
            WriteLiteral("        <div id=\"listOfAreas\">\r\n");
            EndContext();
#line 23 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml"
         foreach(Seattle seattle in Model)
        {

#line default
#line hidden
            BeginContext(492, 16, true);
            WriteLiteral("            <h3>");
            EndContext();
            BeginContext(509, 79, false);
#line 25 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml"
           Write(Html.ActionLink($"{seattle.AreaName}", "Details", new {id = seattle.SeattleId}));

#line default
#line hidden
            EndContext();
            BeginContext(588, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 26 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(606, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 28 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(629, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(633, 41, false);
#line 29 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Index.cshtml"
Write(Html.ActionLink("Add new area", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(674, 12, true);
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BestRestaurant.Models.Seattle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
