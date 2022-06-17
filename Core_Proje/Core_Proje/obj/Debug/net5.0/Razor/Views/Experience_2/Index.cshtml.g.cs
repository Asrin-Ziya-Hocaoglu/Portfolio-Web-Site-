#pragma checksum "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Experience_2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "844101f82b9159f2e54526d9cdaa169b47d35da4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_2_Index), @"mvc.1.0.view", @"/Views/Experience_2/Index.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Experience_2\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844101f82b9159f2e54526d9cdaa169b47d35da4", @"/Views/Experience_2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience_2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\pc\Desktop\Yazılım\WebProgramming\MVC_\Core_Proje\Core_Proje\Views\Experience_2\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-6"">
    <div class=""p-2"">
        <button type=""button"" id=""btngetlistall"" class=""btn btn-outline-primary"">Get List</button>
        <button type=""button"" id=""btnadd"" class=""btn btn-outline-info"">Save</button>
        <button type=""button"" id=""btnid"" class=""btn btn-outline-warning"">Get By Id</button>
        <button type=""button"" id=""btndelete"" class=""btn btn-outline-danger"">Delete</button>
        <button type=""button"" id=""btnupdate"" class=""btn btn-outline-success"">Update</button>
    </div>
</div>

<h4 class=""text-center"">Experiences</h4>
<div class=""p-2"" id=""listexperience"">
  
</div>

<br/>
<div class=""p-2"" id=""listbyidexperience"">
  
</div>
<br/>

<div class=""col-md-12"">
    <h4>Add Panel</h4>
    <input type=""text"" class=""form-control"" id=""inputName"" placeholder=""Name""/>
    <br/>
    <input type=""text"" class=""form-control"" id=""inputDate"" placeholder=""Date""/>

</div>
<br />
<div class=""col-md-12"">
    <h5>Get By Id</h5>
    <input type=""text"" class=""fo");
            WriteLiteral("rm-control\" id=\"inputId\" placeholder=\"Id\"/>\r\n    <br/>\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <h5>Delete</h5>\r\n    <input type=\"text\" class=\"form-control\" id=\"inputDeleteId\" placeholder=\"Id\"/>\r\n    <br/>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#btngetlistall"").click(function() {
            $.ajax({
                contentType: ""Application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Experience_2/ListExperience/"",

                success: function(func) {
                    let values = jQuery.parseJSON(func);
                    console.log(values);

                    let htmlstring = ""<table class=table table-bordered> <tr> <th> ID </th> <th>Name</th> <th>Date</th> </tr>"";
                    $.each(values,
                        (index, value) => {
                            htmlstring += `<tr> <td>${value.ExperienceId}</td> <td> ${value.Name}</td> <td> ${value.Date}</td> </tr>`
                        });
                    htmlstring += ""</table>"";
                    $(""#listexperience"").html(htmlstring);
                }
            });
        });

        $(""#btnadd"").click(function() {
            let values = {
                Name");
                WriteLiteral(@": $(""#inputName"").val(),
                Date: $(""#inputDate"").val()
            };
            $.ajax({
                type: ""Post"",
                url: ""/Experience_2/AddExperience/"",
                data: values,
                success: function(func) {
                    let result = jQuery.parseJSON(func);
                    alert(result.Name + "" Successfully Added"");

                }

            });
        });

        $(""#btnid"").click(x => {
            let id = $(""#inputId"").val();
            $.ajax({
                contentType: ""Application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Experience_2/GetById/"",
                data: { ExperienceId: id },
                success: function(func) {
                    let result = jQuery.parseJSON(func);
                    console.log(result);
                    let htmlst = `<table class= table table-hover <tr><th>Experience Id</th> <td>${result.ExperienceId}</td></tr");
                WriteLiteral(@"> <tr> <th>Experience Name</th> <td> ${result.Name}</td> </tr> </table>`;
                    $(""#listbyidexperience"").html(htmlst);
                }
            });
        });
        $(""#btndelete"").click(x => {
            let id = $(""#inputDeleteId"").val();
            $.ajax({
                url: ""/Experience_2/DeleteExperience/""+id,
                type: ""post"",
                contentType: ""application/json"",
                dataType: ""json"",
                success: function(func) {
                    loadData(func);
                }
            });
        });

    </script>

");
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "844101f82b9159f2e54526d9cdaa169b47d35da48391", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591