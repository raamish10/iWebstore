#pragma checksum "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/tma3a.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aa9d38052bb01c4a762f218d75e3ac73287b334"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TMA3A.Pages.Pages_tma3a), @"mvc.1.0.razor-page", @"/Pages/tma3a.cshtml")]
namespace TMA3A.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aa9d38052bb01c4a762f218d75e3ac73287b334", @"/Pages/tma3a.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55ae0f844cd201506e02a4b57ae98c5b1ba1562f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_tma3a : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/tma3a.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <br />
    <br />
    <h1 class=""display-4"">Welcome</h1>
    <br />
    <br />
    <p>Part 1: Cookie Tracker</p>
    <p>Part 2: Slideshow</p>
    <p>Part 3: iWebstore (beta)</p>
    <p>Part 4: iWebstore (2.0)</p>
    <br />
    <div class=""boxed"">
        <a>Database features might not work due to the lack of a SQL server</a>
    </div>
    <br />

</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591