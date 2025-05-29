using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainSolution_ServerApp.Migrations
{
    /// <inheritdoc />
    public partial class VehicleTableData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trains",
                columns: new[] { "VehicleNumber", "DateEndsService", "DateIntoService", "FleetName" },
                values: new object[,]
                {
                    { "VH001", new DateTime(2030, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fleet A" },
                    { "VH002", new DateTime(2031, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fleet A" },
                    { "VH003", new DateTime(2050, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fleet B" },
                    { "VH004", new DateTime(2050, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fleet B" },
                    { "VH005", new DateTime(2031, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fleet C" },
                    { "VH006", new DateTime(2031, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fleet C" },
                    { "VH007", new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fleet D" },
                    { "VH008", new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fleet D" },
                    { "VH009", new DateTime(2030, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fleet A" },
                    { "VH010", new DateTime(2050, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fleet B" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "VehicleNumber",
                keyValue: "VH001");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "VehicleNumber",
                keyValue: "VH002");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "VehicleNumber",
                keyValue: "VH003");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "VehicleNumber",
                keyValue: "VH004");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "VehicleNumber",
                keyValue: "VH005");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "VehicleNumber",
                keyValue: "VH006");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "VehicleNumber",
                keyValue: "VH007");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "VehicleNumber",
                keyValue: "VH008");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "VehicleNumber",
                keyValue: "VH009");

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "VehicleNumber",
                keyValue: "VH010");
        }
    }
}
