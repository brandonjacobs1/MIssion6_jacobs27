﻿// <auto-generated />
using MIssion6_jacobs27.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MIssion6_jacobs27.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20230210224137_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("MIssion6_jacobs27.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 2,
                            Category = "Sci-FI",
                            Director = "George Lucas",
                            Edited = false,
                            LentTo = "Brandon Jacobs",
                            Notes = "No Notes",
                            Rating = "PG",
                            Title = "Starwars: Episode 2 - Attack of the Clones",
                            Year = "2002"
                        },
                        new
                        {
                            MovieID = 1,
                            Category = "Sci-FI",
                            Director = "George Lucas",
                            Edited = false,
                            LentTo = "Brandon Jacobs",
                            Notes = "No Notes",
                            Rating = "PG",
                            Title = "Starwars: Episode 1 - The Phantom Menace",
                            Year = "1999"
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Sci-FI",
                            Director = "George Lucas",
                            Edited = false,
                            LentTo = "Brandon Jacobs",
                            Notes = "No Notes",
                            Rating = "PG",
                            Title = "Starwars: Episode 3 - Revenge of the Sith",
                            Year = "2005"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}