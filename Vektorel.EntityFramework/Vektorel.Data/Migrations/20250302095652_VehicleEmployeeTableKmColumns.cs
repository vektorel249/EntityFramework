using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vektorel.Data.Migrations
{
    /// <inheritdoc />
    public partial class VehicleEmployeeTableKmColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GivenKm",
                schema: "vektorel",
                table: "EmployeeVehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TakenKm",
                schema: "vektorel",
                table: "EmployeeVehicles",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GivenKm",
                schema: "vektorel",
                table: "EmployeeVehicles");

            migrationBuilder.DropColumn(
                name: "TakenKm",
                schema: "vektorel",
                table: "EmployeeVehicles");
        }
    }
}
