#pragma checksum "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "236ec0184f11f6e6f1abaab2ddf67f434b8dd621"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudentHelper.Pages.Students.Pages_Students_Index), @"mvc.1.0.razor-page", @"/Pages/Students/Index.cshtml")]
namespace StudentHelper.Pages.Students
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
#line 1 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\_ViewImports.cshtml"
using StudentHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"236ec0184f11f6e6f1abaab2ddf67f434b8dd621", @"/Pages/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23f8c56e8fb468676259a4c32049966aafdbaba3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Students_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Student List</h1>\r\n\r\n<p>\r\n    <a href=\"Students/Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].StudentFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].StudentLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].StudentEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].RegistrationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
 foreach (var item in Model.Student) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudentFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudentLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudentEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RegistrationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.StudentID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 48 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  id=item.StudentID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 49 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id=item.StudentID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\dawns\OneDrive\Desktop\StudentHelper_FinalUpdate\StudentHelper\Pages\Students\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentHelper.Pages.Students.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentHelper.Pages.Students.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentHelper.Pages.Students.IndexModel>)PageContext?.ViewData;
        public StudentHelper.Pages.Students.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
