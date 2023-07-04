﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sudokuData;

#nullable disable

namespace sudokuData.Migrations
{
    [DbContext(typeof(GrilleDbContext))]
    partial class GrilleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Grilles.Models.GrilleData.Case", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Contenu")
                        .HasColumnType("int");

                    b.Property<int?>("LigneId")
                        .HasColumnType("int");

                    b.Property<int>("Num_Block")
                        .HasColumnType("int");

                    b.Property<int>("Num_Colonne")
                        .HasColumnType("int");

                    b.Property<int>("Num_Rangee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LigneId");

                    b.ToTable("cases");
                });

            modelBuilder.Entity("Grilles.Models.GrilleData.Grille", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("grilles");
                });

            modelBuilder.Entity("Grilles.Models.GrilleData.Ligne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GrilleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GrilleId");

                    b.ToTable("rangees");
                });

            modelBuilder.Entity("Grilles.Models.GrilleData.Case", b =>
                {
                    b.HasOne("Grilles.Models.GrilleData.Ligne", null)
                        .WithMany("Cases")
                        .HasForeignKey("LigneId");
                });

            modelBuilder.Entity("Grilles.Models.GrilleData.Ligne", b =>
                {
                    b.HasOne("Grilles.Models.GrilleData.Grille", null)
                        .WithMany("Rangees")
                        .HasForeignKey("GrilleId");
                });

            modelBuilder.Entity("Grilles.Models.GrilleData.Grille", b =>
                {
                    b.Navigation("Rangees");
                });

            modelBuilder.Entity("Grilles.Models.GrilleData.Ligne", b =>
                {
                    b.Navigation("Cases");
                });
#pragma warning restore 612, 618
        }
    }
}
