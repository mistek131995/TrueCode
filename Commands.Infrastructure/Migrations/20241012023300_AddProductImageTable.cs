using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Commands.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddProductImageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0962af2c-6324-8965-82c1-019278e4e391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f652078-ec37-80a0-82c4-019278e4e391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27491939-9e44-88d5-82c2-019278e4e391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27b7a9f3-6500-8ff9-82c8-019278e4e391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28ae367f-0ef4-8d6d-82ca-019278e4e391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cd0d5a8-dbaf-813b-82be-019278e4e391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b406cb7-7186-8be5-82c9-019278e4e391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("419c8cf0-48b1-889a-82c0-019278e4e391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cd9e6c8-f2f1-8c33-82c3-019278e4e391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9195ed82-74e3-8108-82c5-019278e4e391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ec994c5-bcda-8042-82c7-019278e4e391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5ba80ad-3d9d-8b5b-82c6-019278e4e391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec0902df-16dc-82aa-82bf-019278e4e391"));

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Condition", "Description", "Name", "Price", "PriceWithDiscount" },
                values: new object[,]
                {
                    { new Guid("033c26e5-189e-8fda-856c-01927e927391"), "8", 1, "Product 8", "Product 8", 10.99m, 10m },
                    { new Guid("0e3952ee-c3a2-80c6-8566-01927e927391"), "2", 1, "Product 2", "Product 2", 10.99m, 10m },
                    { new Guid("10f57ae3-93ee-85f3-8570-01927e927391"), "12", 1, "Product 12", "Product 12", 14m, 10m },
                    { new Guid("13bef071-fe3e-854e-8568-01927e927391"), "4", 1, "Product 4", "Product 4", 22m, 10m },
                    { new Guid("207a6515-b7ce-835c-8569-01927e927391"), "5", 1, "Product 5", "Product 5", 60m, 11m },
                    { new Guid("2e0e8cbf-ff3d-819b-856f-01927e927391"), "11", 1, "Product 11", "Product 11", 19m, 10m },
                    { new Guid("33b77165-9cdb-854c-856d-01927e927391"), "9", 1, "Product 9", "Product 9", 13m, 10m },
                    { new Guid("49f8f7b6-1c72-8327-8565-01927e927391"), "1", 1, "Product 1", "Product 1", 10.99m, 8m },
                    { new Guid("6650cd6a-f583-8719-856a-01927e927391"), "6", 1, "Product 6", "Product 6", 55m, 10m },
                    { new Guid("7e8080b2-5748-8564-856b-01927e927391"), "7", 1, "Product 7", "Product 7", 44m, 14m },
                    { new Guid("ca05f7ef-7ade-87b8-8571-01927e927391"), "12", 1, "Product 13", "Product 13", 25m, 10m },
                    { new Guid("db9662e0-0db1-8138-856e-01927e927391"), "10", 1, "Product 10", "Product 10", 17m, 10m },
                    { new Guid("f01920c6-083c-884a-8567-01927e927391"), "3", 1, "Product 3", "Product 3", 20m, 11m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("033c26e5-189e-8fda-856c-01927e927391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e3952ee-c3a2-80c6-8566-01927e927391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10f57ae3-93ee-85f3-8570-01927e927391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13bef071-fe3e-854e-8568-01927e927391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("207a6515-b7ce-835c-8569-01927e927391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e0e8cbf-ff3d-819b-856f-01927e927391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33b77165-9cdb-854c-856d-01927e927391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49f8f7b6-1c72-8327-8565-01927e927391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6650cd6a-f583-8719-856a-01927e927391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e8080b2-5748-8564-856b-01927e927391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca05f7ef-7ade-87b8-8571-01927e927391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db9662e0-0db1-8138-856e-01927e927391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f01920c6-083c-884a-8567-01927e927391"));

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Condition", "Description", "ImagePath", "Name", "Price", "PriceWithDiscount" },
                values: new object[,]
                {
                    { new Guid("0962af2c-6324-8965-82c1-019278e4e391"), "4", 1, "Product 4", "", "Product 4", 22m, 10m },
                    { new Guid("1f652078-ec37-80a0-82c4-019278e4e391"), "7", 1, "Product 7", "", "Product 7", 44m, 14m },
                    { new Guid("27491939-9e44-88d5-82c2-019278e4e391"), "5", 1, "Product 5", "", "Product 5", 60m, 11m },
                    { new Guid("27b7a9f3-6500-8ff9-82c8-019278e4e391"), "11", 1, "Product 11", "", "Product 11", 19m, 10m },
                    { new Guid("28ae367f-0ef4-8d6d-82ca-019278e4e391"), "12", 1, "Product 13", "", "Product 13", 25m, 10m },
                    { new Guid("2cd0d5a8-dbaf-813b-82be-019278e4e391"), "1", 1, "Product 1", "", "Product 1", 10.99m, 8m },
                    { new Guid("3b406cb7-7186-8be5-82c9-019278e4e391"), "12", 1, "Product 12", "", "Product 12", 14m, 10m },
                    { new Guid("419c8cf0-48b1-889a-82c0-019278e4e391"), "3", 1, "Product 3", "", "Product 3", 20m, 11m },
                    { new Guid("5cd9e6c8-f2f1-8c33-82c3-019278e4e391"), "6", 1, "Product 6", "", "Product 6", 55m, 10m },
                    { new Guid("9195ed82-74e3-8108-82c5-019278e4e391"), "8", 1, "Product 8", "", "Product 8", 10.99m, 10m },
                    { new Guid("9ec994c5-bcda-8042-82c7-019278e4e391"), "10", 1, "Product 10", "", "Product 10", 17m, 10m },
                    { new Guid("d5ba80ad-3d9d-8b5b-82c6-019278e4e391"), "9", 1, "Product 9", "", "Product 9", 13m, 10m },
                    { new Guid("ec0902df-16dc-82aa-82bf-019278e4e391"), "2", 1, "Product 2", "", "Product 2", 10.99m, 10m }
                });
        }
    }
}
