#pragma checksum "/Users/mesayeaddisu/Desktop/fsdi107/myCalander/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebbc34a7ad01cd28b7a9f8422f8b137995418054"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/mesayeaddisu/Desktop/fsdi107/myCalander/Views/_ViewImports.cshtml"
using myCalander;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mesayeaddisu/Desktop/fsdi107/myCalander/Views/_ViewImports.cshtml"
using myCalander.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbc34a7ad01cd28b7a9f8422f8b137995418054", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f450d5034bf018a84a01adda9efca11ebab2f16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/mesayeaddisu/Desktop/fsdi107/myCalander/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n<link href=\"/css/todo/css\" rel=\"Stylesheet\">\r\n<link href=\"/lib/fontawesome-free-5.14.0-web/css/all\" rel=\"styelesheet\">\r\n");
            }
            );
            WriteLiteral(@"<div class=""parent-container"">
    <div class=""side"">Menu</div>

    <div class=""content"">
        <h4>My Tasks</h4>

        <div id=""tasks"" c;ass=""section-tasks"">

        </div>
       </div>
    <div class=""details"">Create New</div>

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/js/calander.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
