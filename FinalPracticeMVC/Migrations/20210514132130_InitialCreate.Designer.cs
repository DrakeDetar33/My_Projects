﻿// <auto-generated />
using FinalPracticeMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalPracticeMVC.Migrations
{
    [DbContext(typeof(FinalPracticeMVCContext))]
    [Migration("20210514132130_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalPracticeMVC.Models.Protein", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Animal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Calories")
                        .HasColumnType("float");

                    b.Property<double>("FatTot")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProteinTot")
                        .HasColumnType("float");

                    b.Property<int>("ServingSize")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Protein");
                });
#pragma warning restore 612, 618
        }
    }
}
