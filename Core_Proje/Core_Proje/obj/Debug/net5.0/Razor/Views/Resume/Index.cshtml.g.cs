#pragma checksum "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Resume\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e421a99fd90911ad17ea6edcfebb862dfbc48b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resume_Index), @"mvc.1.0.view", @"/Views/Resume/Index.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Resume\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e421a99fd90911ad17ea6edcfebb862dfbc48b1", @"/Views/Resume/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Resume_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Resume>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Resume\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Experiences Table</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                    <tr>
                        <th>#</th>
                        <th>Name</th>
                        <th>Phone Number</th>
                        <th>Address</th>
                        <th>Mail</th>
                        <th>Delete</th>
                        <th>Update</th>
                    </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 26 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Resume\Index.cshtml"
                     foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Resume\Index.cshtml"
                           Write(item.ResumeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Resume\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Resume\Index.cshtml"
                           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Resume\Index.cshtml"
                           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Resume\Index.cshtml"
                           Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1196, "\"", 1238, 2);
            WriteAttributeValue("", 1203, "/Resume/DeleteResume/", 1203, 21, true);
#nullable restore
#line 33 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Resume\Index.cshtml"
WriteAttributeValue("", 1224, item.ResumeId, 1224, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1322, "\"", 1362, 2);
            WriteAttributeValue("", 1329, "/Resume/EditResume/", 1329, 19, true);
#nullable restore
#line 34 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Resume\Index.cshtml"
WriteAttributeValue("", 1348, item.ResumeId, 1348, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Update</a></td>\r\n                    \r\n                        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Resume\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n                \r\n            </div>\r\n            <a href=\"/Resume/AddResume/\" class=\"btn btn-outline-info\">Add New Resume</a>\r\n        </div>\r\n        \r\n    </div>\r\n    \r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Resume>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
