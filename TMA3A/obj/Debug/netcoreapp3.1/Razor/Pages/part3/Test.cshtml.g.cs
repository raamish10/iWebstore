#pragma checksum "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/part3/Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35f2dbda17c03d4093cd291057d606118b001e1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TMA3A.Pages.part3.Pages_part3_Test), @"mvc.1.0.razor-page", @"/Pages/part3/Test.cshtml")]
namespace TMA3A.Pages.part3
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
#line 1 "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/_ViewImports.cshtml"
using TMA3A;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35f2dbda17c03d4093cd291057d606118b001e1c", @"/Pages/part3/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55ae0f844cd201506e02a4b57ae98c5b1ba1562f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_part3_Test : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<p>dmmd</p>\n\n<p>Name ");
#nullable restore
#line 8 "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/part3/Test.cshtml"
   Write(ViewData["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Price ");
#nullable restore
#line 9 "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/part3/Test.cshtml"
    Write(ViewData["price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Image ");
#nullable restore
#line 10 "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/part3/Test.cshtml"
    Write(ViewData["image"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TMA3A.Pages.part3.TestModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TMA3A.Pages.part3.TestModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TMA3A.Pages.part3.TestModel>)PageContext?.ViewData;
        public TMA3A.Pages.part3.TestModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591