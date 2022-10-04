using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wazyApi.Models.migrations
{
    public partial class newschehhjmjjje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Blogs_BlogId",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "Images",
                newName: "ProductDtoid");

            migrationBuilder.RenameIndex(
                name: "IX_Images_BlogId",
                table: "Images",
                newName: "IX_Images_ProductDtoid");

            migrationBuilder.AlterColumn<double>(
                name: "price",
                table: "Variants",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProductDtoid",
                table: "Variants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductDtoid",
                table: "SmPictures",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Products",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ProductDtoid",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductDtoid",
                table: "Brands",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductDtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slug = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    short_desc = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<double>(type: "double", nullable: false),
                    sale_price = table.Column<double>(type: "double", nullable: true),
                    review = table.Column<int>(type: "int", nullable: false),
                    ratings = table.Column<int>(type: "int", nullable: false),
                    until = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    stock = table.Column<int>(type: "int", nullable: false),
                    top = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    featured = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    @new = table.Column<bool>(name: "new", type: "tinyint(1)", nullable: true),
                    author = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sold = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDtos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Variants_ProductDtoid",
                table: "Variants",
                column: "ProductDtoid");

            migrationBuilder.CreateIndex(
                name: "IX_SmPictures_ProductDtoid",
                table: "SmPictures",
                column: "ProductDtoid");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductDtoid",
                table: "Categories",
                column: "ProductDtoid");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_ProductDtoid",
                table: "Brands",
                column: "ProductDtoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_ProductDtos_ProductDtoid",
                table: "Brands",
                column: "ProductDtoid",
                principalTable: "ProductDtos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_ProductDtos_ProductDtoid",
                table: "Categories",
                column: "ProductDtoid",
                principalTable: "ProductDtos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_ProductDtos_ProductDtoid",
                table: "Images",
                column: "ProductDtoid",
                principalTable: "ProductDtos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SmPictures_ProductDtos_ProductDtoid",
                table: "SmPictures",
                column: "ProductDtoid",
                principalTable: "ProductDtos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_ProductDtos_ProductDtoid",
                table: "Variants",
                column: "ProductDtoid",
                principalTable: "ProductDtos",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_ProductDtos_ProductDtoid",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_ProductDtos_ProductDtoid",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_ProductDtos_ProductDtoid",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_SmPictures_ProductDtos_ProductDtoid",
                table: "SmPictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Variants_ProductDtos_ProductDtoid",
                table: "Variants");

            migrationBuilder.DropTable(
                name: "ProductDtos");

            migrationBuilder.DropIndex(
                name: "IX_Variants_ProductDtoid",
                table: "Variants");

            migrationBuilder.DropIndex(
                name: "IX_SmPictures_ProductDtoid",
                table: "SmPictures");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ProductDtoid",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Brands_ProductDtoid",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "ProductDtoid",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "ProductDtoid",
                table: "SmPictures");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDtoid",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductDtoid",
                table: "Brands");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "ProductDtoid",
                table: "Images",
                newName: "BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ProductDtoid",
                table: "Images",
                newName: "IX_Images_BlogId");

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "Variants",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Blogs_BlogId",
                table: "Images",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id");
        }
    }
}
