using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetshopWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Update4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nr_rating",
                table: "TB_PRODUCT");

            migrationBuilder.DropColumn(
                name: "nr_rating",
                table: "TB_PETSHOP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
