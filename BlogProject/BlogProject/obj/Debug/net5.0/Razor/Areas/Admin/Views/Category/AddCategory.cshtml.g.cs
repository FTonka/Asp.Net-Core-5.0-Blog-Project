#pragma checksum "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f61923a463b1febf7f65d087f99029cadf09c7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_AddCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/AddCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f61923a463b1febf7f65d087f99029cadf09c7b", @"/Areas/Admin/Views/Category/AddCategory.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Category>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml"
  
    ViewData["Title"] = "AddCategory";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Yeni Kategori Girişi</h1>\r\n");
#nullable restore
#line 7 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml"
 using(Html.BeginForm("AddCategory","Category",FormMethod.Post)){
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.Label("Kategori Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml"
                               ;
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.TextBoxFor(x=>x.CategoryName,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml"
                                                                   
	;
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.ValidationMessageFor(x=>x.CategoryName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml"
                                                 ;


#line default
#line hidden
#nullable disable
            WriteLiteral("\t<br />\r\n");
#nullable restore
#line 14 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.Label("Kategori Açıklaması"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.TextAreaFor(x=>x.CategoryDescription,10,5,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.ValidationMessageFor(x=>x.CategoryDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<button type=\"submit\" class=\"btn btn-primary submit mb-4\">Kategori Ekle</button>\r\n");
#nullable restore
#line 19 "C:\Users\fetta\source\repos\BlogProject\BlogProject\Areas\Admin\Views\Category\AddCategory.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591