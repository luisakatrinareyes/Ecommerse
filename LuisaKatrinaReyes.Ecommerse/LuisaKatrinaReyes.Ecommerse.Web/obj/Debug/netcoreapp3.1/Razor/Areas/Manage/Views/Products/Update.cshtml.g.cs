#pragma checksum "C:\Users\admin\source\repos\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Areas\Manage\Views\Products\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d58ef71c28262c22f28ad8297e705a35c999c904"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Products_Update), @"mvc.1.0.view", @"/Areas/Manage/Views/Products/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d58ef71c28262c22f28ad8297e705a35c999c904", @"/Areas/Manage/Views/Products/Update.cshtml")]
    public class Areas_Manage_Views_Products_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/products"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;color:#ffffff;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\admin\source\repos\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Areas\Manage\Views\Products\Update.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section id=""contact-us"" class=""contact-us section"">
    <div class=""container"">
        <div class=""contact-head"">
            <div class=""row"">
                <div class=""col-lg-8 col-12"">
                    <div class=""form-main"">
                        <div class=""title"">
                            <h4>Update product</h4>
                            <h3>Update product information</h3>
                        </div>
                        <form class=""form"" action=""/manage/products/update"" method=""post"">
                            <div class=""row"">
                                <div class=""col-lg-6 col-12"">
                                    <div class=""form-group"">
                                        <label>Product Name");
            WriteLiteral("</label>\r\n                                        <input name=\"Name\" type=\"text\" id=\"name\" asp-for=\"Name\" placeholder=\"Enter product name\"");
            BeginWriteAttribute("value", " value=\"", 974, "\"", 993, 1);
#nullable restore
#line 21 "C:\Users\admin\source\repos\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Areas\Manage\Views\Products\Update.cshtml"
WriteAttributeValue("", 982, Model.Name, 982, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n                                <input type=\"hidden\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 1143, "\"", 1160, 1);
#nullable restore
#line 24 "C:\Users\admin\source\repos\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Areas\Manage\Views\Products\Update.cshtml"
WriteAttributeValue("", 1151, Model.Id, 1151, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                <div class=""col-lg-6 col-12"">
                                    <div class=""form-group"">
                                        <label>Tag line</label>
                                        <input type=""text"" class=""form-control"" id=""tagLine"" asp-for=""TagLine"" name=""TagLine"" placeholder=""Enter product brief description""");
            BeginWriteAttribute("value", " value=\"", 1527, "\"", 1549, 1);
#nullable restore
#line 28 "C:\Users\admin\source\repos\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Areas\Manage\Views\Products\Update.cshtml"
WriteAttributeValue("", 1535, Model.TagLine, 1535, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-12"">
                                    <div class=""form-group message"">
                                        <label>Description</label>
                                        <textarea asp-for=""Description"" class=""form-control"" id=""description"" name=""Description"" placeholder=""Enter product full description""> ");
#nullable restore
#line 34 "C:\Users\admin\source\repos\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Areas\Manage\Views\Products\Update.cshtml"
                                                                                                                                                                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </textarea>
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-12"">
                                    <div class=""form-group"">
                                        <label>Price</label>
                                        <input type=""number"" class=""form-control"" id=""price"" asp-for=""Price"" name=""Price"" placeholder=""Enter product price""");
            BeginWriteAttribute("value", " value=\"", 2512, "\"", 2550, 1);
#nullable restore
#line 41 "C:\Users\admin\source\repos\Ecommerse\LuisaKatrinaReyes.Ecommerse\LuisaKatrinaReyes.Ecommerse.Web\Areas\Manage\Views\Products\Update.cshtml"
WriteAttributeValue("", 2520, Model.Price.ToString("##.00"), 2520, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""col-12"">
                                    <div class=""form-group button"">
                                        <button type=""submit"" class=""btn"">Submit</button>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d58ef71c28262c22f28ad8297e705a35c999c9049037", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                        </form>
                    </div>
                </div>
                <div class=""col-lg-4 col-12"">
                    <div class=""single-head"">
                        <div class=""single-info"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
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
