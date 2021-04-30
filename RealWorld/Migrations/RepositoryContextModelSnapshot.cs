﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RealWorld.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Entities.Models.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Body")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Slug")
                        .HasColumnType("text");

                    b.Property<string[]>("TagList")
                        .HasColumnType("text[]");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Article");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            AuthorId = new Guid("c9d4c012-49b6-410c-bc78-2d54a9991870"),
                            Body = "Article 1 body",
                            CreatedAt = new DateTimeOffset(new DateTime(2021, 4, 30, 3, 29, 9, 395, DateTimeKind.Unspecified).AddTicks(562), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Article 1 description",
                            Slug = "article / 1",
                            TagList = new[] { "Tag1", "Tag2" },
                            Title = "Article 1",
                            UpdatedAt = new DateTimeOffset(new DateTime(2021, 4, 30, 3, 29, 9, 395, DateTimeKind.Unspecified).AddTicks(773), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            AuthorId = new Guid("c9d4c013-49b6-410c-bc78-2d54a9991870"),
                            Body = "Article 2 body",
                            CreatedAt = new DateTimeOffset(new DateTime(2021, 4, 30, 3, 29, 9, 395, DateTimeKind.Unspecified).AddTicks(1661), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Article 2 description",
                            Slug = "article / 2",
                            TagList = new[] { "Tag3", "Tag4" },
                            Title = "Article 2",
                            UpdatedAt = new DateTimeOffset(new DateTime(2021, 4, 30, 3, 29, 9, 395, DateTimeKind.Unspecified).AddTicks(1663), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("Entities.Models.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Bio")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c012-49b6-410c-bc78-2d54a9991870"),
                            Bio = "Software Developer",
                            Image = "unspash.com",
                            Username = "AliAhmed"
                        },
                        new
                        {
                            Id = new Guid("c9d4c013-49b6-410c-bc78-2d54a9991870"),
                            Bio = "Scheduling Coordinator",
                            Image = "unspash.com",
                            Username = "SamrahAkber"
                        });
                });

            modelBuilder.Entity("Entities.Models.Article", b =>
                {
                    b.HasOne("Entities.Models.Author", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Entities.Models.Author", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
