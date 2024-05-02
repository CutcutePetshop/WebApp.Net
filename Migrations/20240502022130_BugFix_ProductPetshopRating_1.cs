using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetshopWebApp.Migrations
{
    /// <inheritdoc />
    public partial class BugFix_ProductPetshopRating_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "nr_rating",
                table: "TB_PRODUCT",
                type: "NUMBER(2,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "nr_rating",
                table: "TB_PETSHOP",
                type: "NUMBER(2,1)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nr_rating",
                table: "TB_PRODUCT");

            migrationBuilder.DropColumn(
                name: "nr_rating",
                table: "TB_PETSHOP");
        }
    }
}
