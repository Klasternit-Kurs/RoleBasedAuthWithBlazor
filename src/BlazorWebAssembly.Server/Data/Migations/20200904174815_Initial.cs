using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorWebAssembly.Server.Data.Migations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37164cce-ffcb-484e-8501-9ea116c925f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecdaa209-2c35-4e27-acb7-f8d173ce1dda");

            migrationBuilder.AddColumn<int>(
                name: "NestoNesto",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bla",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "678a5f55-e4fe-4a34-83f1-c408c659b678", "422f5b61-79a4-4fa5-9719-e42a37d28bcb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cab145dd-f46d-4c7d-837e-2eadc2a09684", "ca5809c6-0527-4ab9-a5c1-bf5613561912", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "678a5f55-e4fe-4a34-83f1-c408c659b678");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cab145dd-f46d-4c7d-837e-2eadc2a09684");

            migrationBuilder.DropColumn(
                name: "NestoNesto",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Bla",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37164cce-ffcb-484e-8501-9ea116c925f7", "6434d7e4-c81c-4d80-8f15-6a6307df3b7f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecdaa209-2c35-4e27-acb7-f8d173ce1dda", "2d4420f4-ced7-4896-9a1f-a185a0919618", "Admin", "ADMIN" });
        }
    }
}
