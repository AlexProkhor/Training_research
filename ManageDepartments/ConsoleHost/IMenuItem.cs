using ManageDepartments.Data;

namespace ConsoleHost
{
    internal interface IMenuItem
    {
        string Name { get; }
        void Execute(ManageDepartmentsContext context);
    }
}
