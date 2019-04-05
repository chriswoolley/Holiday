#pragma checksum "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a83f680c6f0d20d11f01c2412b0d39a8e5266468"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using HolidayWeb;

#line default
#line hidden
#line 2 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using HolidayWeb.Models;

#line default
#line hidden
#line 3 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using HolidayWeb.ViewModels;

#line default
#line hidden
#line 4 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using HolidayWeb.Models.Interface;

#line default
#line hidden
#line 6 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using HolidayWeb.Controllers;

#line default
#line hidden
#line 10 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#line 1 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83f680c6f0d20d11f01c2412b0d39a8e5266468", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684319d2b5c09d56177991476ee998774aabcedb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(130, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_FrontPageLayout.cshtml";

#line default
#line hidden
#line 9 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Index.cshtml"
  
    bool isUserLoggedIn = ViewBag.Users != null;

#line default
#line hidden
            BeginContext(254, 48, true);
            WriteLiteral("<p class=\".bottom-two\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 14 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Index.cshtml"
         if (SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
            BeginContext(359, 99, true);
            WriteLiteral("            <div class=\"column left dx-datagrid-filter-panel\" style=\"width:auto\">\r\n                ");
            EndContext();
            BeginContext(459, 84, false);
#line 17 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Index.cshtml"
           Write(await Html.PartialAsync("~/Views/Home/_DepartmentList.cshtml", Model.DepartmentList));

#line default
#line hidden
            EndContext();
            BeginContext(543, 170, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"column middle\">\r\n                <div class=\"column left dx-datagrid-filter-panel\" style=\"width:auto\">\r\n                    ");
            EndContext();
            BeginContext(714, 89, false);
#line 21 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Index.cshtml"
               Write(await Html.PartialAsync("~/Views/Home/Scheduler.cshtml", Model.AppointmentList, ViewData));

#line default
#line hidden
            EndContext();
            BeginContext(803, 103, true);
            WriteLiteral(";\r\n                </div>\r\n            </div>\r\n            <div class=\"column right\">\r\n                ");
            EndContext();
            BeginContext(907, 86, false);
#line 25 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Index.cshtml"
           Write(await Html.PartialAsync("~/Views/User/_UserStatView.cshtml", Model.DepartmentUserList));

#line default
#line hidden
            EndContext();
            BeginContext(993, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 27 "C:\HolidayManager\DevExtremeAspNetCoreApp3\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1026, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(1090, 166, true);
            WriteLiteral("</p>\r\n\r\n\r\n<script>\r\n    function showToast(event, value, type) {\r\n        DevExpress.ui.notify(event + \" \\\"\" + value + \"\\\"\" + \" task\", type, 800);\r\n    }\r\n</script>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<HolidayUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
