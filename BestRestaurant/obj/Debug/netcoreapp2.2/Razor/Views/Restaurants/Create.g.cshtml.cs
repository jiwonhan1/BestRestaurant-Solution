#pragma checksum "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ea18d6a2775dd0cc8eefe1e08ba414878e3b03f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Create), @"mvc.1.0.view", @"/Views/Restaurants/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Create.cshtml", typeof(AspNetCore.Views_Restaurants_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea18d6a2775dd0cc8eefe1e08ba414878e3b03f", @"/Views/Restaurants/Create.cshtml")]
    public class Views_Restaurants_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(70, 31, true);
            WriteLiteral("\n<h4>Add a new restaurant</h4>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(134, 44, false);
#line 10 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.RestaurantName));

#line default
#line hidden
            EndContext();
            BeginContext(184, 46, false);
#line 11 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.RestaurantName));

#line default
#line hidden
            EndContext();
            BeginContext(231, 9, true);
            WriteLiteral("    <br>\n");
            EndContext();
            BeginContext(245, 38, false);
#line 13 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(289, 40, false);
#line 14 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(330, 9, true);
            WriteLiteral("    <br>\n");
            EndContext();
            BeginContext(344, 34, false);
#line 16 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(384, 36, false);
#line 17 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(421, 9, true);
            WriteLiteral("    <br>\n");
            EndContext();
            BeginContext(435, 38, false);
#line 19 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.MainMenu));

#line default
#line hidden
            EndContext();
            BeginContext(479, 40, false);
#line 20 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.MainMenu));

#line default
#line hidden
            EndContext();
            BeginContext(520, 9, true);
            WriteLiteral("    <br>\n");
            EndContext();
            BeginContext(534, 36, false);
#line 22 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(576, 38, false);
#line 23 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(615, 9, true);
            WriteLiteral("    <br>\n");
            EndContext();
            BeginContext(625, 77, true);
            WriteLiteral("    <input class=\"btn btn-primary\" type=\"submit\" value=\"Add new Restaurant\">\n");
            EndContext();
#line 27 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
}

#line default
#line hidden
            BeginContext(704, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(709, 48, false);
#line 29 "/Users/Guest/Desktop/BestRestaurant-Solution/BestRestaurant/Views/Restaurants/Create.cshtml"
Write(Html.ActionLink("Show all restaurants", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(757, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591