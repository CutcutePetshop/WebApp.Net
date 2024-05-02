﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using PetshopWebApp.Persistence;

#nullable disable

namespace PetshopWebApp.Migrations
{
    [DbContext(typeof(OracleDbContext))]
    partial class OracleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetshopWebApp.Models.Pet", b =>
                {
                    b.Property<int>("IdPet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("id_pet");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPet"));

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("DATE")
                        .HasColumnName("dt_birthday");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("ds_pet");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("ds_img_path");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("nm_pet");

                    b.Property<int>("PetshopId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("id_petshop");

                    b.Property<string>("Port")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("ds_port");

                    b.Property<string>("Race")
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("ds_race");

                    b.Property<string>("Sex")
                        .HasMaxLength(1)
                        .HasColumnType("VARCHAR(1)")
                        .HasColumnName("ds_sex");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("ds_species");

                    b.Property<decimal?>("Weight")
                        .HasPrecision(5, 2)
                        .HasColumnType("NUMBER(5, 2)")
                        .HasColumnName("nr_weight");

                    b.HasKey("IdPet");

                    b.HasIndex("PetshopId");

                    b.ToTable("TB_PET");
                });

            modelBuilder.Entity("PetshopWebApp.Models.Petshop", b =>
                {
                    b.Property<int>("IdPetshop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("id_petshop");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPetshop"));

                    b.Property<string>("Cep")
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("ds_cep");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("nm_petshop");

                    b.Property<decimal>("Rating")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("nr_rating");

                    b.HasKey("IdPetshop");

                    b.ToTable("TB_PETSHOP");
                });

            modelBuilder.Entity("PetshopWebApp.Models.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("id_product");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduct"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("ds_product");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("nm_product");

                    b.Property<int>("PetshopId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("id_petshop");

                    b.Property<decimal>("Price")
                        .HasPrecision(7, 2)
                        .HasColumnType("NUMBER(7, 2)")
                        .HasColumnName("vl_product");

                    b.Property<decimal>("Rating")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("nr_rating");

                    b.HasKey("IdProduct");

                    b.HasIndex("PetshopId");

                    b.ToTable("TB_PRODUCT");
                });

            modelBuilder.Entity("PetshopWebApp.Models.Review", b =>
                {
                    b.Property<int>("IdReview")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("id_review");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReview"));

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("DATE")
                        .HasColumnName("dt_published");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("ds_review");

                    b.Property<int?>("PetshopId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("id_petshop");

                    b.Property<int?>("ProductId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("id_product");

                    b.Property<decimal>("Stars")
                        .HasColumnType("NUMBER")
                        .HasColumnName("qt_stars");

                    b.Property<int>("UserId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("IdReview");

                    b.HasIndex("PetshopId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("TB_REVIEW");
                });

            modelBuilder.Entity("PetshopWebApp.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("id_user");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("DATE")
                        .HasColumnName("dt_birthday");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)")
                        .HasColumnName("ds_cpf");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("ds_user");

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(80)")
                        .HasColumnName("ds_email");

                    b.Property<string>("Gender")
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("ds_gender");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("ds_img_path");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("nm_user");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("ds_password");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("ds_phonenumber");

                    b.HasKey("IdUser");

                    b.ToTable("TB_USER");
                });

            modelBuilder.Entity("PetshopWebApp.Models.Pet", b =>
                {
                    b.HasOne("PetshopWebApp.Models.Petshop", "Petshop")
                        .WithMany("Pets")
                        .HasForeignKey("PetshopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Petshop");
                });

            modelBuilder.Entity("PetshopWebApp.Models.Product", b =>
                {
                    b.HasOne("PetshopWebApp.Models.Petshop", "Petshop")
                        .WithMany("Products")
                        .HasForeignKey("PetshopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Petshop");
                });

            modelBuilder.Entity("PetshopWebApp.Models.Review", b =>
                {
                    b.HasOne("PetshopWebApp.Models.Petshop", "Petshop")
                        .WithMany("Reviews")
                        .HasForeignKey("PetshopId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PetshopWebApp.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PetshopWebApp.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Petshop");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PetshopWebApp.Models.Petshop", b =>
                {
                    b.Navigation("Pets");

                    b.Navigation("Products");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("PetshopWebApp.Models.Product", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("PetshopWebApp.Models.User", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
