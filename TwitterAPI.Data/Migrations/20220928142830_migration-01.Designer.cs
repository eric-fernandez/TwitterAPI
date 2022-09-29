﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwitterAPI.Data.Context;

#nullable disable

namespace TwitterAPI.Data.Migrations
{
    [DbContext(typeof(TweetDbContext))]
    [Migration("20220928142830_migration-01")]
    partial class migration01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TwitterAPI.Model.Tweet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Hashtag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tweets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTimeOffset(new DateTime(2022, 9, 28, 14, 28, 30, 271, DateTimeKind.Unspecified).AddTicks(492), new TimeSpan(0, 0, 0, 0, 0)),
                            Hashtag = "#hello",
                            Title = "Tweet 1"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTimeOffset(new DateTime(2022, 9, 28, 14, 28, 30, 271, DateTimeKind.Unspecified).AddTicks(494), new TimeSpan(0, 0, 0, 0, 0)),
                            Hashtag = "#world",
                            Title = "Tweet 2"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTimeOffset(new DateTime(2022, 9, 28, 14, 28, 30, 271, DateTimeKind.Unspecified).AddTicks(495), new TimeSpan(0, 0, 0, 0, 0)),
                            Hashtag = "#news",
                            Title = "Tweet 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
