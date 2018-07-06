﻿// <auto-generated />
using API.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace API.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20180311165016_db2")]
    partial class db2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("API.Models.EntityModels.Game", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("date");

                    b.Property<bool>("deleted");

                    b.Property<bool>("draw");

                    b.Property<bool>("teamOneWin");

                    b.Property<bool>("teamTwoWin");

                    b.HasKey("ID");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("API.Models.EntityModels.GameInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("gid");

                    b.Property<int>("pid");

                    b.Property<string>("result");

                    b.Property<bool>("teamOne");

                    b.Property<int>("teamOneScore");

                    b.Property<bool>("teamTwo");

                    b.Property<int>("teamTwoScore");

                    b.HasKey("ID");

                    b.ToTable("GamesWon");
                });

            modelBuilder.Entity("API.Models.EntityModels.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("attented");

                    b.Property<bool>("deleted");

                    b.Property<int>("draws");

                    b.Property<int>("gamesLost");

                    b.Property<int>("gamesWon");

                    b.Property<int>("losses");

                    b.Property<string>("name");

                    b.Property<int>("wins");

                    b.HasKey("ID");

                    b.ToTable("Player");
                });
#pragma warning restore 612, 618
        }
    }
}
