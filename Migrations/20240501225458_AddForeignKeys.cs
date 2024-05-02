using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetshopWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "TB_REVIEW",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_petshop",
                table: "TB_REVIEW",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_product",
                table: "TB_REVIEW",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_petshop",
                table: "TB_PRODUCT",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "nr_rating",
                table: "TB_PRODUCT",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "nr_rating",
                table: "TB_PETSHOP",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "id_petshop",
                table: "TB_PET",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TB_REVIEW_id_petshop",
                table: "TB_REVIEW",
                column: "id_petshop");

            migrationBuilder.CreateIndex(
                name: "IX_TB_REVIEW_id_product",
                table: "TB_REVIEW",
                column: "id_product");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUCT_id_petshop",
                table: "TB_PRODUCT",
                column: "id_petshop");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PET_id_petshop",
                table: "TB_PET",
                column: "id_petshop");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PET_TB_PETSHOP_id_petshop",
                table: "TB_PET",
                column: "id_petshop",
                principalTable: "TB_PETSHOP",
                principalColumn: "id_petshop",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCT_TB_PETSHOP_id_petshop",
                table: "TB_PRODUCT",
                column: "id_petshop",
                principalTable: "TB_PETSHOP",
                principalColumn: "id_petshop",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PET_TB_PETSHOP_id_petshop",
                table: "TB_PET");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCT_TB_PETSHOP_id_petshop",
                table: "TB_PRODUCT");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_REVIEW_TB_PETSHOP_id_petshop",
                table: "TB_REVIEW");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_REVIEW_TB_PRODUCT_id_product",
                table: "TB_REVIEW");

            migrationBuilder.DropIndex(
                name: "IX_TB_REVIEW_id_petshop",
                table: "TB_REVIEW");

            migrationBuilder.DropIndex(
                name: "IX_TB_REVIEW_id_product",
                table: "TB_REVIEW");

            migrationBuilder.DropIndex(
                name: "IX_TB_PRODUCT_id_petshop",
                table: "TB_PRODUCT");

            migrationBuilder.DropIndex(
                name: "IX_TB_PET_id_petshop",
                table: "TB_PET");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TB_REVIEW");

            migrationBuilder.DropColumn(
                name: "id_petshop",
                table: "TB_REVIEW");

            migrationBuilder.DropColumn(
                name: "id_product",
                table: "TB_REVIEW");

            migrationBuilder.DropColumn(
                name: "id_petshop",
                table: "TB_PRODUCT");

            migrationBuilder.DropColumn(
                name: "nr_rating",
                table: "TB_PRODUCT");

            migrationBuilder.DropColumn(
                name: "nr_rating",
                table: "TB_PETSHOP");

            migrationBuilder.DropColumn(
                name: "id_petshop",
                table: "TB_PET");
        }
    }
}
