#pragma checksum "/Users/wernergriesel/Projects/brandflex/Views/Home/thank-you.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ff5663c7b85a80fd2c4613ec519a3fbd3808e9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_thank_you), @"mvc.1.0.view", @"/Views/Home/thank-you.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/thank-you.cshtml", typeof(AspNetCore.Views_Home_thank_you))]
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
#line 1 "/Users/wernergriesel/Projects/brandflex/Views/_ViewImports.cshtml"
using brandflex;

#line default
#line hidden
#line 2 "/Users/wernergriesel/Projects/brandflex/Views/_ViewImports.cshtml"
using brandflex.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff5663c7b85a80fd2c4613ec519a3fbd3808e9c", @"/Views/Home/thank-you.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abeea347608f8ad7369b90809659786603c9a850", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_thank_you : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/wernergriesel/Projects/brandflex/Views/Home/thank-you.cshtml"
  
    ViewData["Title"] = "Thank You";
    ViewBag.MetaDescription = "Home Page Description";

#line default
#line hidden
            BeginContext(101, 180, true);
            WriteLiteral("\r\n<section class=\"section\">\r\n\t<div class=\"container-fluid\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-12 text-center\">\r\n\t\t\t\t<div class=\"h1\">🙏</div>\r\n\t\t\t\t<h1 class=\"display-1 mt-4\">");
            EndContext();
            BeginContext(282, 17, false);
#line 11 "/Users/wernergriesel/Projects/brandflex/Views/Home/thank-you.cshtml"
                                      Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(299, 54, true);
            WriteLiteral(".</h1>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(371, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(378, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Modals", async() => {
                BeginContext(397, 5, true);
                WriteLiteral("\r\n\t\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
