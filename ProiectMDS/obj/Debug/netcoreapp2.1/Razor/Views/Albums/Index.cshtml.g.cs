#pragma checksum "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5a6c153762ecee745bc59ca80cfdf2827577650"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_Index), @"mvc.1.0.view", @"/Views/Albums/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Albums/Index.cshtml", typeof(AspNetCore.Views_Albums_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5a6c153762ecee745bc59ca80cfdf2827577650", @"/Views/Albums/Index.cshtml")]
    public class Views_Albums_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProiectMDS.Models.Album>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(247, 40, false);
#line 16 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(287, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(343, 47, false);
#line 19 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReleaseYear));

#line default
#line hidden
            EndContext();
            BeginContext(390, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(446, 42, false);
#line 22 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Studio));

#line default
#line hidden
            EndContext();
            BeginContext(488, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(606, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(655, 39, false);
#line 31 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(694, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(750, 46, false);
#line 34 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReleaseYear));

#line default
#line hidden
            EndContext();
            BeginContext(796, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(852, 44, false);
#line 37 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Studio.Id));

#line default
#line hidden
            EndContext();
            BeginContext(896, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 971, "\"", 994, 1);
#line 40 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml"
WriteAttributeValue("", 986, item.Id, 986, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(995, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1047, "\"", 1070, 1);
#line 41 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml"
WriteAttributeValue("", 1062, item.Id, 1062, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1071, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1125, "\"", 1148, 1);
#line 42 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml"
WriteAttributeValue("", 1140, item.Id, 1140, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1149, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1199, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProiectMDS.Models.Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591
