#pragma checksum "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4183e325126905d31741085e345ee48a8c1440f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\_ViewImports.cshtml"
using FiorelloFrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\_ViewImports.cshtml"
using FiorelloFrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4183e325126905d31741085e345ee48a8c1440f1", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6947c1ce694fa0ad05958ff03fd3e7684bd80f46", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- PRODUCTS START -->

<section id=""products"">
    <div class=""container"">
        <div class=""row pt-5"">
            <div class=""col-12 d-flex justify-content-between"">
                <ul class=""category-mobile d-md-none list-unstyled"">
                    <li>
                        <a");
            BeginWriteAttribute("href", " href=\"", 368, "\"", 375, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                        <i class=\"fas fa-caret-down\"></i>\r\n                        <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 594, "\"", 601, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
                             foreach (Categories categories in Model.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 784, "\"", 791, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 21 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
                                                   Write(categories.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 21 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
                                                                               Write(categories.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 22 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                    </li>\r\n                </ul>\r\n                <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1067, "\"", 1074, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 29 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
                     foreach (Categories categories in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1231, "\"", 1238, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 31 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
                                           Write(categories.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 31 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
                                                                       Write(categories.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 32 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <ul class=\"list-unstyled\">\r\n                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1446, "\"", 1453, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                        <i class=\"fas fa-caret-down\"></i>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\" id=\"proList\">\r\n           ");
#nullable restore
#line 43 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
      Write(await Component.InvokeAsync("Product", 8));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        </div>\r\n        <div class=\"row my-5 justify-content-center\">\r\n            <input type=\"hidden\" id=\"count\"");
            BeginWriteAttribute("value", " value=\"", 1835, "\"", 1864, 1);
#nullable restore
#line 46 "C:\Users\maham\OneDrive\Desktop\Code Academy\Asp.net\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
WriteAttributeValue("", 1843, ViewBag.ProductCount, 1843, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <div id=""loader"" class=""d-none"">
                <button class=""btn btn-info btn-lg"" id=""loadingBtn"" type=""button"" disabled>
                    <span class=""spinner-border spinner-border-sm"" role=""status"" aria-hidden=""true""></span>
                    Loading...
                </button>
            </div>
            <button class=""btn btn-success btn-lg"" id=""loadMore"">Load More...</button>
        </div>
    </div>
</section>

<!-- PRODUCTS END -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
