#pragma checksum "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e76bd3eaeb49623f5d07a8bfb84c0df068d6755"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_Details), @"mvc.1.0.view", @"/Views/Albums/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Albums/Details.cshtml", typeof(AspNetCore.Views_Albums_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e76bd3eaeb49623f5d07a8bfb84c0df068d6755", @"/Views/Albums/Details.cshtml")]
    public class Views_Albums_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProiectMDS.Models.Album>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Album</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(197, 40, false);
#line 14 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(237, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(281, 36, false);
#line 17 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(317, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(361, 47, false);
#line 20 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseYear));

#line default
#line hidden
            EndContext();
            BeginContext(408, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(452, 43, false);
#line 23 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseYear));

#line default
#line hidden
            EndContext();
            BeginContext(495, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(539, 42, false);
#line 26 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Studio));

#line default
#line hidden
            EndContext();
            BeginContext(581, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(625, 41, false);
#line 29 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Studio.Id));

#line default
#line hidden
            EndContext();
            BeginContext(666, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 733, "\"", 757, 1);
#line 34 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Details.cshtml"
WriteAttributeValue("", 748, Model.Id, 748, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(758, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProiectMDS.Models.Album> Html { get; private set; }
    }
}
#pragma warning restore 1591