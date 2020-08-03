using System.Collections.Generic;
using Microsoft.EntityFramework;

namespace UniversityReg.Models
{
  public class UniversityRegContext : DbContext
  {
    public virtual DbSet<Course> Courses {get; set;}
    public virtual DbSet<Student> Students {get; set;}
    public UniversityRegContext(DbContextOptions options): base(options) {}
  }
}
