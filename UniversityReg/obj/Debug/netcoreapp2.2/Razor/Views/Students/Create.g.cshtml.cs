#pragma checksum "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df412fd31117e3f56744ed3e8f289b0bbe308543"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Create), @"mvc.1.0.view", @"/Views/Students/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Create.cshtml", typeof(AspNetCore.Views_Students_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df412fd31117e3f56744ed3e8f289b0bbe308543", @"/Views/Students/Create.cshtml")]
    public class Views_Students_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityReg.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(64, 29, true);
            WriteLiteral("\n<h4>Add a new Student</h4>\n\n");
            EndContext();
#line 9 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(126, 34, false);
#line 11 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(166, 36, false);
#line 12 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(209, 27, false);
#line 14 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Create.cshtml"
Write(Html.Label("Select course"));

#line default
#line hidden
            EndContext();
            BeginContext(242, 29, false);
#line 15 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Create.cshtml"
Write(Html.DropDownList("CourseId"));

#line default
#line hidden
            EndContext();
            BeginContext(273, 76, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new student\" class=\"btn btn-default\" />\n");
            EndContext();
#line 18 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Create.cshtml"
}

#line default
#line hidden
            BeginContext(351, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(355, 45, false);
#line 19 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Create.cshtml"
Write(Html.ActionLink("Show all students", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(400, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityReg.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591