﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pjDataAccess;

namespace pjDataAccess.Migrations
{
    [DbContext(typeof(KitchenContext))]
    [Migration("20210305162145_InitialDB1")]
    partial class InitialDB1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("pjModels.Recipe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("WriteID")
                        .HasColumnType("int");

                    b.Property<int?>("Writerid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Writerid");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("pjModels.Writer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("id");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("pjModels.Recipe", b =>
                {
                    b.HasOne("pjModels.Writer", "Writer")
                        .WithMany("Recipes")
                        .HasForeignKey("Writerid");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("pjModels.Writer", b =>
                {
                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
