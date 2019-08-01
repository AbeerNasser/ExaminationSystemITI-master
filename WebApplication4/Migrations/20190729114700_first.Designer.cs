﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication4.Models;

namespace WebApplication4.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190729114700_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("WebApplication4.Models.Exam", b =>
                {
                    b.Property<int>("Exam_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ex_Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("Sub_Id");

                    b.Property<int?>("Time");

                    b.HasKey("Exam_Id");

                    b.HasIndex("Sub_Id");

                    b.ToTable("exams");
                });

            modelBuilder.Entity("WebApplication4.Models.Exam_Questions", b =>
                {
                    b.Property<int>("Que_Id");

                    b.Property<int>("Ex_Id");

                    b.Property<int>("Degree");

                    b.HasKey("Que_Id", "Ex_Id");

                    b.HasAlternateKey("Ex_Id", "Que_Id");

                    b.ToTable("exam_Questions");
                });

            modelBuilder.Entity("WebApplication4.Models.Instructor", b =>
                {
                    b.Property<int>("Inst_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Admin_Id");

                    b.Property<string>("Inst_Address")
                        .HasMaxLength(50);

                    b.Property<int>("Inst_Age");

                    b.Property<string>("Inst_Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Inst_Phone")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("TrackTrs_Id");

                    b.Property<int?>("Track_Id");

                    b.Property<int>("User_Id");

                    b.HasKey("Inst_Id");

                    b.HasIndex("TrackTrs_Id");

                    b.ToTable("instructors");
                });

            modelBuilder.Entity("WebApplication4.Models.Question", b =>
                {
                    b.Property<int>("Que_Id");

                    b.Property<string>("Answers_Options");

                    b.Property<string>("Correct_Answers");

                    b.Property<string>("Image")
                        .HasMaxLength(20);

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Type1Type_Id");

                    b.HasKey("Que_Id");

                    b.HasIndex("Type1Type_Id");

                    b.ToTable("questions");
                });

            modelBuilder.Entity("WebApplication4.Models.StdsAnswer", b =>
                {
                    b.Property<int>("Que_Id");

                    b.Property<int>("Ex_Id");

                    b.Property<string>("Choose_Answer")
                        .IsRequired();

                    b.Property<int>("Std_Id");

                    b.HasKey("Que_Id", "Ex_Id");

                    b.HasAlternateKey("Ex_Id", "Que_Id", "Std_Id");

                    b.HasIndex("Std_Id");

                    b.ToTable("stdsAnswers");
                });

            modelBuilder.Entity("WebApplication4.Models.Student", b =>
                {
                    b.Property<int>("Std_Id");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("date");

                    b.Property<int?>("CreateID");

                    b.Property<double?>("Degree");

                    b.Property<DateTime?>("EditDate")
                        .HasColumnType("date");

                    b.Property<int?>("EditID");

                    b.Property<string>("Phone")
                        .HasMaxLength(12);

                    b.Property<string>("Std_Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Std_Age");

                    b.Property<string>("Std_Fauclty")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Std_Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Std_University")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("Track_id");

                    b.Property<int>("User_Id");

                    b.HasKey("Std_Id");

                    b.ToTable("students");
                });

            modelBuilder.Entity("WebApplication4.Models.Subject", b =>
                {
                    b.Property<int>("Sub_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Sub_Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Track_Id");

                    b.HasKey("Sub_Id");

                    b.HasIndex("Track_Id");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("WebApplication4.Models.Track", b =>
                {
                    b.Property<int>("Trs_Id");

                    b.Property<int?>("StudentStd_Id");

                    b.Property<string>("Trs_Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Trs_Id");

                    b.HasIndex("StudentStd_Id");

                    b.ToTable("tracks");
                });

            modelBuilder.Entity("WebApplication4.Models.Type", b =>
                {
                    b.Property<string>("Type_Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5);

                    b.Property<byte[]>("Image")
                        .HasMaxLength(100);

                    b.Property<string>("MCQ")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool?>("True_False");

                    b.HasKey("Type_Id");

                    b.ToTable("types");
                });

            modelBuilder.Entity("WebApplication4.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("FullName");

                    b.Property<string>("Password");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication4.Models.Exam", b =>
                {
                    b.HasOne("WebApplication4.Models.Subject", "Subject")
                        .WithMany("Exams")
                        .HasForeignKey("Sub_Id");
                });

            modelBuilder.Entity("WebApplication4.Models.Exam_Questions", b =>
                {
                    b.HasOne("WebApplication4.Models.Exam", "Exam")
                        .WithMany("Exam_Questions")
                        .HasForeignKey("Ex_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication4.Models.Question", "Question")
                        .WithMany("Exam_Questions")
                        .HasForeignKey("Que_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication4.Models.Instructor", b =>
                {
                    b.HasOne("WebApplication4.Models.Track", "Track")
                        .WithMany("Instructors")
                        .HasForeignKey("TrackTrs_Id");
                });

            modelBuilder.Entity("WebApplication4.Models.Question", b =>
                {
                    b.HasOne("WebApplication4.Models.Type", "Type1")
                        .WithMany("Questions")
                        .HasForeignKey("Type1Type_Id");
                });

            modelBuilder.Entity("WebApplication4.Models.StdsAnswer", b =>
                {
                    b.HasOne("WebApplication4.Models.Exam", "Exam")
                        .WithMany("StdsAnswers")
                        .HasForeignKey("Ex_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication4.Models.Question", "Question")
                        .WithMany("StdsAnswers")
                        .HasForeignKey("Que_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication4.Models.Student", "Student")
                        .WithMany("StdsAnswers")
                        .HasForeignKey("Std_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication4.Models.Subject", b =>
                {
                    b.HasOne("WebApplication4.Models.Track", "Track")
                        .WithMany("Subjects")
                        .HasForeignKey("Track_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication4.Models.Track", b =>
                {
                    b.HasOne("WebApplication4.Models.Student", "Student")
                        .WithMany("Tracks")
                        .HasForeignKey("StudentStd_Id");
                });
#pragma warning restore 612, 618
        }
    }
}
