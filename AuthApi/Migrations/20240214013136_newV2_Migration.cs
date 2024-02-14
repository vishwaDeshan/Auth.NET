using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthApi.Migrations
{
    /// <inheritdoc />
    public partial class newV2Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2409f62b-87e2-4073-95d4-e96b4ba5a8f6", "3", "HR", "HR" },
                    { "6be9d1d4-035e-4d39-a1c3-41774db3ecb0", "1", "Admin", "Admin" },
                    { "b8df3cd3-7540-4227-8259-437c261b4d60", "2", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2409f62b-87e2-4073-95d4-e96b4ba5a8f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6be9d1d4-035e-4d39-a1c3-41774db3ecb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8df3cd3-7540-4227-8259-437c261b4d60");

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
    }
}
