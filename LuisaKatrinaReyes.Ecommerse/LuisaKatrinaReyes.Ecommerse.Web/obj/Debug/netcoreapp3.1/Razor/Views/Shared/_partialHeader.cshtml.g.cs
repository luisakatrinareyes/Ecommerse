#pragma checksum "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Shared\_partialHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79e8162083ad086cde39bb6a20ced478efa60a65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__partialHeader), @"mvc.1.0.view", @"/Views/Shared/_partialHeader.cshtml")]
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
#line 1 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\_ViewImports.cshtml"
using LuisaKatrinaReyes.Ecommerse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\_ViewImports.cshtml"
using LuisaKatrinaReyes.Ecommerse.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e8162083ad086cde39bb6a20ced478efa60a65", @"/Views/Shared/_partialHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d3b2d51cbf0506c85132cc12a1aa7e62114768c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__partialHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"		<!-- Header -->
<header class=""header shop"">
    <!-- Topbar -->
    <div class=""topbar"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 col-md-12 col-12"">
                    <!-- Top Left -->
                    <div class=""top-left"">
                        <ul class=""list-main"">
                            <li><i class=""ti-headphone-alt""></i> +060 (800) 801-582</li>
                            <li><i class=""ti-email""></i> support@shophub.com</li>
                        </ul>
                    </div>
                    <!--/ End Top Left -->
                </div>
                <div class=""col-lg-8 col-md-12 col-12"">
                    <!-- Top Right -->
                    <div class=""right-content"">
                        <ul class=""list-main"">
                            <li><i class=""ti-location-pin""></i> Store location</li>
                            <li><i class=""ti-alarm-clock""></i> <a href=""#"">Daily deal</a></li>
 ");
            WriteLiteral(@"                           <li><i class=""ti-user""></i> <a href=""#"">My account</a></li>
                            <li><i class=""ti-power-off""></i><a href=""login.html#"">Login</a></li>
                        </ul>
                    </div>
                    <!-- End Top Right -->
                </div>
            </div>
        </div>
    </div>
    <!-- End Topbar -->
    <div class=""middle-inner"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-2 col-md-2 col-12"">
                    <!-- Logo -->
                    <div class=""logo"">
                        <a href=""index.html""><img src=""images/logo.png"" alt=""logo""></a>
                    </div>
                    <!--/ End Logo -->
                    <!-- Search Form -->
                    <div class=""search-top"">
                        <div class=""top-search""><a href=""#0""><i class=""ti-search""></i></a></div>
                        <!-- Search Form -->
                      ");
            WriteLiteral("  <div class=\"search-top\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e8162083ad086cde39bb6a20ced478efa60a656429", async() => {
                WriteLiteral("\r\n                                <input type=\"text\" placeholder=\"Search here...\" name=\"search\">\r\n                                <button value=\"search\" type=\"submit\"><i class=\"ti-search\"></i></button>\r\n                            ");
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
            WriteLiteral(@"
                        </div>
                        <!--/ End Search Form -->
                    </div>
                    <!--/ End Search Form -->
                    <div class=""mobile-nav""></div>
                </div>
                <div class=""col-lg-8 col-md-7 col-12"">
                    <div class=""search-bar-top"">
                        <div class=""search-bar"">
                            <select>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e8162083ad086cde39bb6a20ced478efa60a658455", async() => {
                WriteLiteral("All Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e8162083ad086cde39bb6a20ced478efa60a659534", async() => {
                WriteLiteral("watch");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e8162083ad086cde39bb6a20ced478efa60a6510523", async() => {
                WriteLiteral("mobile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e8162083ad086cde39bb6a20ced478efa60a6511514", async() => {
                WriteLiteral("kid’s item");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </select>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e8162083ad086cde39bb6a20ced478efa60a6512546", async() => {
                WriteLiteral("\r\n                                <input name=\"search\" placeholder=\"Search Products Here.....\" type=\"search\">\r\n                                <button class=\"btnn\"><i class=\"ti-search\"></i></button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-lg-2 col-md-3 col-12"">
                    <div class=""right-bar"">
                        <!-- Search Form -->
                        <div class=""sinlge-bar"">
                            <a href=""#"" class=""single-icon""><i class=""fa fa-heart-o"" aria-hidden=""true""></i></a>
                        </div>
                        <div class=""sinlge-bar"">
                            <a href=""#"" class=""single-icon""><i class=""fa fa-user-circle-o"" aria-hidden=""true""></i></a>
                        </div>
                        <div class=""sinlge-bar shopping"">
                            <a href=""#"" class=""single-icon""><i class=""ti-bag""></i> <span class=""total-count"">2</span></a>
                            <!-- Shopping Item -->
                            <div class=""shopping-item"">
                                <div class=""dropdown-cart-header"">
                                  ");
            WriteLiteral(@"  <span>2 Items</span>
                                    <a href=""#"">View Cart</a>
                                </div>
                                <ul class=""shopping-list"">
                                    <li>
                                        <a href=""#"" class=""remove"" title=""Remove this item""><i class=""fa fa-remove""></i></a>
                                        <a class=""cart-img"" href=""#""><img src=""https://via.placeholder.com/70x70"" alt=""#""></a>
                                        <h4><a href=""#"">Woman Ring</a></h4>
                                        <p class=""quantity"">1x - <span class=""amount"">$99.00</span></p>
                                    </li>
                                    <li>
                                        <a href=""#"" class=""remove"" title=""Remove this item""><i class=""fa fa-remove""></i></a>
                                        <a class=""cart-img"" href=""#""><img src=""https://via.placeholder.com/70x70"" alt=""#""></a>
                    ");
            WriteLiteral(@"                    <h4><a href=""#"">Woman Necklace</a></h4>
                                        <p class=""quantity"">1x - <span class=""amount"">$35.00</span></p>
                                    </li>
                                </ul>
                                <div class=""bottom"">
                                    <div class=""total"">
                                        <span>Total</span>
                                        <span class=""total-amount"">$134.00</span>
                                    </div>
                                    <a href=""checkout.html"" class=""btn animate"">Checkout</a>
                                </div>
                            </div>
                            <!--/ End Shopping Item -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Header Inner -->
    <div class=""header-inner"">
        <div class=""container"">
            <div class=""cat");
            WriteLiteral(@"-nav-head"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""menu-area"">
                            <!-- Main Menu -->
                            <nav class=""navbar navbar-expand-lg"">
                                <div class=""navbar-collapse"">
                                    <div class=""nav-inner"">
                                        <ul class=""nav main-menu menu navbar-nav"">
                                            <li class=""active""><a href=""#"">Home</a></li>
                                            <li><a href=""#"">Product</a></li>
                                            <li><a href=""#"">Service</a></li>
                                            <li>
                                                <a href=""#"">Shop<i class=""ti-angle-down""></i><span class=""new"">New</span></a>
                                                <ul class=""dropdown"">
                                                    <li><a href=""sho");
            WriteLiteral(@"p-grid.html"">Shop Grid</a></li>
                                                    <li><a href=""cart.html"">Cart</a></li>
                                                    <li><a href=""checkout.html"">Checkout</a></li>
                                                </ul>
                                            </li>
                                            <li><a href=""#"">Pages</a></li>
                                            <li>
                                                <a href=""#"">Blog<i class=""ti-angle-down""></i></a>
                                                <ul class=""dropdown"">
                                                    <li><a href=""blog-single-sidebar.html"">Blog Single Sidebar</a></li>
                                                </ul>
                                            </li>
                                            <li><a href=""contact.html"">Contact Us</a></li>
                                        </ul>
                                 ");
            WriteLiteral(@"   </div>
                                </div>
                            </nav>
                            <!--/ End Main Menu -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--/ End Header Inner -->
</header>");
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