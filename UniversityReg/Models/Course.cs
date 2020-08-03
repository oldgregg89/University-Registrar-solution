using System.Collections.Generic;

namespace UniversityReg.Models
{
  public class Course
  {
    public Course()
    {
      this.Student = new HashSet<CourseStudent>();
    }
    public int CourseId {get; set;}
    public string Name {get; set;}
    public int Number {get; set;}
    public virtual ICollection<CourseStudent> Students { get; set;}
  }
}