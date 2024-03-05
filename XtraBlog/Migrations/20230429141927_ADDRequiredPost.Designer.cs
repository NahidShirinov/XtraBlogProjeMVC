﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XtraBlog.DAL;

#nullable disable

namespace XtraBlog.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230429141927_ADDRequiredPost")]
    partial class ADDRequiredPost
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("XtraBlog.Model.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Craeateat")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostID");

                    b.ToTable("Comment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Heri seni",
                            Craeateat = new DateTime(2023, 4, 29, 18, 19, 26, 896, DateTimeKind.Local).AddTicks(6177),
                            Name = "Nahid",
                            PostID = 1
                        },
                        new
                        {
                            Id = 2,
                            Comment = "reyiz",
                            Craeateat = new DateTime(2023, 4, 29, 18, 19, 26, 896, DateTimeKind.Local).AddTicks(6182),
                            Name = "Revan",
                            PostID = 1
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Pak",
                            Craeateat = new DateTime(2023, 4, 29, 18, 19, 26, 896, DateTimeKind.Local).AddTicks(6184),
                            Name = "Revan",
                            PostID = 2
                        });
                });

            modelBuilder.Entity("XtraBlog.Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Created_By")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_By = "Nahid Shirinov",
                            Date = new DateTime(2023, 4, 29, 18, 19, 26, 896, DateTimeKind.Local).AddTicks(5574),
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                            Image = "img-01.jpg",
                            Slug = "c4d8663c-c5e7-48a8-837e-aa4ea2fe4c01",
                            Title = "You can also have an image"
                        },
                        new
                        {
                            Id = 2,
                            Created_By = "Nahid Sirinov",
                            Date = new DateTime(2023, 5, 9, 18, 19, 26, 896, DateTimeKind.Local).AddTicks(5585),
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                            Image = "img-02.jpg",
                            Slug = "5660e381-87f2-43c5-bb28-61cec4aa7887",
                            Title = "He qaqa, ele mi olufff"
                        });
                });

            modelBuilder.Entity("XtraBlog.Model.TagPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PostID")
                        .HasColumnType("int");

                    b.Property<int>("TagsID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostID");

                    b.HasIndex("TagsID");

                    b.ToTable("TagPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PostID = 1,
                            TagsID = 1
                        },
                        new
                        {
                            Id = 2,
                            PostID = 2,
                            TagsID = 2
                        },
                        new
                        {
                            Id = 3,
                            PostID = 2,
                            TagsID = 4
                        },
                        new
                        {
                            Id = 4,
                            PostID = 2,
                            TagsID = 3
                        });
                });

            modelBuilder.Entity("XtraBlog.Model.Tags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tag");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Siyaset"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Idman"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Blog"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hava"
                        });
                });

            modelBuilder.Entity("XtraBlog.Model.Comments", b =>
                {
                    b.HasOne("XtraBlog.Model.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("XtraBlog.Model.TagPost", b =>
                {
                    b.HasOne("XtraBlog.Model.Post", "Post")
                        .WithMany("TagPost")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XtraBlog.Model.Tags", "Tags")
                        .WithMany("TagPost")
                        .HasForeignKey("TagsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("XtraBlog.Model.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("TagPost");
                });

            modelBuilder.Entity("XtraBlog.Model.Tags", b =>
                {
                    b.Navigation("TagPost");
                });
#pragma warning restore 612, 618
        }
    }
}