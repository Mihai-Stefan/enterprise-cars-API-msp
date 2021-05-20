using Microsoft.EntityFrameworkCore.Migrations;

namespace cardata_api_v3.Migrations
{
    public partial class AddCarItemProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OwnerId",
                table: "CarItems",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "PlateNumber",
                table: "CarItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValuePoints",
                table: "CarItems",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "CarItems");

            migrationBuilder.DropColumn(
                name: "PlateNumber",
                table: "CarItems");

            migrationBuilder.DropColumn(
                name: "ValuePoints",
                table: "CarItems");
        }
    }
}
