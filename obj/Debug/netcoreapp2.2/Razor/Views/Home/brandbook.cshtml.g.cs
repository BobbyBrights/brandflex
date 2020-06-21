#pragma checksum "/Users/wernergriesel/Projects/brandflex/Views/Home/brandbook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ea24b82643cc94d4e1e1923fce4817e25f41b5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_brandbook), @"mvc.1.0.view", @"/Views/Home/brandbook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/brandbook.cshtml", typeof(AspNetCore.Views_Home_brandbook))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea24b82643cc94d4e1e1923fce4817e25f41b5e", @"/Views/Home/brandbook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abeea347608f8ad7369b90809659786603c9a850", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_brandbook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "SubscribeBrandbook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/wernergriesel/Projects/brandflex/Views/Home/brandbook.cshtml"
  
    ViewData["Title"] = "Brandbook";
    ViewBag.MetaDescription = "Get started with Brandflex Brandbook, a comprehensive framework for building a unique brand from scratch.";

#line default
#line hidden
            BeginContext(185, 180, true);
            WriteLiteral("\r\n<section class=\"section\">\r\n\t<div class=\"container-fluid\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-12 text-center\">\r\n\t\t\t\t<div class=\"h1\">📓</div>\r\n\t\t\t\t<h1 class=\"display-1 mt-4\">");
            EndContext();
            BeginContext(366, 17, false);
#line 11 "/Users/wernergriesel/Projects/brandflex/Views/Home/brandbook.cshtml"
                                      Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(383, 302, true);
            WriteLiteral(@".</h1>
			</div>
		</div>
	</div>
</section>

<section class=""section pt-0"">
	<div class=""container-fluid"">
		<div class=""row"">
			<div class=""col-md-8 mx-auto"">
				<div class=""box box-ii bg-black text-white"">
					<div class=""left"">
						<h2>Get the Branflex Brandbook</h2>
						<p><b>");
            EndContext();
            BeginContext(686, 23, false);
#line 24 "/Users/wernergriesel/Projects/brandflex/Views/Home/brandbook.cshtml"
                         Write(ViewBag.MetaDescription);

#line default
#line hidden
            EndContext();
            BeginContext(709, 16, true);
            WriteLiteral("</b></p>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(725, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ea24b82643cc94d4e1e1923fce4817e25f41b5e4914", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(762, 410, true);
            WriteLiteral(@"
					</div>
					<div class=""right""></div>
				</div>
				<p><small>We use Mailchimp as our marketing platform. By clicking to download, you acknowledge that your information will be transferred to Mailchimp for processing. <a href=""https://mailchimp.com/legal/"" target=""_blank"">Learn more</a> about Mailchimp's privacy practices here.</small></p>
			</div>
		</div>
	</div>
</section>







");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1190, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(1197, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Modals", async() => {
                BeginContext(1216, 5, true);
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
