using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ManageDepartments.Data
{

    public class ContextFactory : IDesignTimeDbContextFactory<ManageDepartmentsContext>
    {
        public ManageDepartmentsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ManageDepartmentsContext>();
            optionsBuilder.UseSqlServer(ManageDepartmentsContext.ConnectionString);

            return new ManageDepartmentsContext(optionsBuilder.Options);
        }
    }
}
