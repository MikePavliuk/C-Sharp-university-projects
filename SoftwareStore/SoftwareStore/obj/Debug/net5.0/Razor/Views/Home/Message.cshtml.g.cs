#pragma checksum "C:\Users\Mike\source\repos\C-Sharp-university-projects\SoftwareStore\SoftwareStore\Views\Home\Message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6e52cc602e4dc538d18c365d7a2515d4dba4caa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Message), @"mvc.1.0.view", @"/Views/Home/Message.cshtml")]
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
#line 1 "C:\Users\Mike\source\repos\C-Sharp-university-projects\SoftwareStore\SoftwareStore\Views\_ViewImports.cshtml"
using SoftwareStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mike\source\repos\C-Sharp-university-projects\SoftwareStore\SoftwareStore\Views\_ViewImports.cshtml"
using SoftwareStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mike\source\repos\C-Sharp-university-projects\SoftwareStore\SoftwareStore\Views\_ViewImports.cshtml"
using SoftwareStore.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mike\source\repos\C-Sharp-university-projects\SoftwareStore\SoftwareStore\Views\_ViewImports.cshtml"
using SoftwareStore.Infrastructure.Config;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mike\source\repos\C-Sharp-university-projects\SoftwareStore\SoftwareStore\Views\_ViewImports.cshtml"
using SoftwareStore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mike\source\repos\C-Sharp-university-projects\SoftwareStore\SoftwareStore\Views\_ViewImports.cshtml"
using SoftwareStore.Domain.Entities.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mike\source\repos\C-Sharp-university-projects\SoftwareStore\SoftwareStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mike\source\repos\C-Sharp-university-projects\SoftwareStore\SoftwareStore\Views\_ViewImports.cshtml"
using SoftwareStore.Domain.Entities.App;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6e52cc602e4dc538d18c365d7a2515d4dba4caa", @"/Views/Home/Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed6ca6d901e4611c3e6d5b3ed61fdad706e7485", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mike\source\repos\C-Sharp-university-projects\SoftwareStore\SoftwareStore\Views\Home\Message.cshtml"
  
    ViewData["Title"] = "Message";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2>");
#nullable restore
#line 7 "C:\Users\Mike\source\repos\C-Sharp-university-projects\SoftwareStore\SoftwareStore\Views\Home\Message.cshtml"
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
