#pragma checksum "F:\About Class\WebDevelopment\@Practice@\ISPYZU2\Areas\Identity\Pages\_LoginLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2af75b73b205287ce15768070d9e8f3ee810840a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__LoginLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_LoginLayout.cshtml")]
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
#line 1 "F:\About Class\WebDevelopment\@Practice@\ISPYZU2\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\About Class\WebDevelopment\@Practice@\ISPYZU2\Areas\Identity\Pages\_ViewImports.cshtml"
using ISPYZU2.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\About Class\WebDevelopment\@Practice@\ISPYZU2\Areas\Identity\Pages\_ViewImports.cshtml"
using ISPYZU2.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\About Class\WebDevelopment\@Practice@\ISPYZU2\Areas\Identity\Pages\_ViewImports.cshtml"
using ISPYZU2.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2af75b73b205287ce15768070d9e8f3ee810840a", @"/Areas/Identity/Pages/_LoginLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2615222aadc1ec3d7983a240c5fcb5181b44cff1", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__LoginLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\About Class\WebDevelopment\@Practice@\ISPYZU2\Areas\Identity\Pages\_LoginLayout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"" >
    <div class=""col-md-10 offset-md-2"">
        <div class=""card login-logout-tab"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs"" >
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Identity/Account/Login"">Student Login</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Identity/Account/TeacherLogin"">Teacher Login</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Identity/Account/AdminLogin"">Admin Login</a>
                    </li>
                </ul>
            </div>
            <div class=""card-content"" style=""padding-left:10px"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        ");
#nullable restore
#line 24 "F:\About Class\WebDevelopment\@Practice@\ISPYZU2\Areas\Identity\Pages\_LoginLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 33 "F:\About Class\WebDevelopment\@Practice@\ISPYZU2\Areas\Identity\Pages\_LoginLayout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
<script>
    $(function () {
        var current = location.pathname;
        $('.nav-tabs li a').each(function () {
            var $this = $(this);
            if (current.indexOf($this.attr('href')) !== -1) {
                $this.addClass('active');
            }
        })
    })
</script>

");
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
