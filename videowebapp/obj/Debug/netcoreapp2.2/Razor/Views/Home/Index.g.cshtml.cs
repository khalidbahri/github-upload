#pragma checksum "C:\Users\khali\source\repos\videowebapp\videowebapp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2138923296f9fa16b82b9218692d3d58a5d218c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\khali\source\repos\videowebapp\videowebapp\Views\_ViewImports.cshtml"
using videowebapp;

#line default
#line hidden
#line 2 "C:\Users\khali\source\repos\videowebapp\videowebapp\Views\_ViewImports.cshtml"
using videowebapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2138923296f9fa16b82b9218692d3d58a5d218c9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af829b66f43f54162e5072de5e55ceb6fc896ffe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\khali\source\repos\videowebapp\videowebapp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 198, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n<div>\r\n");
            EndContext();
#line 10 "C:\Users\khali\source\repos\videowebapp\videowebapp\Views\Home\Index.cshtml"
     using (Html.BeginForm("Like", "Home"))
    {

#line default
#line hidden
            BeginContext(295, 59, true);
            WriteLiteral("        <input type=\"submit\" value=\"Like\" />\r\n        <div>");
            EndContext();
            BeginContext(355, 15, false);
#line 13 "C:\Users\khali\source\repos\videowebapp\videowebapp\Views\Home\Index.cshtml"
        Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(370, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 14 "C:\Users\khali\source\repos\videowebapp\videowebapp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(385, 6, true);
            WriteLiteral("</div>");
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
