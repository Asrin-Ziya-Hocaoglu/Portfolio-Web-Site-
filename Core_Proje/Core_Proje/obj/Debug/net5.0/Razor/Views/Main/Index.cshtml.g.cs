#pragma checksum "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c74896fdb87e3fad555ca25cc1b4dfafe9696c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Index), @"mvc.1.0.view", @"/Views/Main/Index.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c74896fdb87e3fad555ca25cc1b4dfafe9696c37", @"/Views/Main/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Home>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Main\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Home Update</h3>\r\n</div>\r\n");
#nullable restore
#line 10 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Main\Index.cshtml"
 using (Html.BeginForm("Index", "Main", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Main\Index.cshtml"
Write(Html.HiddenFor(x=>x.HomeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Name</label>\r\n");
#nullable restore
#line 15 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Main\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Name, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Title</label>\r\n");
#nullable restore
#line 18 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Main\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Title, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Image Url</label>\r\n");
#nullable restore
#line 21 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Main\Index.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n    <button  class=\"btn btn-success\">Submit</button>\r\n");
#nullable restore
#line 24 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Main\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Home> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
