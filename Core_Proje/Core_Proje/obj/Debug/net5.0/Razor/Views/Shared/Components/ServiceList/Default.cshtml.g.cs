#pragma checksum "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Shared\Components\ServiceList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67b717af8463470101b2a4ea656754ef54a60d3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ServiceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Shared\Components\ServiceList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67b717af8463470101b2a4ea656754ef54a60d3c", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ServiceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <section id=""services"" class=""services"">
      <div class=""container"">

        <div class=""section-title"">
          <h2>Services</h2>
            <p>I am happy that I provide you those service below. If you want to get those services, you can contact me on contact section :)</p>
        </div>

          <div class=""row"">
");
#nullable restore
#line 13 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Shared\Components\ServiceList\Default.cshtml"
               foreach (var item in Model)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <div class=\"col-lg-4 col-md-6 icon-box\" data-aos=\"fade-up\">\r\n                      <div class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 574, "\"", 598, 1);
#nullable restore
#line 16 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Shared\Components\ServiceList\Default.cshtml"
WriteAttributeValue("", 582, item.IconString, 582, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></div>\r\n                      <h4 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 654, "\"", 661, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Shared\Components\ServiceList\Default.cshtml"
                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                      <p class=\"description\">");
#nullable restore
#line 18 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Shared\Components\ServiceList\Default.cshtml"
                                        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n");
#nullable restore
#line 20 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Shared\Components\ServiceList\Default.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("              \r\n          </div>\r\n\r\n      </div>\r\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
