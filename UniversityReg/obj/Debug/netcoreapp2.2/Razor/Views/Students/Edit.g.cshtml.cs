#pragma checksum "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dabc4ea77daef9b7901aa63d145c552874fe46ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Edit), @"mvc.1.0.view", @"/Views/Students/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Edit.cshtml", typeof(AspNetCore.Views_Students_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dabc4ea77daef9b7901aa63d145c552874fe46ef", @"/Views/Students/Edit.cshtml")]
    public class Views_Students_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityReg.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(64, 39, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this student: ");
            EndContext();
            BeginContext(104, 36, false);
#line 9 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Edit.cshtml"
                  Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(140, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(180, 40, false);
#line 13 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Edit.cshtml"
Write(Html.HiddenFor(model => model.StudentId));

#line default
#line hidden
            EndContext();
            BeginContext(227, 34, false);
#line 15 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(267, 35, false);
#line 16 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(309, 27, false);
#line 18 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Edit.cshtml"
Write(Html.Label("Select course"));

#line default
#line hidden
            EndContext();
            BeginContext(342, 29, false);
#line 19 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Edit.cshtml"
Write(Html.DropDownList("CourseId"));

#line default
#line hidden
            EndContext();
            BeginContext(373, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 22 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(416, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(421, 40, false);
#line 24 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(461, 4, true);
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