using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vektorel.Data.Migrations
{
    /// <inheritdoc />
    public partial class VehicleEmployeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "vektorel");

            migrationBuilder.CreateTable(
                name: "EmployeeVehicles",
                schema: "vektorel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeVehicles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmployeeVehicles_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeVehicles_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalSchema: "vektorel",
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVehicles_EmployeeID",
                schema: "vektorel",
                table: "EmployeeVehicles",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVehicles_VehicleID",
                schema: "vektorel",
                table: "EmployeeVehicles",
                column: "VehicleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeVehicles",
                schema: "vektorel");
        }
    }
}
