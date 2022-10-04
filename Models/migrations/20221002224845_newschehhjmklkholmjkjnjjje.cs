using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wazyApi.Models.migrations
{
    public partial class newschehhjmklkholmjkjnjjje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategories_Blogs_BlogId",
                table: "BlogCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategories_Pivots_pivotId",
                table: "BlogCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Pivots_pivotId",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Products_ProductId",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Pivots_pivotId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Products_ProductId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Pivots_pivotId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_Pivots_pivotId",
                table: "Sizes");

            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_Variants_VariantId",
                table: "Sizes");

            migrationBuilder.DropForeignKey(
                name: "FK_SmPictures_Pivots_pivotId",
                table: "SmPictures");

            migrationBuilder.DropForeignKey(
                name: "FK_SmPictures_Products_ProductId",
                table: "SmPictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Variants_Pivots_pivotId",
                table: "Variants");

            migrationBuilder.DropForeignKey(
                name: "FK_Variants_Products_ProductId",
                table: "Variants");

            migrationBuilder.RenameColumn(
                name: "pivotId",
                table: "Variants",
                newName: "pivotid");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Variants",
                newName: "Productid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Variants",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Variants_ProductId",
                table: "Variants",
                newName: "IX_Variants_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_Variants_pivotId",
                table: "Variants",
                newName: "IX_Variants_pivotid");

            migrationBuilder.RenameColumn(
                name: "pivotId",
                table: "SmPictures",
                newName: "pivotid");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "SmPictures",
                newName: "Productid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SmPictures",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_SmPictures_ProductId",
                table: "SmPictures",
                newName: "IX_SmPictures_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_SmPictures_pivotId",
                table: "SmPictures",
                newName: "IX_SmPictures_pivotid");

            migrationBuilder.RenameColumn(
                name: "pivotId",
                table: "Sizes",
                newName: "pivotid");

            migrationBuilder.RenameColumn(
                name: "VariantId",
                table: "Sizes",
                newName: "Variantid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sizes",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Sizes_VariantId",
                table: "Sizes",
                newName: "IX_Sizes_Variantid");

            migrationBuilder.RenameIndex(
                name: "IX_Sizes_pivotId",
                table: "Sizes",
                newName: "IX_Sizes_pivotid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pivots",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "pivotId",
                table: "Images",
                newName: "pivotid");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Images",
                newName: "Productid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Images",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                newName: "IX_Images_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_Images_pivotId",
                table: "Images",
                newName: "IX_Images_pivotid");

            migrationBuilder.RenameColumn(
                name: "pivotId",
                table: "Categories",
                newName: "pivotid");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Categories",
                newName: "Productid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_ProductId",
                table: "Categories",
                newName: "IX_Categories_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_pivotId",
                table: "Categories",
                newName: "IX_Categories_pivotid");

            migrationBuilder.RenameColumn(
                name: "pivotId",
                table: "Brands",
                newName: "pivotid");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Brands",
                newName: "Productid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Brands",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Brands_ProductId",
                table: "Brands",
                newName: "IX_Brands_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_Brands_pivotId",
                table: "Brands",
                newName: "IX_Brands_pivotid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Blogs",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "pivotId",
                table: "BlogCategories",
                newName: "pivotid");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "BlogCategories",
                newName: "Blogid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BlogCategories",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_BlogCategories_pivotId",
                table: "BlogCategories",
                newName: "IX_BlogCategories_pivotid");

            migrationBuilder.RenameIndex(
                name: "IX_BlogCategories_BlogId",
                table: "BlogCategories",
                newName: "IX_BlogCategories_Blogid");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategories_Blogs_Blogid",
                table: "BlogCategories",
                column: "Blogid",
                principalTable: "Blogs",
                principalColumn: "id");

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
                name: "FK_Brands_Products_Productid",
                table: "Brands",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Pivots_pivotid",
                table: "Categories",
                column: "pivotid",
                principalTable: "Pivots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Products_Productid",
                table: "Categories",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Pivots_pivotid",
                table: "Images",
                column: "pivotid",
                principalTable: "Pivots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_Productid",
                table: "Images",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_Pivots_pivotid",
                table: "Sizes",
                column: "pivotid",
                principalTable: "Pivots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_Variants_Variantid",
                table: "Sizes",
                column: "Variantid",
                principalTable: "Variants",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SmPictures_Pivots_pivotid",
                table: "SmPictures",
                column: "pivotid",
                principalTable: "Pivots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SmPictures_Products_Productid",
                table: "SmPictures",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_Pivots_pivotid",
                table: "Variants",
                column: "pivotid",
                principalTable: "Pivots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_Products_Productid",
                table: "Variants",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategories_Blogs_Blogid",
                table: "BlogCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategories_Pivots_pivotid",
                table: "BlogCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Pivots_pivotid",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Products_Productid",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Pivots_pivotid",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Products_Productid",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Pivots_pivotid",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_Productid",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_Pivots_pivotid",
                table: "Sizes");

            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_Variants_Variantid",
                table: "Sizes");

            migrationBuilder.DropForeignKey(
                name: "FK_SmPictures_Pivots_pivotid",
                table: "SmPictures");

            migrationBuilder.DropForeignKey(
                name: "FK_SmPictures_Products_Productid",
                table: "SmPictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Variants_Pivots_pivotid",
                table: "Variants");

            migrationBuilder.DropForeignKey(
                name: "FK_Variants_Products_Productid",
                table: "Variants");

            migrationBuilder.RenameColumn(
                name: "pivotid",
                table: "Variants",
                newName: "pivotId");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "Variants",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Variants",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Variants_Productid",
                table: "Variants",
                newName: "IX_Variants_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Variants_pivotid",
                table: "Variants",
                newName: "IX_Variants_pivotId");

            migrationBuilder.RenameColumn(
                name: "pivotid",
                table: "SmPictures",
                newName: "pivotId");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "SmPictures",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "SmPictures",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_SmPictures_Productid",
                table: "SmPictures",
                newName: "IX_SmPictures_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_SmPictures_pivotid",
                table: "SmPictures",
                newName: "IX_SmPictures_pivotId");

            migrationBuilder.RenameColumn(
                name: "pivotid",
                table: "Sizes",
                newName: "pivotId");

            migrationBuilder.RenameColumn(
                name: "Variantid",
                table: "Sizes",
                newName: "VariantId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Sizes",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Sizes_Variantid",
                table: "Sizes",
                newName: "IX_Sizes_VariantId");

            migrationBuilder.RenameIndex(
                name: "IX_Sizes_pivotid",
                table: "Sizes",
                newName: "IX_Sizes_pivotId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Pivots",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "pivotid",
                table: "Images",
                newName: "pivotId");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "Images",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Images",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Images_Productid",
                table: "Images",
                newName: "IX_Images_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_pivotid",
                table: "Images",
                newName: "IX_Images_pivotId");

            migrationBuilder.RenameColumn(
                name: "pivotid",
                table: "Categories",
                newName: "pivotId");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "Categories",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_Productid",
                table: "Categories",
                newName: "IX_Categories_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_pivotid",
                table: "Categories",
                newName: "IX_Categories_pivotId");

            migrationBuilder.RenameColumn(
                name: "pivotid",
                table: "Brands",
                newName: "pivotId");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "Brands",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Brands",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Brands_Productid",
                table: "Brands",
                newName: "IX_Brands_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Brands_pivotid",
                table: "Brands",
                newName: "IX_Brands_pivotId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Blogs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "pivotid",
                table: "BlogCategories",
                newName: "pivotId");

            migrationBuilder.RenameColumn(
                name: "Blogid",
                table: "BlogCategories",
                newName: "BlogId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "BlogCategories",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_BlogCategories_pivotid",
                table: "BlogCategories",
                newName: "IX_BlogCategories_pivotId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogCategories_Blogid",
                table: "BlogCategories",
                newName: "IX_BlogCategories_BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategories_Blogs_BlogId",
                table: "BlogCategories",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategories_Pivots_pivotId",
                table: "BlogCategories",
                column: "pivotId",
                principalTable: "Pivots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Pivots_pivotId",
                table: "Brands",
                column: "pivotId",
                principalTable: "Pivots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Products_ProductId",
                table: "Brands",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Pivots_pivotId",
                table: "Categories",
                column: "pivotId",
                principalTable: "Pivots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Products_ProductId",
                table: "Categories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Pivots_pivotId",
                table: "Images",
                column: "pivotId",
                principalTable: "Pivots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_Pivots_pivotId",
                table: "Sizes",
                column: "pivotId",
                principalTable: "Pivots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_Variants_VariantId",
                table: "Sizes",
                column: "VariantId",
                principalTable: "Variants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SmPictures_Pivots_pivotId",
                table: "SmPictures",
                column: "pivotId",
                principalTable: "Pivots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SmPictures_Products_ProductId",
                table: "SmPictures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_Pivots_pivotId",
                table: "Variants",
                column: "pivotId",
                principalTable: "Pivots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_Products_ProductId",
                table: "Variants",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
