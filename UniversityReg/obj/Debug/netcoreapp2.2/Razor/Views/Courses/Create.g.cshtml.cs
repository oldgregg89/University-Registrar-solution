#pragma checksum "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dce060e2470e829ded57271987be28c54da392ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Create), @"mvc.1.0.view", @"/Views/Courses/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Create.cshtml", typeof(AspNetCore.Views_Courses_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dce060e2470e829ded57271987be28c54da392ad", @"/Views/Courses/Create.cshtml")]
    public class Views_Courses_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityReg.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(63, 26, true);
            WriteLiteral("\n<h1>Add New Course</h1>\n\n");
            EndContext();
#line 9 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(122, 34, false);
#line 11 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(162, 36, false);
#line 12 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(205, 36, false);
#line 14 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Create.cshtml"
Write(Html.LabelFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(247, 38, false);
#line 15 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Create.cshtml"
Write(Html.TextBoxFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(287, 75, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new course\" class=\"btn btn-default\" />\n");
            EndContext();
#line 18 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Create.cshtml"
}

#line default
#line hidden
            BeginContext(364, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(369, 39, false);
#line 20 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Create.cshtml"
Write(Html.ActionLink("Course List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(408, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityReg.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591