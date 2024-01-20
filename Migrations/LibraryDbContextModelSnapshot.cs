﻿// <auto-generated />
using System;
using LibraryAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryAPI.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryAPI.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AvailableCopies")
                        .HasColumnType("int");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

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
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("03de5718-fc5b-47ad-8c8b-a29775a36f04"),
                            Description = "Literary Fiction, Historical Fiction, Science Fiction (Sci-Fi), Fantasy, Mystery, Thriller, Horror, Romance",
                            GenreName = "Fiction"
                        },
                        new
                        {
                            Id = new Guid("f93f529f-61a4-4ca9-9369-57e57fb69897"),
                            Description = "Biography/Autobiography, Memoir, Essay, Self-Help, Psychology, Philosophy, History, Travel, Science, True Crime",
                            GenreName = "Non-Fiction"
                        },
                        new
                        {
                            Id = new Guid("7a9adc97-95a7-4f92-8554-ddfe7365352b"),
                            Description = "Narrative Poetry, Lyric Poetry, Haiku",
                            GenreName = "Poetry"
                        },
                        new
                        {
                            Id = new Guid("034cbe4d-f3ab-43d9-91c1-574704f380f6"),
                            Description = "Picture Books, Middle Grade, Young Adult (YA)",
                            GenreName = "Children's and Young Adult"
                        },
                        new
                        {
                            Id = new Guid("535035d9-0480-4fb3-a13d-58a3e6713252"),
                            Description = "Tragedy, Comedy, Historical Drama",
                            GenreName = "Drama/Play"
                        },
                        new
                        {
                            Id = new Guid("981499f3-f42d-43b0-a838-99979caaf74f"),
                            Description = "Detective Fiction, Crime Thriller, Psychological Thriller",
                            GenreName = "Mystery/Thriller"
                        },
                        new
                        {
                            Id = new Guid("c523a457-599c-446d-a959-2fd7b1b26c86"),
                            Description = " Space Opera, Cyberpunk, Hard Science Fiction",
                            GenreName = "Science Fiction (Sci-Fi)"
                        },
                        new
                        {
                            Id = new Guid("c13f46c7-a2cb-4908-afa5-4839faeb36a8"),
                            Description = "High Fantasy, Urban Fantasy, Magical Realism",
                            GenreName = "Fantasy"
                        },
                        new
                        {
                            Id = new Guid("7b22a916-6e56-4e05-8b77-3cc77b7ed978"),
                            Description = "Contemporary Romance, Historical Romance, Paranormal Romance",
                            GenreName = "Romance"
                        },
                        new
                        {
                            Id = new Guid("edc5b2a0-98bf-4c26-ad5e-c98898d7953c"),
                            Description = "Supernatural Horror, Psychological Horror, Gothic Horror",
                            GenreName = "Horror"
                        },
                        new
                        {
                            Id = new Guid("6ddff644-a438-464d-b65d-5111d4b7c97d"),
                            Description = "Ancient History, Medieval, Renaissance",
                            GenreName = "Historical Fiction"
                        },
                        new
                        {
                            Id = new Guid("966f1381-e42e-47b7-a26c-6f5e8bb1c281"),
                            Description = "Action-Adventure, Historical Adventure",
                            GenreName = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("0c681cfe-c29b-448e-b148-a3fc6ce42184"),
                            Description = "Satirical Fiction, Comic Fiction",
                            GenreName = "Satire/Humor"
                        },
                        new
                        {
                            Id = new Guid("87ef929a-c939-4842-a6d4-04230985ca93"),
                            Description = "Superhero Comics, Graphic Memoirs",
                            GenreName = "Graphic Novels/Comics"
                        },
                        new
                        {
                            Id = new Guid("a261cd62-7818-486b-9ebe-9872ab73442b"),
                            Description = "Shonen, Shojo, Seinen, Josei",
                            GenreName = "Manga"
                        },
                        new
                        {
                            Id = new Guid("f6dd5da1-54ff-42c7-b558-155ec81be904"),
                            Description = "Classic Literature",
                            GenreName = "Classics"
                        },
                        new
                        {
                            Id = new Guid("02bc55be-9ce3-40bb-9daf-b2a8737d2a9c"),
                            Description = "Religious Texts, Spiritual Guidance",
                            GenreName = "Religious/Spiritual"
                        },
                        new
                        {
                            Id = new Guid("53344cdb-ac0d-48d2-97dd-0b4413e44366"),
                            Description = "Business Books, Finance and Investing",
                            GenreName = "Business/Finance"
                        },
                        new
                        {
                            Id = new Guid("68fa12b3-9135-425d-8ac4-20b7be0a6a8f"),
                            Description = "Culinary Non-Fiction",
                            GenreName = "Cookbooks"
                        },
                        new
                        {
                            Id = new Guid("cc02d990-0b55-4825-9c90-498ee5db75a2"),
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
