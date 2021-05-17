using Microsoft.EntityFrameworkCore.Migrations;

namespace cardata_api_v3.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Engine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineYearI = table.Column<int>(type: "int", nullable: true),
                    EngineYearF = table.Column<int>(type: "int", nullable: true),
                    Co2EemissionsUm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Co2Eemissions = table.Column<int>(type: "int", nullable: true),
                    MaxPowerKw = table.Column<int>(type: "int", nullable: true),
                    MaxPowerBhp = table.Column<int>(type: "int", nullable: true),
                    MaxTorqueNm = table.Column<int>(type: "int", nullable: true),
                    TopSpeedKmph = table.Column<int>(type: "int", nullable: true),
                    Zero100 = table.Column<double>(type: "float", nullable: true),
                    ModelYearI = table.Column<int>(type: "int", nullable: true),
                    ModelYearF = table.Column<int>(type: "int", nullable: true),
                    Generation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarItems");
        }
    }
}
