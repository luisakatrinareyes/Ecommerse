#pragma checksum "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "988bf9ffba6882f9cb2da0be0fb9a76e40371d0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Product), @"mvc.1.0.view", @"/Views/Products/Product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"988bf9ffba6882f9cb2da0be0fb9a76e40371d0c", @"/Views/Products/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d3b2d51cbf0506c85132cc12a1aa7e62114768c", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LuisaKatrinaReyes.Ecommerse.Web.ViewModels.Products.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Product.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>");
#nullable restore
#line 4 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Product.cshtml"
Write(Model.TagLine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>");
#nullable restore
#line 5 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Product.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h2>");
#nullable restore
#line 6 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Product.cshtml"
Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LuisaKatrinaReyes.Ecommerse.Web.ViewModels.Products.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591