#pragma checksum "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3ee3067ee2e2e2f841e599261d0e1f6274316df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentsArea_Profile), @"mvc.1.0.view", @"/Views/StudentsArea/Profile.cshtml")]
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
#line 1 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\_ViewImports.cshtml"
using VarsityPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\_ViewImports.cshtml"
using VarsityPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ee3067ee2e2e2f841e599261d0e1f6274316df", @"/Views/StudentsArea/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ef77824dae1d593a8f9cb89ce7010b8150e8dc4", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentsArea_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VarsityPortal.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Profile</h1>\r\n\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.cgpa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayFor(model => model.cgpa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.Semester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayFor(model => model.Semester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayFor(model => model.Department.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\arefi\Source\Repos\VarsityPortal\VarsityPortal\Views\StudentsArea\Profile.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VarsityPortal.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
