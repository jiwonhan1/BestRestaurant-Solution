#pragma checksum "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cd537e149e1dbf5a0fa8a0fbd1ec63980e3c1db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Details), @"mvc.1.0.view", @"/Views/Restaurants/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Details.cshtml", typeof(AspNetCore.Views_Restaurants_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd537e149e1dbf5a0fa8a0fbd1ec63980e3c1db", @"/Views/Restaurants/Details.cshtml")]
    public class Views_Restaurants_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(75, 99, true);
            WriteLiteral("<div class=\"restaurantDetails\">\r\n    <h2>Restaurant Details<h2>\r\n        <hr />\r\n        <h3>Area: ");
            EndContext();
            BeginContext(175, 16, false);
#line 9 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml"
             Write(ViewBag.AreaName);

#line default
#line hidden
            EndContext();
            BeginContext(191, 36, true);
            WriteLiteral("</h3>\r\n        <h3>Restaurant Name: ");
            EndContext();
            BeginContext(228, 46, false);
#line 10 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml"
                        Write(Html.DisplayFor(model => model.RestaurantName));

#line default
#line hidden
            EndContext();
            BeginContext(274, 19, true);
            WriteLiteral("</h3>\r\n        <h3>");
            EndContext();
            BeginContext(294, 44, false);
#line 11 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(338, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(341, 40, false);
#line 11 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml"
                                                      Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(381, 19, true);
            WriteLiteral("</h3>\r\n        <h3>");
            EndContext();
            BeginContext(401, 40, false);
#line 12 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(441, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(444, 36, false);
#line 12 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(480, 30, true);
            WriteLiteral("</h3>\r\n        <h3>Main Menu: ");
            EndContext();
            BeginContext(511, 40, false);
#line 13 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml"
                  Write(Html.DisplayFor(model => model.MainMenu));

#line default
#line hidden
            EndContext();
            BeginContext(551, 19, true);
            WriteLiteral("</h3>\r\n        <h3>");
            EndContext();
            BeginContext(571, 42, false);
#line 14 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(613, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(616, 38, false);
#line 14 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(654, 75, true);
            WriteLiteral("</h3>\r\n        <hr />\r\n\r\n    <div id=\"restaurantDetailsLinks\">\r\n        <p>");
            EndContext();
            BeginContext(730, 78, false);
#line 18 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml"
      Write(Html.ActionLink("Edit this Restaurant", "Edit", new {id = Model.RestaurantId}));

#line default
#line hidden
            EndContext();
            BeginContext(808, 44, true);
            WriteLiteral("</p>\r\n        &nbsp &nbsp &nbsp\r\n        <p>");
            EndContext();
            BeginContext(853, 82, false);
#line 20 "C:\Users\Jiwon Han\desktop\coding\c#\BestRestaurant-Solution\BestRestaurant\Views\Restaurants\Details.cshtml"
      Write(Html.ActionLink("Delete this Restaurant", "Delete", new {id = Model.RestaurantId}));

#line default
#line hidden
            EndContext();
            BeginContext(935, 26, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
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
