#pragma checksum "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/part2/part2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abe60b17a1aae142e80d1352f8e801c9abe03e5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TMA3A.Pages.part2.Pages_part2_part2), @"mvc.1.0.razor-page", @"/Pages/part2/part2.cshtml")]
namespace TMA3A.Pages.part2
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe60b17a1aae142e80d1352f8e801c9abe03e5d", @"/Pages/part2/part2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55ae0f844cd201506e02a4b57ae98c5b1ba1562f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_part2_part2 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/part2/part2.cshtml"
  
    ViewData["Title"] = "Part 2";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""text-center"">
    <h1 class=""display-4"">Slideshow</h1>
</div>
<br />
<div class=""text-center"">
    <div>
        <input class='text-center' id=""startButton"" onclick=""changeBtnTxt('startButton'); runSlideshow();"" type=""button"" value=""Start"" />
    </div>
    <br />
    <div id=""slideshow_container"">
        <img id=""img_id""");
            BeginWriteAttribute("src", " src=\"", 401, "\"", 427, 1);
#nullable restore
#line 18 "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/part2/part2.cshtml"
WriteAttributeValue("", 407, ViewData["ImgLink"], 407, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n        <p id =\"caption_id\"class=\"display-8\">");
#nullable restore
#line 19 "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/part2/part2.cshtml"
                                        Write(ViewData["Caption"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>
    <br />
    <div>
        <input class='text-center' id=""bkwdOrderButton"" type=""button"" value=""Backward Order"" />
        <input class='text-center' id=""orderButton"" onclick=""changeBtnTxt('orderButton','bkwdOrderButton','fwdOrderButton')"" type=""button"" value=""Sequential"" />
        <input class='text-center' id=""fwdOrderButton"" type=""button"" value=""Forward Order"" />
    </div>
    <br />
    <br />
</div>

<script type=""text/javascript"">
    var picInterval;
    var currPicIndex = 0;
    var totalPics = 20;
    var bkwdOrFwd = 1;
    var tempIndex = 0;
    var startStopText = document.getElementById('startButton');
    var img_placeholder = document.getElementById('img_id');
    var cap_placeholder = document.getElementById('caption_id');
    var backwardOrder = document.getElementById(""bkwdOrderButton"");
    var forwardOrder = document.getElementById(""fwdOrderButton"");

        function runSlideshow() {

            var arr1 = ");
#nullable restore
#line 45 "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/part2/part2.cshtml"
                  Write(Html.Raw(Json.Serialize(Model.ImageArr)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n            var arr2 = ");
#nullable restore
#line 46 "/Users/A/Desktop/uni/Year 4/Fall/COMP 466/Assignment 3/TMA3A/TMA3A/Pages/part2/part2.cshtml"
                  Write(Html.Raw(Json.Serialize(Model.CaptionArr)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

            if (startStopText.value == ""Stop"") {

                img_placeholder.src = arr1[currPicIndex];
                cap_placeholder.innerHTML = arr2[currPicIndex];
                nextPic();
                picInterval = window.setInterval(function () {
                    img_placeholder.src = arr1[currPicIndex];
                    cap_placeholder.innerHTML = arr2[currPicIndex];
                   nextPic();
                }, 3000);
            }
            else {
                clearInterval(picInterval);
            }
        }

        function nextPic() {
            var orderText = document.getElementById('orderButton');
            if (orderText.value != ""Sequential"") {
                currPicIndex = Math.floor(Math.random() * totalPics);
            } else {
                currPicIndex = (currPicIndex + bkwdOrFwd) % totalPics;
                if (currPicIndex < 0) {
                    currPicIndex = totalPics - 1;
                }
            }
        }

        backwardOrder.addEve");
            WriteLiteral("ntListener(\"click\", function () {\n            bkwdOrFwd = -1;\n        }, false);\n        forwardOrder.addEventListener(\"click\", function () {\n            bkwdOrFwd = 1;\n        }, false);\n</script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Part2Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Part2Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Part2Model>)PageContext?.ViewData;
        public Part2Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591