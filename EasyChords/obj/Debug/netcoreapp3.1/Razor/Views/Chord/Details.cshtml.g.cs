#pragma checksum "C:\Users\Steven\source\repos\EasyChords\EasyChords\Views\Chord\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c8d375a563358c61886086e149716d237f82dbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chord_Details), @"mvc.1.0.view", @"/Views/Chord/Details.cshtml")]
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
#line 1 "C:\Users\Steven\source\repos\EasyChords\EasyChords\Views\_ViewImports.cshtml"
using EasyChords.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Steven\source\repos\EasyChords\EasyChords\Views\_ViewImports.cshtml"
using EasyChords.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c8d375a563358c61886086e149716d237f82dbf", @"/Views/Chord/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51dd4e3696798dc513ee1498c6b9def18bdffc1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Chord_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chord>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n        <h2>");
#nullable restore
#line 5 "C:\Users\Steven\source\repos\EasyChords\EasyChords\Views\Chord\Details.cshtml"
       Write(Model.ChordName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <div>\r\n            <img");
            BeginWriteAttribute("alt", " alt=\"", 119, "\"", 141, 1);
#nullable restore
#line 7 "C:\Users\Steven\source\repos\EasyChords\EasyChords\Views\Chord\Details.cshtml"
WriteAttributeValue("", 125, Model.ChordName, 125, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 142, "\"", 163, 1);
#nullable restore
#line 7 "C:\Users\Steven\source\repos\EasyChords\EasyChords\Views\Chord\Details.cshtml"
WriteAttributeValue("", 148, Model.ImageUrl, 148, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chord> Html { get; private set; }
    }
}
#pragma warning restore 1591
