#pragma checksum "/Users/josiahmcpeak/Desktop/CSharpDojo/Dur/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ede28c8e3c5fd3e6aad8a00ae966fbe29b3f05b2"
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
#line 1 "/Users/josiahmcpeak/Desktop/CSharpDojo/Dur/Views/_ViewImports.cshtml"
using Dur;

#line default
#line hidden
#line 2 "/Users/josiahmcpeak/Desktop/CSharpDojo/Dur/Views/_ViewImports.cshtml"
using Dur.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ede28c8e3c5fd3e6aad8a00ae966fbe29b3f05b2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9f1dbf2c52cd0dd076bbebae985a100db2294a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/josiahmcpeak/Desktop/CSharpDojo/Dur/Views/Home/Index.cshtml"
   string[] Potato = {"chad is learning to make strings!", "Jerome is commenting alot", "Robert is a hacker king" }; foreach
(var OtherPotatos in Potato){

#line default
#line hidden
            BeginContext(157, 13, true);
            WriteLiteral("<h3>\r\n    <p>");
            EndContext();
            BeginContext(171, 12, false);
#line 4 "/Users/josiahmcpeak/Desktop/CSharpDojo/Dur/Views/Home/Index.cshtml"
  Write(OtherPotatos);

#line default
#line hidden
            EndContext();
            BeginContext(183, 13, true);
            WriteLiteral("</p>\r\n</h3>\r\n");
            EndContext();
#line 6 "/Users/josiahmcpeak/Desktop/CSharpDojo/Dur/Views/Home/Index.cshtml"

DateTime CurrentTime = DateTime.Now; } 

#line default
#line hidden
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
