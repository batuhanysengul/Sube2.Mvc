﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sube2.EntityApp;

namespace Sube2.EntityApp.Migrations
{
    [DbContext(typeof(OkulContext))]
    [Migration("20220518131538_OgrenciModelGuncelleme")]
    partial class OgrenciModelGuncelleme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sube2.EntityApp.Ogrenci", b =>
                {
                    b.Property<int>("Ogrenciid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Soyad")
                        .HasMaxLength(35)
                        .HasColumnType("varchar(35)");

                    b.HasKey("Ogrenciid");

                    b.ToTable("tblOgrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}
