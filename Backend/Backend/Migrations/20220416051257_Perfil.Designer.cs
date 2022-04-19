﻿// <auto-generated />
using System;
using Backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220416051257_Perfil")]
    partial class Perfil
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Backend.Models.Empresa", b =>
                {
                    b.Property<string>("Nit")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=150");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar=9");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("varchar=5");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.Property<string>("Nrc")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("varchar=17");

                    b.Property<string>("PerfilId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Representante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.Property<int?>("Rubro")
                        .IsRequired()
                        .HasColumnType("varchar=100");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar=9");

                    b.Property<string>("TelefonoMovil")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar=9");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.HasKey("Nit");

                    b.HasIndex("PerfilId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Backend.Models.Perfil", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Calificacion")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar=1");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.Property<bool>("Sucursal")
                        .HasColumnType("bit");

                    b.Property<string>("escrituras")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.HasKey("Id");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("Backend.Models.Empresa", b =>
                {
                    b.HasOne("Backend.Models.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId");

                    b.Navigation("Perfil");
                });
#pragma warning restore 612, 618
        }
    }
}