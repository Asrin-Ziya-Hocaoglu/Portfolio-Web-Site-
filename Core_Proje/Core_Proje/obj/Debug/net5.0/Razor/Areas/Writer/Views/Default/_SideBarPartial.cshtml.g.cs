#pragma checksum "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Areas\Writer\Views\Default\_SideBarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5a8d1129fcb336650cec2b75372c668c2b62a04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default__SideBarPartial), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/_SideBarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a8d1129fcb336650cec2b75372c668c2b62a04", @"/Areas/Writer/Views/Default/_SideBarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default__SideBarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
    <ul class=""nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/DashboardWriter/Index/"">
                <i class=""icon-grid menu-icon""></i>
                <span class=""menu-title"">Dashboard</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""collapse"" href=""#messages""  aria-expanded=""false"" aria-controls=""messages"">
            
                <i class=""mdi mdi-message menu-icon""></i>
                <span class=""menu-title"">Messages</span>
                <i class=""menu-arrow""></i>
            </a>
            <div class=""collapse"" id=""messages"">
                <ul class=""nav flex-column sub-menu"">
                    <li class=""nav-item""><a class=""nav-link"" href=""/Writer/Message/ReceiverMessage/"">Inbox Messages</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""/Writer/Message/SenderMessage/"">Outgoing Messages</a></l");
            WriteLiteral(@"i>
                    <li class=""nav-item""><a class=""nav-link"" href=""/Writer/Message/SendMessage/"">New Message</a></li>
                </ul>
            </div>
        </li>

        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Default/Index/"">
                <i class=""icon-grid-2 menu-icon""></i>
                <span class=""menu-title"">Announcements</span>
             
            </a>
           
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Profile/Index/"">
                <i class=""mdi mdi-face-profile menu-icon""></i>
                <span class=""menu-title"">Profile</span>
            </a>
            
        </li>

        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Profile/Index/"">
                <i class=""mdi mdi-settings menu-icon""></i>
                <span class=""menu-title"">Settings</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav");
            WriteLiteral("-link\" href=\"/Writer/Login/Logout/\">\r\n                <i class=\"mdi mdi-login menu-icon\"></i>\r\n                <span class=\"menu-title\">Logout</span>\r\n            </a>\r\n        </li>\r\n    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
