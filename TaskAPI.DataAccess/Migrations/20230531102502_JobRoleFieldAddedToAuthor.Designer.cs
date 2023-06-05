﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20230531102502_JobRoleFieldAddedToAuthor")]
    partial class JobRoleFieldAddedToAuthor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressNo")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("JobRole")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Street")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "96",
                            City = "Weligama",
                            FullName = "Pasindu Dilhan",
                            JobRole = "Developer",
                            Street = "Ihaladeniya"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "96",
                            City = "Weligama",
                            FullName = "shashikala Udeshani",
                            JobRole = "Telecom Eng",
                            Street = "Leelasewana"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "96",
                            City = "Weligama",
                            FullName = "Minura Pabasara",
                            JobRole = "Business Analyst",
                            Street = "Dampewaththa"
                        },
                        new
                        {
                            Id = 4,
                            AddressNo = "96",
                            City = "Weligama",
                            FullName = "Manasa ayasankha",
                            JobRole = "Telecom Eng",
                            Street = "Badullehome"
                        },
                        new
                        {
                            Id = 5,
                            AddressNo = "96",
                            City = "Weligama",
                            FullName = "Naween Ransara",
                            JobRole = "QA Eng",
                            Street = "Koswatta"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2023, 5, 31, 15, 55, 1, 985, DateTimeKind.Local).AddTicks(309),
                            Description = "Get some text books for school",
                            Due = new DateTime(2023, 6, 5, 15, 55, 1, 986, DateTimeKind.Local).AddTicks(4331),
                            Status = 0,
                            Title = "Get books for school from DB"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Created = new DateTime(2023, 5, 31, 15, 55, 1, 986, DateTimeKind.Local).AddTicks(5065),
                            Description = "Get some bags for school",
                            Due = new DateTime(2023, 6, 2, 15, 55, 1, 986, DateTimeKind.Local).AddTicks(5069),
                            Status = 1,
                            Title = "Get Bags for school"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Created = new DateTime(2023, 5, 31, 15, 55, 1, 986, DateTimeKind.Local).AddTicks(5076),
                            Description = "Get some shoes for school",
                            Due = new DateTime(2023, 6, 5, 15, 55, 1, 986, DateTimeKind.Local).AddTicks(5077),
                            Status = 0,
                            Title = "Get Shoes for school"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
