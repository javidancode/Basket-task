#pragma checksum "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9921f30adc9c6111dd864121598b29888093948c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\_ViewImports.cshtml"
using Entity_Frame_Work_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\_ViewImports.cshtml"
using Entity_Frame_Work_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\_ViewImports.cshtml"
using Entity_Frame_Work_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9921f30adc9c6111dd864121598b29888093948c", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e54a638111d37f88a21eeaacedc428661bd2dbbb", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketDetailVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Index";
    decimal endTotal = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h3 class=""my-3 mb-2"">Products</h3>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Image</th>
                <th scope=""col"">Title</th>
                <th scope=""col"">Count</th>
                <th scope=""col"">Price</th>
                <th scope=""col"">Total price</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\Basket\Index.cshtml"
             foreach (var basket in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9921f30adc9c6111dd864121598b29888093948c5530", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 670, "~/img/", 670, 6, true);
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\Basket\Index.cshtml"
AddHtmlAttributeValue("", 676, basket.Image, 676, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </th>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\Basket\Index.cshtml"
               Write(basket.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\Basket\Index.cshtml"
               Write(basket.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\Basket\Index.cshtml"
               Write(basket.Price.ToString("#####"));

#line default
#line hidden
#nullable disable
            WriteLiteral("₼</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\Basket\Index.cshtml"
               Write(basket.Total.ToString("#####"));

#line default
#line hidden
#nullable disable
            WriteLiteral("₼</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\Basket\Index.cshtml"
                endTotal += basket.Total;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h2>Total Price: ");
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\Programming\Asp.net\Session, Cookie, Basket\Session, Cookie, Basket\Session, Cookie, Basket\Entity-Frame-Work-Project\Views\Basket\Index.cshtml"
                    Write(endTotal.ToString("#####"));

#line default
#line hidden
#nullable disable
            WriteLiteral("₼</h2>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketDetailVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
