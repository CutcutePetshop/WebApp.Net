using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetshopWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_PET",
                columns: table => new
                {
                    id_pet = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nm_pet = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    ds_pet = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    ds_species = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    ds_race = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    ds_sex = table.Column<string>(type: "VARCHAR(1)", maxLength: 1, nullable: true),
                    dt_birthday = table.Column<DateTime>(type: "DATE", nullable: true),
                    ds_port = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    nr_weight = table.Column<decimal>(type: "NUMBER(5,2)", precision: 5, scale: 2, nullable: true),
                    ds_img_path = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PET", x => x.id_pet);
                });

            migrationBuilder.CreateTable(
                name: "TB_PETSHOP",
                columns: table => new
                {
                    id_petshop = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nm_petshop = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    ds_cep = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PETSHOP", x => x.id_petshop);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRODUCT",
                columns: table => new
                {
                    id_product = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nm_product = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    ds_product = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    vl_product = table.Column<decimal>(type: "NUMBER(7,2)", precision: 7, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUCT", x => x.id_product);
                });

            migrationBuilder.CreateTable(
                name: "TB_REVIEW",
                columns: table => new
                {
                    id_review = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    qt_stars = table.Column<decimal>(type: "NUMBER", nullable: false),
                    ds_review = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    dt_published = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_REVIEW", x => x.id_review);
                });

            migrationBuilder.CreateTable(
                name: "TB_USER",
                columns: table => new
                {
                    id_user = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nm_user = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    ds_password = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    ds_email = table.Column<string>(type: "VARCHAR(80)", nullable: true),
                    ds_user = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    ds_phonenumber = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    ds_cpf = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    dt_birthday = table.Column<DateTime>(type: "DATE", nullable: true),
                    ds_gender = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    ds_img_path = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USER", x => x.id_user);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PET");

            migrationBuilder.DropTable(
                name: "TB_PETSHOP");

            migrationBuilder.DropTable(
                name: "TB_PRODUCT");

            migrationBuilder.DropTable(
                name: "TB_REVIEW");

            migrationBuilder.DropTable(
                name: "TB_USER");
        }
    }
}
