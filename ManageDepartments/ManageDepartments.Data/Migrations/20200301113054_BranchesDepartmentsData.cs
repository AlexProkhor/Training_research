using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageDepartments.Data.Migrations
{
    public partial class BranchesDepartmentsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "Branches",
                new[] { "Id", "Name" },
                new object[,] {
                    { 1, "Головной филиал" },
                    { 2, "Казанский филиал" },
                    { 3, "Оренбургский филиал" }
                });

            migrationBuilder.InsertData(
                "Departments",
                new[] { "Id", "Name", "BranchId" },
                new object[,]
                {
                    { 1, "Головной офис", 1 },
                    { 2, "Московкий офис", 1 },
                    { 3, "Казанский офис", 2 },
                    { 4, "Набережночелнинский офис", 2 },
                    { 5, "Оренбургский офис", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("Branches", "Id", new object[] { 1, 2, 3 });
            migrationBuilder.DeleteData("Departments", "Id", new object[] { 1, 2, 3, 4, 5 });
        }
    }
}
