﻿// <auto-generated />
using System;
using LibraryAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryAPI.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20240119181732_AddBookTableReferenceToGenreTable")]
    partial class AddBookTableReferenceToGenreTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AvailableCopies")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryAPI.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Literary Fiction, Historical Fiction, Science Fiction (Sci-Fi), Fantasy, Mystery, Thriller, Horror, Romance",
                            GenreName = "Fiction"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Biography/Autobiography, Memoir, Essay, Self-Help, Psychology, Philosophy, History, Travel, Science, True Crime",
                            GenreName = "Non-Fiction"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Narrative Poetry, Lyric Poetry, Haiku",
                            GenreName = "Poetry"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Picture Books, Middle Grade, Young Adult (YA)",
                            GenreName = "Children's and Young Adult"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Tragedy, Comedy, Historical Drama",
                            GenreName = "Drama/Play"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Detective Fiction, Crime Thriller, Psychological Thriller",
                            GenreName = "Mystery/Thriller"
                        },
                        new
                        {
                            Id = 7,
                            Description = " Space Opera, Cyberpunk, Hard Science Fiction",
                            GenreName = "Science Fiction (Sci-Fi)"
                        },
                        new
                        {
                            Id = 8,
                            Description = "High Fantasy, Urban Fantasy, Magical Realism",
                            GenreName = "Fantasy"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Contemporary Romance, Historical Romance, Paranormal Romance",
                            GenreName = "Romance"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Supernatural Horror, Psychological Horror, Gothic Horror",
                            GenreName = "Horror"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Ancient History, Medieval, Renaissance",
                            GenreName = "Historical Fiction"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Action-Adventure, Historical Adventure",
                            GenreName = "Adventure"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Satirical Fiction, Comic Fiction",
                            GenreName = "Satire/Humor"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Superhero Comics, Graphic Memoirs",
                            GenreName = "Graphic Novels/Comics"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Shonen, Shojo, Seinen, Josei",
                            GenreName = "Manga"
                        },
                        new
                        {
                            Id = 16,
                            Description = "Classic Literature",
                            GenreName = "Classics"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Religious Texts, Spiritual Guidance",
                            GenreName = "Religious/Spiritual"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Business Books, Finance and Investing",
                            GenreName = "Business/Finance"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Culinary Non-Fiction",
                            GenreName = "Cookbooks"
                        },
                        new
                        {
                            Id = 20,
                            Description = "Popular Science, Natural History",
                            GenreName = "Science/Nature"
                        });
                });

            modelBuilder.Entity("LibraryAPI.Models.Book", b =>
                {
                    b.HasOne("LibraryAPI.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
