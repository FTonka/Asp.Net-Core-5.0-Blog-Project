#pragma checksum "C:\Users\fetta\source\repos\BlogProject\BlogProject\Views\Shared\Components\GetCategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85d44bdd0a3caa5e951d22fe4c06dc1544b58b66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetCategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/GetCategoryList/Default.cshtml")]
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
#line 1 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using BlogProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Views\_ViewImports.cshtml"
using BlogProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d44bdd0a3caa5e951d22fe4c06dc1544b58b66", @"/Views/Shared/Components/GetCategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f611d8a26e9ddd131eab235047e43c94299cee7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_GetCategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n\t<h4>Categories</h4>\r\n");
#nullable restore
#line 4 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Views\Shared\Components\GetCategoryList\Default.cshtml"
     foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<ul class=\"list-group single\">\r\n\t\t<li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n\t\t\t ");
#nullable restore
#line 7 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Views\Shared\Components\GetCategoryList\Default.cshtml"
        Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<span class=\"badge badge-primary badge-pill\"></span>\r\n\t\t</li>\r\n\t</ul>\r\n");
#nullable restore
#line 11 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Views\Shared\Components\GetCategoryList\Default.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
