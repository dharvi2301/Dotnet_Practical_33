using Microsoft.EntityFrameworkCore;
using Practical_33_Blazor_Server_App.Model;

namespace Practical_33_Blazor_Server_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<EmployeeModel> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeModel>().ToTable("Employees");
            modelBuilder.Entity<EmployeeModel>().HasKey(e => e.Id);
            modelBuilder.Entity<EmployeeModel>().Property(e => e.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<EmployeeModel>().Property(e => e.Email).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<EmployeeModel>().Property(e => e.Department).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<EmployeeModel>().Property(e => e.Salary).IsRequired();
        }
    }
}
