#pragma checksum "D:\source\Infes\Infes\Views\Human\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "406d11f4d837c26885ec60e20bd11f47342cdf3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Human_Index), @"mvc.1.0.view", @"/Views/Human/Index.cshtml")]
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
#line 1 "D:\source\Infes\Infes\Views\_ViewImports.cshtml"
using Infes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\source\Infes\Infes\Views\_ViewImports.cshtml"
using Infes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"406d11f4d837c26885ec60e20bd11f47342cdf3f", @"/Views/Human/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12fe7b1be6e9a2c8438c7459cb7aea0aa607d19e", @"/Views/_ViewImports.cshtml")]
    public class Views_Human_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table\" style=\"text-align: center\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>FirstName</th>\r\n        <th>LastName</th>\r\n        <th>Age</th>\r\n        <th>IsSick</th>\r\n        <th>Gender</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "D:\source\Infes\Infes\Views\Human\Index.cshtml"
     foreach (var human in ViewData["Humans"] as List<Human>)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "D:\source\Infes\Infes\Views\Human\Index.cshtml"
           Write(human.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "D:\source\Infes\Infes\Views\Human\Index.cshtml"
           Write(human.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "D:\source\Infes\Infes\Views\Human\Index.cshtml"
           Write(human.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "D:\source\Infes\Infes\Views\Human\Index.cshtml"
           Write(human.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "D:\source\Infes\Infes\Views\Human\Index.cshtml"
           Write(human.IsSick);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\source\Infes\Infes\Views\Human\Index.cshtml"
           Write(human.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "D:\source\Infes\Infes\Views\Human\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
