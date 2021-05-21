using Microsoft.EntityFrameworkCore.Migrations;

namespace cardata_api_v3.Migrations
{
    public partial class CreateEmployeesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationId = table.Column<long>(type: "bigint", nullable: true),
                    RankPoints = table.Column<int>(type: "int", nullable: true),
                    CarOption1 = table.Column<long>(type: "bigint", nullable: true),
                    CarOption2 = table.Column<long>(type: "bigint", nullable: true),
                    CarOption3 = table.Column<long>(type: "bigint", nullable: true),
                    AssignedCar = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
