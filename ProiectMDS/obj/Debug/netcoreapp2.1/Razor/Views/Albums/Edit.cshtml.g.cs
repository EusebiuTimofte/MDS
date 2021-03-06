#pragma checksum "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e47dd973af7e2b487bd6225669763527ead1b4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_Edit), @"mvc.1.0.view", @"/Views/Albums/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Albums/Edit.cshtml", typeof(AspNetCore.Views_Albums_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e47dd973af7e2b487bd6225669763527ead1b4e", @"/Views/Albums/Edit.cshtml")]
    public class Views_Albums_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProiectMDS.Models.Album>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(74, 1364, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Album</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ReleaseYear"" class=""control-label""></label>
                <input asp-for=""ReleaseYear"" class=""form-control"" />
                <span asp-validation-for=""ReleaseYear"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""StudioId"" class=""control-label""></label>
                <select asp-for=""StudioId"" class=""form-control"" asp-items=""ViewBag.StudioId""></select");
            WriteLiteral(@">
                <span asp-validation-for=""StudioId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1456, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "C:\Users\Euseb\Documents\ProiectMDS\ProiectMDS\Views\Albums\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
