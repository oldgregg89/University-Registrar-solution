#pragma checksum "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaaec4b94ae2fb48bb2e16cfe8bb479adc3eb654"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaaec4b94ae2fb48bb2e16cfe8bb479adc3eb654", @"/Views/Students/Details.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityReg.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(64, 43, true);
            WriteLiteral("\n<h2>Student Details</h2>\n<hr />\n<h3>Name: ");
            EndContext();
            BeginContext(108, 36, false);
#line 9 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
     Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(144, 27, true);
            WriteLiteral("</h3>\n<h3>Enrollment Date: ");
            EndContext();
            BeginContext(172, 62, false);
#line 10 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
                Write(Html.ValueFor(model => model.EnrollmentDate, "{0:MM/dd/yyyy}"));

#line default
#line hidden
            EndContext();
            BeginContext(234, 25, true);
            WriteLiteral("</h3>\n<h3>Major: </h3>\n\n\n");
            EndContext();
#line 14 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
 if(@Model.Courses.Count == 0)
{

#line default
#line hidden
            BeginContext(292, 53, true);
            WriteLiteral("  <p>This student does not belong to any courses</p>\n");
            EndContext();
#line 17 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(354, 50, true);
            WriteLiteral("  <h4>Courses the student belongs to:</h4>\n  <ul>\n");
            EndContext();
#line 22 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
   foreach(var join in Model.Courses)
  {

#line default
#line hidden
            BeginContext(446, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(455, 16, false);
#line 24 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
   Write(join.Course.Name);

#line default
#line hidden
            EndContext();
            BeginContext(471, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 25 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
     using (Html.BeginForm("DeleteCourse", "Students"))
    {
      

#line default
#line hidden
            BeginContext(546, 44, false);
#line 27 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
 Write(Html.Hidden("joinId", @join.CourseStudentId));

#line default
#line hidden
            EndContext();
            BeginContext(591, 44, true);
            WriteLiteral("      <input type=\"submit\" value=\"Delete\"/>\n");
            EndContext();
#line 29 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
    }

#line default
#line hidden
#line 29 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
     
  }

#line default
#line hidden
            BeginContext(645, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 32 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
}

#line default
#line hidden
            BeginContext(655, 41, true);
            WriteLiteral("\n<input type=\"button\" value=\"Return Home\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 696, "\"", 751, 3);
            WriteAttributeValue("", 706, "location.href=\'", 706, 15, true);
#line 34 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
WriteAttributeValue("", 721, Url.Action("Index", "Home"), 721, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 749, "\';", 749, 2, true);
            EndWriteAttribute();
            BeginContext(752, 69, true);
            WriteLiteral(" class=\"btn btn-primary\" />\n<input type=\"button\" value=\"Edit Student\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 821, "\"", 909, 3);
            WriteAttributeValue("", 831, "location.href=\'", 831, 15, true);
#line 35 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
WriteAttributeValue("", 846, Url.Action("Edit", "Students", new { id = Model.StudentId }), 846, 61, false);

#line default
#line hidden
            WriteAttributeValue("", 907, "\';", 907, 2, true);
            EndWriteAttribute();
            BeginContext(910, 71, true);
            WriteLiteral(" class=\"btn btn-primary\" />\n<input type=\"button\" value=\"Delete Student\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 981, "\"", 1071, 3);
            WriteAttributeValue("", 991, "location.href=\'", 991, 15, true);
#line 36 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
WriteAttributeValue("", 1006, Url.Action("Delete", "Students", new { id = Model.StudentId }), 1006, 63, false);

#line default
#line hidden
            WriteAttributeValue("", 1069, "\';", 1069, 2, true);
            EndWriteAttribute();
            BeginContext(1072, 69, true);
            WriteLiteral(" class=\"btn btn-primary\" />\n<input type=\"button\" value=\"Add a Course\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1141, "\"", 1234, 3);
            WriteAttributeValue("", 1151, "location.href=\'", 1151, 15, true);
#line 37 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
WriteAttributeValue("", 1166, Url.Action("AddCourse", "Students", new { id = Model.StudentId }), 1166, 66, false);

#line default
#line hidden
            WriteAttributeValue("", 1232, "\';", 1232, 2, true);
            EndWriteAttribute();
            BeginContext(1235, 69, true);
            WriteLiteral(" class=\"btn btn-primary\" />\n<input type=\"button\" value=\"Back to list\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1304, "\"", 1363, 3);
            WriteAttributeValue("", 1314, "location.href=\'", 1314, 15, true);
#line 38 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Details.cshtml"
WriteAttributeValue("", 1329, Url.Action("Index", "Students"), 1329, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 1361, "\';", 1361, 2, true);
            EndWriteAttribute();
            BeginContext(1364, 27, true);
            WriteLiteral(" class=\"btn btn-primary\" />");
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
