#pragma checksum "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f90773f59bb7091ce1a6d1cc1d60160602eebfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Index), @"mvc.1.0.view", @"/Views/Courses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Index.cshtml", typeof(AspNetCore.Views_Courses_Index))]
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
#line 5 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Index.cshtml"
using UniversityReg.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f90773f59bb7091ce1a6d1cc1d60160602eebfb", @"/Views/Courses/Index.cshtml")]
    public class Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UniversityReg.Models.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(99, 19, true);
            WriteLiteral("\n<h1>Courses</h1>\n\n");
            EndContext();
#line 10 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(144, 43, true);
            WriteLiteral("  <h3>No courses have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(190, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Index.cshtml"
 foreach (Course course in Model)
{

#line default
#line hidden
            BeginContext(227, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(234, 71, false);
#line 17 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Index.cshtml"
 Write(Html.ActionLink($"{course.Name}", "Name", new { id = course.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(305, 4, true);
            WriteLiteral(" || ");
            EndContext();
            BeginContext(310, 13, false);
#line 17 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Index.cshtml"
                                                                             Write(course.Number);

#line default
#line hidden
            EndContext();
            BeginContext(323, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Index.cshtml"
}

#line default
#line hidden
            BeginContext(331, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(336, 43, false);
#line 20 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Courses/Index.cshtml"
Write(Html.ActionLink("Add new course", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(379, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UniversityReg.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591