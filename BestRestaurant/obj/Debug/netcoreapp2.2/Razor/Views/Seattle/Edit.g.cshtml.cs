#pragma checksum "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80e9bab05935fa9627216b7466164a7bb33ee77e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seattle_Edit), @"mvc.1.0.view", @"/Views/Seattle/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Seattle/Edit.cshtml", typeof(AspNetCore.Views_Seattle_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e9bab05935fa9627216b7466164a7bb33ee77e", @"/Views/Seattle/Edit.cshtml")]
    public class Views_Seattle_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Seattle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Edit.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(66, 27, true);
            WriteLiteral("\n<h2>Edit this restaurant: ");
            EndContext();
            BeginContext(94, 40, false);
#line 6 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Edit.cshtml"
                     Write(Html.DisplayFor(model => model.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(134, 7, true);
            WriteLiteral("</h2>\n\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(174, 40, false);
#line 10 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Edit.cshtml"
Write(Html.HiddenFor(model => model.SeattleId));

#line default
#line hidden
            EndContext();
            BeginContext(221, 38, false);
#line 12 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Edit.cshtml"
Write(Html.LabelFor(model => model.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(265, 39, false);
#line 13 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Edit.cshtml"
Write(Html.EditorFor(model => model.AreaName));

#line default
#line hidden
            EndContext();
            BeginContext(306, 63, true);
            WriteLiteral("    <input class=\"btn btn-primary\" type=\"submit\" value=\"save\">\n");
            EndContext();
#line 16 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(371, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(376, 45, false);
#line 18 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Seattle/Edit.cshtml"
Write(Html.ActionLink("Back to area list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(421, 4, true);
            WriteLiteral("</p>");
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