#pragma checksum "/Users/josiahmcpeak/Desktop/CSharpDojo/ViewModelFUN/Views/Home/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6378deedcb486bcc8d238e836f586cfba91b21f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "/Users/josiahmcpeak/Desktop/CSharpDojo/ViewModelFUN/Views/_ViewImports.cshtml"
using ViewModelFUN;

#line default
#line hidden
#line 2 "/Users/josiahmcpeak/Desktop/CSharpDojo/ViewModelFUN/Views/_ViewImports.cshtml"
using ViewModelFUN.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6378deedcb486bcc8d238e836f586cfba91b21f4", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d39ee2d14ef9be3baaafad5b2b2cc361dea40ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 46, true);
            WriteLiteral("\r\n<h3>HEllow WorLD</h3>\r\n\r\n<h3>YOOOOO</h3>\r\n\r\n");
            EndContext();
#line 7 "/Users/josiahmcpeak/Desktop/CSharpDojo/ViewModelFUN/Views/Home/About.cshtml"
 foreach (var num in Model){

#line default
#line hidden
            BeginContext(90, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(98, 3, false);
#line 8 "/Users/josiahmcpeak/Desktop/CSharpDojo/ViewModelFUN/Views/Home/About.cshtml"
  Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(101, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 9 "/Users/josiahmcpeak/Desktop/CSharpDojo/ViewModelFUN/Views/Home/About.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
