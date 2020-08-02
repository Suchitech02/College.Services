using College.Services.Entities;
using Microsoft.EntityFrameworkCore;

namespace College.Services.Persistence
{

    public class CollegeDbContext : DbContext
    {

        public CollegeDbContext(DbContextOptions<CollegeDbContext> options) : base(options)
        {

        }

        public DbSet<Professor> Professors { get; set; }

        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
          modelBuilder.Entity<Professor>().HasData(
        new Professor
        {
            ProfessorId=1,
            Name = "sandeep",
            Doj = "29-11-23",
           Teaches  = "Shakespeare",
           Salary=222,
           IsPhd=true,

        }
    );
      modelBuilder.Entity<Student>().HasData(
        new Student { Name="sand",RollNumber="123",ProfessorId=1,StudentId = 1,Fees=224 },
        new Student { Name="san",RollNumber="1243",ProfessorId=1,StudentId = 2,Fees=224 },
        new Student { Name="sa",RollNumber="1243",ProfessorId=1,StudentId = 3,Fees=224 }
        );
      }
    }
}