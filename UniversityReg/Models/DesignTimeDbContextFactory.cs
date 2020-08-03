using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace UniversityReg.Models
{
  public class UniversityRegContextFactory : IDesignTimeDbContextFactory<UniversityRegContext>
  {

    UniversityRegContext IDesignTimeDbContextFactory<UniversityRegContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<UniversityRegContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new UniversityRegContext(builder.Options);
    }
  }
}