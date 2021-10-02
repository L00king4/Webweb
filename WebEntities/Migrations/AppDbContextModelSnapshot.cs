﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebEntities;

namespace WebEntities.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WebEntities.DB.Models.Trainings.TrainingSpanPayment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EventID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PayedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("SpanPayedEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("SpanPayedStart")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TraineeID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("TrainingSpanPayments");
                });

            modelBuilder.Entity("WebEntities.Models.Competitions.Competition", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<byte>("AgeGroup")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<decimal>("ToPay")
                        .HasColumnType("numeric");

                    b.HasKey("ID");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("WebEntities.Models.Competitions.CompetitionAttendance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("EventID")
                        .HasColumnType("integer");

                    b.Property<int>("TraineeID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("CompetitionAttendances");
                });

            modelBuilder.Entity("WebEntities.Models.Competitions.CompetitionPayment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EventID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PayedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TraineeID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("CompetitionPayments");
                });

            modelBuilder.Entity("WebEntities.Models.PayedEvents.PayedEvent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<byte>("AgeGroup")
                        .HasColumnType("smallint");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("PayUntil")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("ToPay")
                        .HasColumnType("numeric");

                    b.HasKey("ID");

                    b.ToTable("PayedEvents");
                });

            modelBuilder.Entity("WebEntities.Models.PayedEvents.PayedEventAttendance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("EventID")
                        .HasColumnType("integer");

                    b.Property<int>("TraineeID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("PayedEventAttendances");
                });

            modelBuilder.Entity("WebEntities.Models.PayedEvents.PayedEventPayment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EventID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PayedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TraineeID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("PayedEventPayments");
                });

            modelBuilder.Entity("WebEntities.Models.Trainee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<byte>("AgeGroup")
                        .HasColumnType("smallint");

                    b.Property<byte>("BeltColor")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ID");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("WebEntities.Models.Trainings.Training", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<byte>("AgeGroup")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<decimal>("MonthlyPass")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<decimal>("ToPay")
                        .HasColumnType("numeric");

                    b.HasKey("ID");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("WebEntities.Models.Trainings.TrainingAttendance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("EventID")
                        .HasColumnType("integer");

                    b.Property<int>("TraineeID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("TrainingAttendance");
                });

            modelBuilder.Entity("WebEntities.Models.Trainings.TrainingPayment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EventID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PayedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TraineeID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("TrainingPayments");
                });
#pragma warning restore 612, 618
        }
    }
}
