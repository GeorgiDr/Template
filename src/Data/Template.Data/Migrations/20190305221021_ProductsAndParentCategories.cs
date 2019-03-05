using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Data.Migrations
{
    public partial class ProductsAndParentCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ParentCategorys_ParentCategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParentCategorys",
                table: "ParentCategorys");

            migrationBuilder.RenameTable(
                name: "ParentCategorys",
                newName: "ParentCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParentCategories",
                table: "ParentCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ParentCategories_ParentCategoryId",
                table: "Products",
                column: "ParentCategoryId",
                principalTable: "ParentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ParentCategories_ParentCategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParentCategories",
                table: "ParentCategories");

            migrationBuilder.RenameTable(
                name: "ParentCategories",
                newName: "ParentCategorys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParentCategorys",
                table: "ParentCategorys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ParentCategorys_ParentCategoryId",
                table: "Products",
                column: "ParentCategoryId",
                principalTable: "ParentCategorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
