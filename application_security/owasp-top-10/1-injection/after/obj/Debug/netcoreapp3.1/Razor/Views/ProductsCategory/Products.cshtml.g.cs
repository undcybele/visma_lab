#pragma checksum "D:\Desktop\Visma LAB\visma-lab-github\visma_lab\application_security\owasp-top-10\1-injection\after\Views\ProductsCategory\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46259d5bb82f67c457e4e21316c82fe42f106fcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductsCategory_Products), @"mvc.1.0.view", @"/Views/ProductsCategory/Products.cshtml")]
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
#line 1 "D:\Desktop\Visma LAB\visma-lab-github\visma_lab\application_security\owasp-top-10\1-injection\after\Views\_ViewImports.cshtml"
using Injection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\Visma LAB\visma-lab-github\visma_lab\application_security\owasp-top-10\1-injection\after\Views\_ViewImports.cshtml"
using Injection.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46259d5bb82f67c457e4e21316c82fe42f106fcb", @"/Views/ProductsCategory/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4fb4714069c132c249365953876dba7259c9ec4", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductsCategory_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Injection.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Desktop\Visma LAB\visma-lab-github\visma_lab\application_security\owasp-top-10\1-injection\after\Views\ProductsCategory\Products.cshtml"
  
    ViewData["Title"] = "Products Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List of products</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\Desktop\Visma LAB\visma-lab-github\visma_lab\application_security\owasp-top-10\1-injection\after\Views\ProductsCategory\Products.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Desktop\Visma LAB\visma-lab-github\visma_lab\application_security\owasp-top-10\1-injection\after\Views\ProductsCategory\Products.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Desktop\Visma LAB\visma-lab-github\visma_lab\application_security\owasp-top-10\1-injection\after\Views\ProductsCategory\Products.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "D:\Desktop\Visma LAB\visma-lab-github\visma_lab\application_security\owasp-top-10\1-injection\after\Views\ProductsCategory\Products.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "D:\Desktop\Visma LAB\visma-lab-github\visma_lab\application_security\owasp-top-10\1-injection\after\Views\ProductsCategory\Products.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\Desktop\Visma LAB\visma-lab-github\visma_lab\application_security\owasp-top-10\1-injection\after\Views\ProductsCategory\Products.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\Desktop\Visma LAB\visma-lab-github\visma_lab\application_security\owasp-top-10\1-injection\after\Views\ProductsCategory\Products.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "D:\Desktop\Visma LAB\visma-lab-github\visma_lab\application_security\owasp-top-10\1-injection\after\Views\ProductsCategory\Products.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Injection.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
