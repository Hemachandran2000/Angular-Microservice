using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingInfra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductPrize = table.Column<int>(nullable: false),
                    ProductSize = table.Column<int>(nullable: false),
                    ProductDesc = table.Column<string>(nullable: true),
                    ProductImage = table.Column<string>(nullable: true),
                    ProductColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    SubCategoryId = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<string>(nullable: true),
                    SubCategoryName = table.Column<string>(nullable: true),
                    SubCategoryDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.SubCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserPassword = table.Column<string>(nullable: true),
                    UserRole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductColor", "ProductDesc", "ProductImage", "ProductName", "ProductPrize", "ProductSize" },
                values: new object[,]
                {
                    { new Guid("02bb10c6-fa0f-4f3e-9171-27d457ba28fa"), "0xFFFB7883", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since. When an unknown printer took a galley.", "assets/images/bag_5.png", "Woman Fashion", 234, 18 },
                    { new Guid("62f0b64b-cd51-4980-a5e0-0f2ddec1f84c"), "0xFFAEAEAE", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since. When an unknown printer took a galley.", "assets/images/bag_4.png", "New Fashion", 165, 10 },
                    { new Guid("71155562-f71e-493d-bc4a-7fd294df7a9d"), "0xFFE6B398", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since. When an unknown printer took a galley.", "assets/images/bag_3.png", "Old Fashion", 186, 14 },
                    { new Guid("36ba0a04-a18c-4d3e-b11c-33cd9101f490"), "0xFF3D82AE", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since. When an unknown printer took a galley.", "assets/images/bag_2.png", "Office Code", 135, 12 },
                    { new Guid("afb6d141-849a-407a-8ff2-242eda21a3b7"), "0xFFD3A984", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since. When an unknown printer took a galley.", "assets/images/bag_1.png", "Belt Bag", 100, 17 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName", "UserPassword", "UserRole" },
                values: new object[,]
                {
                    { new Guid("c5e655b2-8c5c-4a89-8e80-832a3719a7ef"), "Hemanth", "12345", "user" },
                    { new Guid("03133ec8-b347-4a87-a4fc-775dc45c68c2"), "Admin", "12345", "admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
