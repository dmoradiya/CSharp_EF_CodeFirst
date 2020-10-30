﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharp_CodeFirst.Migrations
{
    public partial class SeedManufacurerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "manufacturer",
                columns: new[] { "ID", "Name" },
                values: new object[] { -1, "Ford" });

            migrationBuilder.InsertData(
                table: "manufacturer",
                columns: new[] { "ID", "Name" },
                values: new object[] { -2, "Chevrolet" });

            migrationBuilder.InsertData(
                table: "manufacturer",
                columns: new[] { "ID", "Name" },
                values: new object[] { -3, "Dodge" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "manufacturer",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "manufacturer",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "manufacturer",
                keyColumn: "ID",
                keyValue: -1);
        }
    }
}
