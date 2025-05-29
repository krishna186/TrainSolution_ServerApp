using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainSolution_ServerApp.Migrations
{
    /// <inheritdoc />
    public partial class TrainComponentSolution : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SerialNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    VehicleNumber = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    InstallDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    VehicleNumber = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    FleetName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    DateIntoService = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateEndsService = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.VehicleNumber);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Trains");
        }
    }
}
