﻿// <auto-generated />
using System;
using AspNetBoilerPlate_Demo2.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetBoilerPlate_Demo2.Migrations
{
    [DbContext(typeof(AspNetBoilerPlate_Demo2DbContext))]
    [Migration("20190814110402_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetBoilerPlate_Demo2.Entities.Author", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationTime");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("AspNetBoilerPlate_Demo2.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AuthorId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<DateTime>("PublishedDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("AspNetBoilerPlate_Demo2.Entities.Book", b =>
                {
                    b.HasOne("AspNetBoilerPlate_Demo2.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");
                });
#pragma warning restore 612, 618
        }
    }
}
