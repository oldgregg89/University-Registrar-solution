using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace UniversityReg.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<CourseStudent>();
    }
    public int StudentId {get; set; }
    public string Name { get; set;}
    public DateTime EnrollmentDate { get; set; }
    public ICollection<CourseStudent> Courses {get;} 
  }
}