using ManageDepartments.Data;
using ManageDepartments.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleHost.MenuItems
{
    internal class BranchList : IMenuItem
    {
        public string Name => "Список филиалов";

        public void Execute(ManageDepartmentsContext context)
        {
            //IQueryable<Branch> queriable = context.Branches.OrderBy(x => x.Name);
            IQueryable<Branch> queriable = from branche in context.Branches
                                           orderby branche.Name
                                           select branche;

            //queriable = queriable.Where(x => x.Name.StartsWith("К"));
            //queriable = from branch in queriable
            //            where branch.Name.StartsWith("К")
            //            select branch;

            foreach (Branch branch in queriable)
                Console.WriteLine("{0} - {1}", branch.Id, branch.Name);
        }
    }
}
