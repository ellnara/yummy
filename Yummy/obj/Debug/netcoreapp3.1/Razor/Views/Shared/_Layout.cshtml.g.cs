#pragma checksum "C:\Users\Samedova\source\repos\Yummy\Yummy\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1bfe0b8b6749a32764605092fc737630880f011"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1bfe0b8b6749a32764605092fc737630880f011", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a82cf5cb21e746c28c7c6be02617b0a090178ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1bfe0b8b6749a32764605092fc737630880f0113223", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""stylesheet""
          href=""https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T""
          crossorigin=""anonymous"" />
    <link rel=""stylesheet""
          href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
          integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
          crossorigin=""anonymous""
          referrerpolicy=""no-referrer"" />
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"" />
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin />
    <link href=""https://fonts.googleapis.com/css2?family=Amatic+SC:wght@400;700&family=Inter:wght@200&display=swap""
          rel=""stylesheet");
                WriteLiteral(@""" />
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css""
          rel=""stylesheet""
          id=""bootstrap-css"" />
    <link rel=""stylesheet""
          href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css"" />
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"" />
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin />
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"" />
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin />
    <link href=""https://fonts.googleapis.com/css2?family=Amatic+SC:wght@400;700&display=swap""
          rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""./assets/css/main.css"" />
    <script src=""./assets/js/main.js""></script>
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <title>Yummy</title>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1bfe0b8b6749a32764605092fc737630880f0116327", async() => {
                WriteLiteral(@"
    <header>
        <nav class=""navbar navbar-expand-lg navbar-dark bg-primary"">
            <div class=""container align-items-center"">
                <div class=""navigation"">
                    <h1>Yummy<span>.</span></h1>
                    <button class=""navbar-toggler""
                            type=""button""
                            data-bs-toggle=""collapse""
                            data-bs-target=""#main_nav""
                            aria-expanded=""false""
                            aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""collapse navbar-collapse"" id=""main_nav"">
                        <ul class=""navbar-nav"">
                            <li class=""nav-item active"">
                                <a class=""nav-link"" href=""#"">Home </a>
                            </li>
                            <li class=""nav-item"">
                                <a ");
                WriteLiteral(@"class=""nav-link"" href=""#""> About </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#""> Menu </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#""> Events </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#""> Chefs </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#""> Gallery </a>
                            </li>
                            <li class=""nav-item dropdown"">
                                <a class=""nav-link"" href=""#"" data-bs-toggle=""dropdown"">
                                    Drop Down
                                    <i class=""fa-solid fa-angle-down""></i>
                                </a>");
                WriteLiteral(@"
                                <ul class=""dropdown-menu"">
                                    <li>
                                        <a class=""dropdown-item"" href=""#""> Drop Down 1</a>
                                    </li>
                                    <li>
                                        <a class=""dropdown-item"" href=""#""> Drop Down 2 </a>
                                    </li>
                                    <li>
                                        <a class=""dropdown-item"" href=""#""> Deep Drop Down </a>
                                    </li>
                                    <li>
                                        <a class=""dropdown-item"" href=""#""> Drop Down 3 </a>
                                    </li>
                                    <li>
                                        <a class=""dropdown-item"" href=""#""> Drop Down 4 </a>
                                    </li>
                                </ul>
                            </l");
                WriteLiteral(@"i>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#""> Contact </a>
                            </li>
                        </ul>
                    </div>
                    <div class=""book-table"">
                        <button>Book a Table</button>
                    </div>
                </div>
                <!-- navbar-collapse.// -->
            </div>
            <!-- container-fluid.// -->
        </nav>
    </header>
    <main>
        ");
#nullable restore
#line 109 "C:\Users\Samedova\source\repos\Yummy\Yummy\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </main>
    <footer>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-4 footer-column"">
                    <ul class=""nav flex-column"">
                        <li class=""nav-item"">
                            <span class=""footer-title"">Product</span>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Product 1</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Product 2</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Plans & Prices</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Frequently asked questions</a>
                        </li>
                    </ul>
                </div>
     ");
                WriteLiteral(@"           <div class=""col-md-4 footer-column"">
                    <ul class=""nav flex-column"">
                        <li class=""nav-item"">
                            <span class=""footer-title"">Company</span>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">About us</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Job postings</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">News and articles</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-md-4 footer-column"">
                    <ul class=""nav flex-column"">
                        <li class=""nav-item"">
                            <span class=""footer-title"">Contact & Support</span>
                        </li>
  ");
                WriteLiteral(@"                      <li class=""nav-item"">
                            <span class=""nav-link""><i class=""fas fa-phone""></i>+47 45 80 80 80</span>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#""><i class=""fas fa-comments""></i>Live chat</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#""><i class=""fas fa-envelope""></i>Contact us</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#""><i class=""fas fa-star""></i>Give feedback</a>
                        </li>
                    </ul>
                </div>
            </div>

            <div class=""text-center""><i class=""fas fa-ellipsis-h""></i></div>

            <div class=""row text-center"">
                <div class=""col-md-4 box"">
                    <span class=""copyright quick-links"">
   ");
                WriteLiteral(@"                     Copyright &copy; Your Website
                        <script>
                            document.write(new Date().getFullYear());
                        </script>
                    </span>
                </div>
                <div class=""col-md-4 box"">
                    <ul class=""list-inline social-buttons"">
                        <li class=""list-inline-item"">
                            <a href=""#"">
                                <i class=""fab fa-twitter""></i>
                            </a>
                        </li>
                        <li class=""list-inline-item"">
                            <a href=""#"">
                                <i class=""fab fa-facebook-f""></i>
                            </a>
                        </li>
                        <li class=""list-inline-item"">
                            <a href=""#"">
                                <i class=""fab fa-linkedin-in""></i>
                            </a>
                    ");
                WriteLiteral(@"    </li>
                    </ul>
                </div>
                <div class=""col-md-4 box"">
                    <ul class=""list-inline quick-links"">
                        <li class=""list-inline-item"">
                            <a href=""#"">Privacy Policy</a>
                        </li>
                        <li class=""list-inline-item"">
                            <a href=""#"">Terms of Use</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </footer>
");
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
            WriteLiteral("\r\n</html>\r\n");
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