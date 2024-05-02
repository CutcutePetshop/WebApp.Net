using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetshopWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_REVIEW_TB_PETSHOP_id_petshop",
                table: "TB_REVIEW");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_REVIEW_TB_PRODUCT_id_product",
                table: "TB_REVIEW");

            migrationBuilder.CreateIndex(
                name: "IX_TB_REVIEW_UserId",
                table: "TB_REVIEW",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_REVIEW_TB_PETSHOP_id_petshop",
                table: "TB_REVIEW",
                column: "id_petshop",
                principalTable: "TB_PETSHOP",
                principalColumn: "id_petshop",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_REVIEW_TB_PRODUCT_id_product",
                table: "TB_REVIEW",
                column: "id_product",
                principalTable: "TB_PRODUCT",
                principalColumn: "id_product",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_REVIEW_TB_USER_UserId",
                table: "TB_REVIEW",
                column: "UserId",
                principalTable: "TB_USER",
                principalColumn: "id_user",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_REVIEW_TB_PETSHOP_id_petshop",
                table: "TB_REVIEW");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_REVIEW_TB_PRODUCT_id_product",
                table: "TB_REVIEW");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_REVIEW_TB_USER_UserId",
                table: "TB_REVIEW");

            migrationBuilder.DropIndex(
                name: "IX_TB_REVIEW_UserId",
                table: "TB_REVIEW");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_REVIEW_TB_PETSHOP_id_petshop",
                table: "TB_REVIEW",
                column: "id_petshop",
                principalTable: "TB_PETSHOP",
                principalColumn: "id_petshop");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_REVIEW_TB_PRODUCT_id_product",
                table: "TB_REVIEW",
                column: "id_product",
                principalTable: "TB_PRODUCT",
                principalColumn: "id_product");
        }
    }
}
