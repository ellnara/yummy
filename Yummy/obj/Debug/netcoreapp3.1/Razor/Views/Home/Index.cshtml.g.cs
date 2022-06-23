#pragma checksum "C:\Users\Samedova\source\repos\Yummy\Yummy\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea57aaec3e9761bf6b525c59d09450585b96ca3"
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
#line 1 "C:\Users\Samedova\source\repos\Yummy\Yummy\Views\_ViewImports.cshtml"
using Yummy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samedova\source\repos\Yummy\Yummy\Views\_ViewImports.cshtml"
using Yummy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea57aaec3e9761bf6b525c59d09450585b96ca3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a82cf5cb21e746c28c7c6be02617b0a090178ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Samedova\source\repos\Yummy\Yummy\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""home"">
    <div class=""container home-content"">
        <div class=""row d-flex"">
            <div class=""summary col-lg-6 col-sm-12"">
                <h2>Enjoy Your Healthy Delicious Food</h2>
                <p>
                    Sed autem laudantium dolores. Voluptatem itaque ea consequatur
                    eveniet. Eum quas beatae cumque eum quaerat.
                </p>
                <div class=""home-buttons d-flex"">
                    <button>Book a Table</button>
                    <a");
            BeginWriteAttribute("href", " href=\"", 575, "\"", 582, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <i class=""bi bi-play-circle""></i>
                        <span>Watch Video</span>
                    </a>
                </div>
            </div>
            <div class=""enjoy-image col-lg-6 col-sm-12"">
                <img src=""./assets/images/hero-img.png""");
            BeginWriteAttribute("alt", " alt=\"", 878, "\"", 884, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>
        </div>
    </div>
</section>
<section id=""menu"">
    <div class=""container"">
        <div class=""menu-context"">
            <div class=""heading"">
                <span>OUR MENU</span>
                <h2>Check Our <span>Yummy Menu</span></h2>
                <ul class=""menu-filter"">
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1238, "\"", 1245, 0);
            EndWriteAttribute();
            WriteLiteral(">Starters</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1292, "\"", 1299, 0);
            EndWriteAttribute();
            WriteLiteral(">Breakfast</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1347, "\"", 1354, 0);
            EndWriteAttribute();
            WriteLiteral(">Lunch</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1398, "\"", 1405, 0);
            EndWriteAttribute();
            WriteLiteral(">Dinner</a></li>\r\n                </ul>\r\n                <span>MENU</span>\r\n                <h3>Starters</h3>\r\n            </div>\r\n        </div>\r\n        <div class=\"menu-foods\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 46 "C:\Users\Samedova\source\repos\Yummy\Yummy\Views\Home\Index.cshtml"
                 foreach (var food in Model.Food)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"foods\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1757, "\"", 1793, 2);
            WriteAttributeValue("", 1763, "./assets/images/", 1763, 16, true);
#nullable restore
#line 49 "C:\Users\Samedova\source\repos\Yummy\Yummy\Views\Home\Index.cshtml"
WriteAttributeValue("", 1779, food.ImageUrl, 1779, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1794, "\"", 1800, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <div class=\"food-info\">\r\n                            <h4>");
#nullable restore
#line 51 "C:\Users\Samedova\source\repos\Yummy\Yummy\Views\Home\Index.cshtml"
                           Write(food.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p>");
#nullable restore
#line 52 "C:\Users\Samedova\source\repos\Yummy\Yummy\Views\Home\Index.cshtml"
                          Write(food.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <span>");
#nullable restore
#line 53 "C:\Users\Samedova\source\repos\Yummy\Yummy\Views\Home\Index.cshtml"
                             Write(food.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 56 "C:\Users\Samedova\source\repos\Yummy\Yummy\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>
<section id=""book"">
    <div class=""container"">
        <div class=""heading"">
            <span>BOOK A TABLE</span>
            <h2>Book <span>Your Stay </span> With Us</h2>
        </div>
        <div class=""book-table d-flex"">
            <div class=""book-image"">
                <img src=""./assets/images/reservation.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2483, "\"", 2489, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ea57aaec3e9761bf6b525c59d09450585b96ca38683", async() => {
                WriteLiteral("\r\n                <div class=\"row d-flex\">\r\n                    <div");
                BeginWriteAttribute("class", " class=\"", 2611, "\"", 2619, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 2665, "\"", 2672, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2673, "\"", 2678, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Your Name\" />\r\n                    </div>\r\n                    <div");
                BeginWriteAttribute("class", " class=\"", 2760, "\"", 2768, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"email\"");
                BeginWriteAttribute("name", " name=\"", 2815, "\"", 2822, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2823, "\"", 2828, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Your Email\" />\r\n                    </div>\r\n                    <div");
                BeginWriteAttribute("class", " class=\"", 2911, "\"", 2919, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 2965, "\"", 2972, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2973, "\"", 2978, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Your  Phone\" />\r\n                    </div>\r\n                </div>\r\n                <div class=\"row d-flex\">\r\n                    <div");
                BeginWriteAttribute("class", " class=\"", 3128, "\"", 3136, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 3182, "\"", 3189, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3190, "\"", 3195, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Date\" />\r\n                    </div>\r\n                    <div");
                BeginWriteAttribute("class", " class=\"", 3272, "\"", 3280, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 3326, "\"", 3333, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3334, "\"", 3339, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Time\" />\r\n                    </div>\r\n                    <div");
                BeginWriteAttribute("class", " class=\"", 3416, "\"", 3424, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 3470, "\"", 3477, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3478, "\"", 3483, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"# of people\" />\r\n                    </div>\r\n                </div>\r\n                <div class=\"row d-flex\">\r\n                    <input class=\"message\"\r\n                           type=\"text\"");
                BeginWriteAttribute("name", "\r\n                           name=\"", 3691, "\"", 3726, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", "\r\n                           id=\"", 3727, "\"", 3760, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                           placeholder=\"Message\" />\r\n                </div>\r\n                <button>BOOK A TABLE</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>");
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
