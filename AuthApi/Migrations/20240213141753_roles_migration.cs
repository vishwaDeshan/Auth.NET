using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthApi.Migrations
{
    /// <inheritdoc />
    public partial class rolesmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1580c4c2-d0b1-478d-9733-4500b1ba9366", "2", "User", "User" },
                    { "28a8e3fa-0fd1-4e46-a93c-ca922298e032", "1", "Admin", "Admin" },
                    { "9faef666-3c63-4c64-bbf3-2be5d28a957d", "3", "HR", "HR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1580c4c2-d0b1-478d-9733-4500b1ba9366");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28a8e3fa-0fd1-4e46-a93c-ca922298e032");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9faef666-3c63-4c64-bbf3-2be5d28a957d");
        }
    }
}
