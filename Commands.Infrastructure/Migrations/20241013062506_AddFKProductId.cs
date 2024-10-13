using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Commands.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddFKProductId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "ProductImages",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "ProductImages",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContentType",
                table: "ProductImages",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Condition", "Description", "Name", "Price", "PriceWithDiscount" },
                values: new object[,]
                {
                    { new Guid("15ea94a7-7407-8f1e-847c-0192848d4dd2"), "8", 1, "Product 8", "Product 8", 10.99m, 10m },
                    { new Guid("225eb740-008d-88de-8476-0192848d4dd2"), "2", 1, "Product 2", "Product 2", 10.99m, 10m },
                    { new Guid("39956ed2-fa41-83c2-847b-0192848d4dd2"), "7", 1, "Product 7", "Product 7", 44m, 14m },
                    { new Guid("3c9608cf-afbd-8a9f-847f-0192848d4dd2"), "11", 1, "Product 11", "Product 11", 19m, 10m },
                    { new Guid("4ac7e658-00e8-86d0-847a-0192848d4dd2"), "6", 1, "Product 6", "Product 6", 55m, 10m },
                    { new Guid("4cfcf332-2464-8d3d-8481-0192848d4dd2"), "12", 1, "Product 13", "Product 13", 25m, 10m },
                    { new Guid("69f5d911-fdc8-8b71-847d-0192848d4dd2"), "9", 1, "Product 9", "Product 9", 13m, 10m },
                    { new Guid("6d901439-6ff5-8aa0-8478-0192848d4dd2"), "4", 1, "Product 4", "Product 4", 22m, 10m },
                    { new Guid("83f521c5-227b-803c-847e-0192848d4dd2"), "10", 1, "Product 10", "Product 10", 17m, 10m },
                    { new Guid("8810a1a6-139a-8e2a-8475-0192848d4dd2"), "1", 1, "Product 1", "Product 1", 10.99m, 8m },
                    { new Guid("a3d6ef45-ad04-832b-8479-0192848d4dd2"), "5", 1, "Product 5", "Product 5", 60m, 11m },
                    { new Guid("b1fde725-e962-8988-8477-0192848d4dd2"), "3", 1, "Product 3", "Product 3", 20m, 11m },
                    { new Guid("e7dcc86b-6422-8ead-8480-0192848d4dd2"), "12", 1, "Product 12", "Product 12", 14m, 10m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15ea94a7-7407-8f1e-847c-0192848d4dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("225eb740-008d-88de-8476-0192848d4dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39956ed2-fa41-83c2-847b-0192848d4dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c9608cf-afbd-8a9f-847f-0192848d4dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ac7e658-00e8-86d0-847a-0192848d4dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cfcf332-2464-8d3d-8481-0192848d4dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69f5d911-fdc8-8b71-847d-0192848d4dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d901439-6ff5-8aa0-8478-0192848d4dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83f521c5-227b-803c-847e-0192848d4dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8810a1a6-139a-8e2a-8475-0192848d4dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3d6ef45-ad04-832b-8479-0192848d4dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1fde725-e962-8988-8477-0192848d4dd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7dcc86b-6422-8ead-8480-0192848d4dd2"));

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "ContentType",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

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
    }
}
