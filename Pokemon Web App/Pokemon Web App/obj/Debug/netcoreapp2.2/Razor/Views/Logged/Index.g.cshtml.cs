#pragma checksum "D:\PROIECTE\ROBI MODOSITOTT\Pokemon Web App\Pokemon Web App\Views\Logged\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d9421174552d3f99dcd41beecbf4608028bb496"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logged_Index), @"mvc.1.0.view", @"/Views/Logged/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Logged/Index.cshtml", typeof(AspNetCore.Views_Logged_Index))]
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
#line 1 "D:\PROIECTE\ROBI MODOSITOTT\Pokemon Web App\Pokemon Web App\Views\_ViewImports.cshtml"
using Pokemon_Web_App;

#line default
#line hidden
#line 2 "D:\PROIECTE\ROBI MODOSITOTT\Pokemon Web App\Pokemon Web App\Views\_ViewImports.cshtml"
using Pokemon_Web_App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d9421174552d3f99dcd41beecbf4608028bb496", @"/Views/Logged/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb5475b88ffb0639ab5d6d597bc20a3e82fa5d33", @"/Views/_ViewImports.cshtml")]
    public class Views_Logged_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\PROIECTE\ROBI MODOSITOTT\Pokemon Web App\Pokemon Web App\Views\Logged\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_LoggedLayout";

#line default
#line hidden
            BeginContext(74, 220, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h2 class=\"display-4\">Pokemon of the Week</h2>\r\n    <img src=\"https://i.dlpng.com/static/png/72594_preview.png\" width=\"400\" height=\"450\" />\r\n    <h3 class=\"display-4\">Pikachu</h3>\r\n</div>\r\n");
            EndContext();
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