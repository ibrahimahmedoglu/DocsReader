﻿// <auto-generated />
using DocsReader.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DocsReader.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211020115547_addDocsToDb")]
    partial class addDocsToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DocsReader.Modal.Documents", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefaultDocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentStoreType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Format")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LatestVersionBranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainWebsiteUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinimumVersions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NavigationDocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParametersDocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shortname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}