using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddingCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b0a82ca-1df9-4b39-b7d3-e291df7556bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b200718-2463-4fd8-a8e0-10601d32a109");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c67b58d3-5cd0-441d-944f-fe14570f1f74");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08ba0f07-94d0-40fe-8ded-aeef8f20932c", "97243c41-cf87-4c70-9d03-f9fb17b4d033", "Admin", "ADMIN" },
                    { "318d8d4e-43b6-468e-a687-013844bf7ab6", "6d5ad785-edbf-4cb3-9158-900bc3eda428", "Editor", "EDITOR" },
                    { "39f37ad5-d655-4a75-a0b3-150df15c0b1e", "f075c7ed-4e2a-4783-aff2-a491835fde80", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Computer Science" },
                    { 2, "Network" },
                    { 3, "Database Management Systems" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08ba0f07-94d0-40fe-8ded-aeef8f20932c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "318d8d4e-43b6-468e-a687-013844bf7ab6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39f37ad5-d655-4a75-a0b3-150df15c0b1e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b0a82ca-1df9-4b39-b7d3-e291df7556bd", "b479212e-8e10-4a1c-9389-b8d0bd198521", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b200718-2463-4fd8-a8e0-10601d32a109", "bc1c590c-0266-4743-a0bd-b58fb8752e72", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c67b58d3-5cd0-441d-944f-fe14570f1f74", "b58e527b-e767-421d-a46d-7dee8a61d07f", "Editor", "EDITOR" });
        }
    }
}
