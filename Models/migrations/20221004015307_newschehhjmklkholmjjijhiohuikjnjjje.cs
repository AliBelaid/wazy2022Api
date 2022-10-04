using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wazyApi.Models.migrations
{
    public partial class newschehhjmklkholmjjijhiohuikjnjjje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategories_Pivots_pivotid",
                table: "BlogCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Pivots_pivotid",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_ProductDtos_ProductDtoid",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Pivots_pivotid",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_ProductDtos_ProductDtoid",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Pivots_pivotid",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_ProductDtos_ProductDtoid",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_Pivots_pivotid",
                table: "Sizes");

            migrationBuilder.DropForeignKey(
                name: "FK_SmPictures_Pivots_pivotid",
                table: "SmPictures");

            migrationBuilder.DropForeignKey(
                name: "FK_SmPictures_ProductDtos_ProductDtoid",
                table: "SmPictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Variants_Pivots_pivotid",
                table: "Variants");

            migrationBuilder.DropForeignKey(
                name: "FK_Variants_ProductDtos_ProductDtoid",
                table: "Variants");

            migrationBuilder.DropTable(
                name: "ProductDtos");

            migrationBuilder.DropIndex(
                name: "IX_Variants_pivotid",
                table: "Variants");

            migrationBuilder.DropIndex(
                name: "IX_Variants_ProductDtoid",
                table: "Variants");

            migrationBuilder.DropIndex(
                name: "IX_SmPictures_pivotid",
                table: "SmPictures");

            migrationBuilder.DropIndex(
                name: "IX_SmPictures_ProductDtoid",
                table: "SmPictures");

            migrationBuilder.DropIndex(
                name: "IX_Sizes_pivotid",
                table: "Sizes");

            migrationBuilder.DropIndex(
                name: "IX_Images_pivotid",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_ProductDtoid",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Categories_pivotid",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ProductDtoid",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Brands_pivotid",
                table: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_Brands_ProductDtoid",
                table: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_BlogCategories_pivotid",
                table: "BlogCategories");

            migrationBuilder.DropColumn(
                name: "ProductDtoid",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "pivotid",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "ProductDtoid",
                table: "SmPictures");

            migrationBuilder.DropColumn(
                name: "pivotid",
                table: "SmPictures");

            migrationBuilder.DropColumn(
                name: "pivotid",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "ProductDtoid",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "pivotid",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ProductDtoid",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "pivotid",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductDtoid",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "pivotid",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "pivotid",
                table: "BlogCategories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Until",
                table: "Products",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductDtoid",
                table: "Variants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pivotid",
                table: "Variants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductDtoid",
                table: "SmPictures",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pivotid",
                table: "SmPictures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pivotid",
                table: "Sizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Until",
                table: "Products",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductDtoid",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pivotid",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductDtoid",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pivotid",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductDtoid",
                table: "Brands",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pivotid",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pivotid",
                table: "BlogCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductDtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    author = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    featured = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    name = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    @new = table.Column<bool>(name: "new", type: "tinyint(1)", nullable: true),
                    price = table.Column<double>(type: "double", nullable: false),
                    ratings = table.Column<int>(type: "int", nullable: false),
                    review = table.Column<int>(type: "int", nullable: false),
                    sale_price = table.Column<double>(type: "double", nullable: true),
                    short_desc = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slug = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sold = table.Column<int>(type: "int", nullable: true),
                    stock = table.Column<int>(type: "int", nullable: false),
                    top = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    until = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDtos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Variants_pivotid",
                table: "Variants",
                column: "pivotid");

            migrationBuilder.CreateIndex(
                name: "IX_Variants_ProductDtoid",
                table: "Variants",
                column: "ProductDtoid");

            migrationBuilder.CreateIndex(
                name: "IX_SmPictures_pivotid",
                table: "SmPictures",
                column: "pivotid");

            migrationBuilder.CreateIndex(
                name: "IX_SmPictures_ProductDtoid",
                table: "SmPictures",
                column: "ProductDtoid");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_pivotid",
                table: "Sizes",
                column: "pivotid");

            migrationBuilder.CreateIndex(
                name: "IX_Images_pivotid",
                table: "Images",
                column: "pivotid");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductDtoid",
                table: "Images",
                column: "ProductDtoid");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_pivotid",
                table: "Categories",
                column: "pivotid");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductDtoid",
                table: "Categories",
                column: "ProductDtoid");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_pivotid",
                table: "Brands",
                column: "pivotid");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_ProductDtoid",
                table: "Brands",
                column: "ProductDtoid");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategories_pivotid",
                table: "BlogCategories",
                column: "pivotid");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategories_Pivots_pivotid",
                table: "BlogCategories",
                column: "pivotid",
                principalTable: "Pivots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Pivots_pivotid",
                table: "Brands",
                column: "pivotid",
                principalTable: "Pivots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_ProductDtos_ProductDtoid",
                table: "Brands",
                column: "ProductDtoid",
                principalTable: "ProductDtos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Pivots_pivotid",
                table: "Categories",
                column: "pivotid",
                principalTable: "Pivots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_ProductDtos_ProductDtoid",
                table: "Categories",
                column: "ProductDtoid",
                principalTable: "ProductDtos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Pivots_pivotid",
                table: "Images",
                column: "pivotid",
                principalTable: "Pivots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_ProductDtos_ProductDtoid",
                table: "Images",
                column: "ProductDtoid",
                principalTable: "ProductDtos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_Pivots_pivotid",
                table: "Sizes",
                column: "pivotid",
                principalTable: "Pivots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SmPictures_Pivots_pivotid",
                table: "SmPictures",
                column: "pivotid",
                principalTable: "Pivots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SmPictures_ProductDtos_ProductDtoid",
                table: "SmPictures",
                column: "ProductDtoid",
                principalTable: "ProductDtos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_Pivots_pivotid",
                table: "Variants",
                column: "pivotid",
                principalTable: "Pivots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_ProductDtos_ProductDtoid",
                table: "Variants",
                column: "ProductDtoid",
                principalTable: "ProductDtos",
                principalColumn: "id");
        }
    }
}
