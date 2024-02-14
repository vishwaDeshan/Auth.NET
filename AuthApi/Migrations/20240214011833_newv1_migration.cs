using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthApi.Migrations
{
    /// <inheritdoc />
    public partial class newv1migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18f2ca72-2547-4054-aabb-cfb60d8a91d9", "3", "HR", "HR" },
                    { "6278c505-df84-44d7-a38c-430d31dfa764", "1", "Admin", "Admin" },
                    { "bae2d4b4-ee27-487d-9241-89fd4fb88e01", "2", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18f2ca72-2547-4054-aabb-cfb60d8a91d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6278c505-df84-44d7-a38c-430d31dfa764");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bae2d4b4-ee27-487d-9241-89fd4fb88e01");

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
    }
}
