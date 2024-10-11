using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Commands.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddInitProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04041e69-3262-468f-bd0f-d6c3d539e1d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30d765e9-b372-40d9-8b74-6dfcdbd27beb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b1cf08a-9df9-4b89-a0ef-d491dea6732c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b61a323-8ebb-4045-849a-29ddec693bc8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51e9096d-6537-4f95-afe7-2b4a14ab2b6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63cab498-7f88-418d-b515-c4d3d983c996"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ba9518e-5ad3-4831-8cbf-ef647636ab8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e1bd3a1-0c24-4fae-9249-85bb25c1bf45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7376b114-aafc-4970-9126-f3ae4976affa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bef2cff-0bb8-4e72-900f-7fd2c9db6329"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4a50ce1-e6e1-46a0-ba99-55e1097f06ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c291dc64-1689-426c-b0d1-ff607dda66b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1fd4e95-936f-435a-898f-d87eccaf3ec8"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Condition", "Description", "ImagePath", "Name", "Price", "PriceWithDiscount" },
                values: new object[,]
                {
                    { new Guid("04041e69-3262-468f-bd0f-d6c3d539e1d2"), "12", 1, "Product 13", "", "Product 13", 25m, 10m },
                    { new Guid("30d765e9-b372-40d9-8b74-6dfcdbd27beb"), "3", 1, "Product 3", "", "Product 3", 20m, 11m },
                    { new Guid("3b1cf08a-9df9-4b89-a0ef-d491dea6732c"), "10", 1, "Product 10", "", "Product 10", 17m, 10m },
                    { new Guid("4b61a323-8ebb-4045-849a-29ddec693bc8"), "11", 1, "Product 11", "", "Product 11", 19m, 10m },
                    { new Guid("51e9096d-6537-4f95-afe7-2b4a14ab2b6f"), "4", 1, "Product 4", "", "Product 4", 22m, 10m },
                    { new Guid("63cab498-7f88-418d-b515-c4d3d983c996"), "6", 1, "Product 6", "", "Product 6", 55m, 10m },
                    { new Guid("6ba9518e-5ad3-4831-8cbf-ef647636ab8b"), "1", 1, "Product 1", "", "Product 1", 10.99m, 8m },
                    { new Guid("6e1bd3a1-0c24-4fae-9249-85bb25c1bf45"), "9", 1, "Product 9", "", "Product 9", 13m, 10m },
                    { new Guid("7376b114-aafc-4970-9126-f3ae4976affa"), "8", 1, "Product 8", "", "Product 8", 10.99m, 10m },
                    { new Guid("7bef2cff-0bb8-4e72-900f-7fd2c9db6329"), "7", 1, "Product 7", "", "Product 7", 44m, 14m },
                    { new Guid("b4a50ce1-e6e1-46a0-ba99-55e1097f06ab"), "12", 1, "Product 12", "", "Product 12", 14m, 10m },
                    { new Guid("c291dc64-1689-426c-b0d1-ff607dda66b4"), "5", 1, "Product 5", "", "Product 5", 60m, 11m },
                    { new Guid("e1fd4e95-936f-435a-898f-d87eccaf3ec8"), "2", 1, "Product 2", "", "Product 2", 10.99m, 10m }
                });
        }
    }
}
