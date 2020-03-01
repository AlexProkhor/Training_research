using ManageDepartments.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManageDepartments.Data
{
    public class ManageDepartmentsContext : DbContext
    {
        public const string ConnectionString = @"Data Source=DESKTOP-TRGIUQ2; Initial Catalog = ManageDepartments; Integrated Security = True";

        protected ManageDepartmentsContext()
        {
        }

        public ManageDepartmentsContext(DbContextOptions options)
            : base (options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
