using ManageDepartments.Data;
using ManageDepartments.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ConsoleHost.MenuItems
{
    public class DepartmentList : IMenuItem
    {
        public string Name => "Список подразделений";

        public void Execute(ManageDepartmentsContext context)
        {
            IQueryable<Department> queriable = context.Departments.Include(x => x.Branch).OrderBy(x => x.Name);

            foreach (var x in queriable)
                Console.WriteLine("{0} - {1} [{2}]", x.Id, x.Name, x.Branch.Name);
        }
    }
}
