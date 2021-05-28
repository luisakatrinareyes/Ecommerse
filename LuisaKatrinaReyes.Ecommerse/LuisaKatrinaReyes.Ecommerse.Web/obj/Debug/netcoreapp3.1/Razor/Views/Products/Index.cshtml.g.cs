#pragma checksum "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86a857e2fcdee0539bb3799aa6eb9ebf3318d3db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a857e2fcdee0539bb3799aa6eb9ebf3318d3db", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d3b2d51cbf0506c85132cc12a1aa7e62114768c", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LuisaKatrinaReyes.Ecommerse.Web.ViewModels.Products.ProductSearchViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Products</h1>\r\n\r\n<div>\r\n    <span>Search</span>\r\n    <input type=\"text\" placeholder=\"keyword\" id=\"keyword\" />\r\n</div>\r\n\r\n");
#nullable restore
#line 10 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
  
    if (Model.Products != null)
    {
        if (Model.Products.Items != null)
        {
            if (Model.Products.Items.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table>
                    <thead>
                        <tr>
                            <td>Name</td>
                            <td>TagLine</td>
                            <td>Price</td>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 26 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
                          
                            foreach (var product in Model.Products.Items)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 30 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
                                   Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 31 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
                                   Write(product.TagLine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 32 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
                                   Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 34 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
            WriteLiteral("                <button id=\"next\">Next</button>\r\n");
#nullable restore
#line 40 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Your search returned no results.</span>\r\n");
#nullable restore
#line 44 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>Your search returned no results.</span>\r\n");
#nullable restore
#line 49 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Your search returned no results.</span>\r\n");
#nullable restore
#line 54 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var pageIndex = ");
#nullable restore
#line 59 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
                    Write(Model.Products.Items != null ? Model.Products.PageIndex : 1);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        var pageSize = ");
#nullable restore
#line 60 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
                   Write(Model.Products.Items != null ? Model.Products.PageSize : 10);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        var pageCount = ");
#nullable restore
#line 61 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
                    Write(Model.Products.Items != null ? Model.Products.PageCount : 0);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        var keyword = \"");
#nullable restore
#line 62 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
                   Write(Model.Products.Items != null ? Model.Products.Keyword : "");

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        var baseUrl = location.protocol + \'//\' + location.host + location.pathname;\r\n        var filterStr = \"");
#nullable restore
#line 64 "F:\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Views\Products\Index.cshtml"
                     Write(!string.IsNullOrEmpty(Model.Products.FilterString) ? Model.Products.FilterString : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";

    function search() {
        window.location = baseUrl + ""?keyword="" + keyword + ""&pageSize="" + pageSize + ""&pageIndex="" + pageIndex + filterStr;
    }

    $(""#keyword"").blur(function () {
        keyword = $(""#keyword"").val();
        if (filterStr) {
            filterStr = ""&"" + filterStr;
        }
        search();
    });

    $(""#keyword"").on('keypress', function (e) {
        if (e.which == 13) {
            keyword = $(""#keyword"").val();
            if (filterStr) {
                filterStr = ""&"" + filterStr;
            }
            search();
        }
    });

    $(""#next"").click(function () {
        pageIndex = pageIndex + 1;
        search();
    });

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LuisaKatrinaReyes.Ecommerse.Web.ViewModels.Products.ProductSearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591