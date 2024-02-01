using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiDemo.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("1cc30840-f2e1-4d15-a928-98f1259b2826"), new DateTime(1990, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", "Adams" },
                    { new Guid("cc75426b-e049-4a7c-b060-a2163cad6466"), new DateTime(1992, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Smith" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("1cc30840-f2e1-4d15-a928-98f1259b2826"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: new Guid("cc75426b-e049-4a7c-b060-a2163cad6466"));
        }
    }
}
