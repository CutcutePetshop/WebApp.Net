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
                    IdPet = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PetName = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    PetDescription = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    PetSpecies = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    PetRace = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    PetSex = table.Column<string>(type: "VARCHAR(1)", maxLength: 1, nullable: true),
                    PetBirthday = table.Column<DateTime>(type: "DATE", nullable: true),
                    PetPort = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    PetWeight = table.Column<decimal>(type: "NUMBER(5,2)", precision: 5, scale: 2, nullable: true),
                    PetImagePath = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PET", x => x.IdPet);
                });

            migrationBuilder.CreateTable(
                name: "TB_PETSHOP",
                columns: table => new
                {
                    IdPetshop = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PetshopName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    PetshopCEP = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PETSHOP", x => x.IdPetshop);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRODUCT",
                columns: table => new
                {
                    IdProduct = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ProductDescription = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "NUMBER(7,2)", precision: 7, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUCT", x => x.IdProduct);
                });

            migrationBuilder.CreateTable(
                name: "TB_REVIEW",
                columns: table => new
                {
                    IdReview = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ReviewStars = table.Column<decimal>(type: "NUMBER", nullable: false),
                    ReviewDescription = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    ReviewDatePublished = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_REVIEW", x => x.IdReview);
                });

            migrationBuilder.CreateTable(
                name: "TB_USER",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UserName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    UserPassword = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    UserEmail = table.Column<string>(type: "VARCHAR(80)", nullable: true),
                    UserDescription = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    UserPhoneNumber = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    UserCPF = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    UserBirthday = table.Column<DateTime>(type: "DATE", nullable: true),
                    UserGender = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    UserImagePath = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USER", x => x.IdUser);
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
