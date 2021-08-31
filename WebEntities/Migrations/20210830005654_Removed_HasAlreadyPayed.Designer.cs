﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebEntities;

namespace WebEntities.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210830005654_Removed_HasAlreadyPayed")]
    partial class Removed_HasAlreadyPayed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WebEntities.Models.Competitions.Competition", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<decimal?>("ToPay")
                        .IsRequired()
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

                    b.Property<int?>("EventID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("TraineeID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("EventID");

                    b.ToTable("CompetitionAttendances");
                });

            modelBuilder.Entity("WebEntities.Models.Competitions.CompetitionPayment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal?>("Amount")
                        .IsRequired()
                        .HasColumnType("numeric");

                    b.Property<int?>("AttendanceID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("EventID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<DateTime>("PayedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("TraineeID")
                        .IsRequired()
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

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<decimal?>("ToPay")
                        .IsRequired()
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

                    b.Property<int?>("EventID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("TraineeID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("EventID");

                    b.ToTable("PayedEventAttendances");
                });

            modelBuilder.Entity("WebEntities.Models.PayedEvents.PayedEventPayment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal?>("Amount")
                        .IsRequired()
                        .HasColumnType("numeric");

                    b.Property<int?>("AttendanceID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("EventID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<DateTime>("PayedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("TraineeID")
                        .IsRequired()
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

                    b.Property<byte?>("Age")
                        .HasColumnType("smallint");

                    b.Property<byte>("AgeGroup")
                        .HasColumnType("smallint");

                    b.Property<byte?>("BeltColor")
                        .HasColumnType("smallint");

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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<decimal?>("ToPay")
                        .IsRequired()
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

                    b.Property<int?>("EventID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("TraineeID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("EventID");

                    b.ToTable("TrainingAttendance");
                });

            modelBuilder.Entity("WebEntities.Models.Trainings.TrainingPayment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal?>("Amount")
                        .IsRequired()
                        .HasColumnType("numeric");

                    b.Property<int?>("AttendanceID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("EventID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<DateTime>("PayedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("StartTimePayed")
                        .HasColumnType("timestamp without time zone");

                    b.Property<TimeSpan>("TimePayed")
                        .HasColumnType("interval");

                    b.Property<int?>("TraineeID")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("TrainingPayments");
                });

            modelBuilder.Entity("WebEntities.Models.Competitions.CompetitionAttendance", b =>
                {
                    b.HasOne("WebEntities.Models.Competitions.Competition", "Event")
                        .WithMany()
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("WebEntities.Models.PayedEvents.PayedEventAttendance", b =>
                {
                    b.HasOne("WebEntities.Models.PayedEvents.PayedEvent", "Event")
                        .WithMany()
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("WebEntities.Models.Trainings.TrainingAttendance", b =>
                {
                    b.HasOne("WebEntities.Models.Trainings.Training", "Event")
                        .WithMany()
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });
#pragma warning restore 612, 618
        }
    }
}
