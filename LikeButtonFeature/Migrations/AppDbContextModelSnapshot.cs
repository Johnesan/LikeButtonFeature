﻿// <auto-generated />
using System;
using LikeButtonFeature.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LikeButtonFeature.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LikeButtonFeature.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2020, 12, 4, 10, 30, 59, 38, DateTimeKind.Local).AddTicks(8363),
                            Message = "Message One",
                            Title = "Article One"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2020, 12, 4, 10, 30, 59, 39, DateTimeKind.Local).AddTicks(647),
                            Message = "Message Two",
                            Title = "Article Two"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2020, 12, 4, 10, 30, 59, 39, DateTimeKind.Local).AddTicks(681),
                            Message = "Message Three",
                            Title = "Article Three"
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2020, 12, 4, 10, 30, 59, 39, DateTimeKind.Local).AddTicks(687),
                            Message = "Message Four",
                            Title = "Article Four"
                        });
                });

            modelBuilder.Entity("LikeButtonFeature.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId");

                    b.HasIndex("ArticleId", "UserId")
                        .IsUnique();

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("LikeButtonFeature.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2020, 12, 4, 10, 30, 59, 50, DateTimeKind.Local).AddTicks(7399),
                            Username = "User One"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2020, 12, 4, 10, 30, 59, 50, DateTimeKind.Local).AddTicks(7736),
                            Username = "User Two"
                        });
                });

            modelBuilder.Entity("LikeButtonFeature.Models.Like", b =>
                {
                    b.HasOne("LikeButtonFeature.Models.Article", "Article")
                        .WithMany("Likes")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LikeButtonFeature.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LikeButtonFeature.Models.Article", b =>
                {
                    b.Navigation("Likes");
                });
#pragma warning restore 612, 618
        }
    }
}
