#pragma checksum "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fd09ecfbe5f5cb11736954c5da481704ba12ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seattle_Details), @"mvc.1.0.view", @"/Views/Seattle/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Seattle/Details.cshtml", typeof(AspNetCore.Views_Seattle_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fd09ecfbe5f5cb11736954c5da481704ba12ba7", @"/Views/Seattle/Details.cshtml")]
    public class Views_Seattle_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Seattle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(72, 62, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>Area Details</h2>\r\n    <h3>");
            EndContext();
            BeginContext(135, 44, false);
#line 9 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(179, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(183, 40, false);
#line 9 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(223, 69, true);
            WriteLiteral("</h3>\r\n\r\n    <br>\r\n    <div class=\"bottom\">\r\n        <p class=\"link\">");
            EndContext();
            BeginContext(293, 69, false);
#line 13 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml"
                   Write(Html.ActionLink("Edit this area", "Edit", new {id = Model.SeattleId}));

#line default
#line hidden
            EndContext();
            BeginContext(362, 28, true);
            WriteLiteral("\r\n        &nbsp &nbsp &nbsp ");
            EndContext();
            BeginContext(391, 73, false);
#line 14 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml"
                     Write(Html.ActionLink("Delete this area", "Delete", new {id = Model.SeattleId}));

#line default
#line hidden
            EndContext();
            BeginContext(464, 28, true);
            WriteLiteral("\r\n        &nbsp &nbsp &nbsp ");
            EndContext();
            BeginContext(493, 45, false);
#line 15 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml"
                     Write(Html.ActionLink("Back to area list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(538, 35, true);
            WriteLiteral("</p>\r\n        <!-- <p class=\"link\">");
            EndContext();
            BeginContext(574, 40, false);
#line 16 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Seattle\Details.cshtml"
                        Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(614, 28, true);
            WriteLiteral("</p> -->\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Seattle> Html { get; private set; }
    }
}
#pragma warning restore 1591
