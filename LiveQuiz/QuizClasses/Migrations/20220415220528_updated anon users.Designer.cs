﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizClasses;

namespace QuizClasses.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20220415220528_updated anon users")]
    partial class updatedanonusers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuizClasses.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Topic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("User")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("User");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("QuizClasses.QuizAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Correct")
                        .HasColumnType("bit");

                    b.Property<int?>("QuizQuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuizQuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("QuizClasses.QuizInstance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<string>("HostIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.Property<string>("RoomCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Instances");
                });

            modelBuilder.Entity("QuizClasses.QuizQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("QuizClasses.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuizInstanceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuizInstanceId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("QuizClasses.UserScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvgTimeToAnswer")
                        .HasColumnType("int");

                    b.Property<int>("NumCorrect")
                        .HasColumnType("int");

                    b.Property<int>("NumQuestions")
                        .HasColumnType("int");

                    b.Property<string>("QuizName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("TotalTime")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("QuizClasses.Anon", b =>
                {
                    b.HasBaseType("QuizClasses.User");

                    b.HasDiscriminator().HasValue("Anon");
                });

            modelBuilder.Entity("QuizClasses.Quiz", b =>
                {
                    b.HasOne("QuizClasses.User", "Creator")
                        .WithMany()
                        .HasForeignKey("User");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("QuizClasses.QuizAnswer", b =>
                {
                    b.HasOne("QuizClasses.QuizQuestion", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuizQuestionId");
                });

            modelBuilder.Entity("QuizClasses.QuizInstance", b =>
                {
                    b.HasOne("QuizClasses.Quiz", null)
                        .WithMany("Instances")
                        .HasForeignKey("QuizId");
                });

            modelBuilder.Entity("QuizClasses.QuizQuestion", b =>
                {
                    b.HasOne("QuizClasses.Quiz", null)
                        .WithMany("Questions")
                        .HasForeignKey("QuizId");
                });

            modelBuilder.Entity("QuizClasses.User", b =>
                {
                    b.HasOne("QuizClasses.QuizInstance", null)
                        .WithMany("Contestants")
                        .HasForeignKey("QuizInstanceId");
                });

            modelBuilder.Entity("QuizClasses.UserScore", b =>
                {
                    b.HasOne("QuizClasses.User", null)
                        .WithMany("UserScores")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("QuizClasses.Quiz", b =>
                {
                    b.Navigation("Instances");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("QuizClasses.QuizInstance", b =>
                {
                    b.Navigation("Contestants");
                });

            modelBuilder.Entity("QuizClasses.QuizQuestion", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("QuizClasses.User", b =>
                {
                    b.Navigation("UserScores");
                });
#pragma warning restore 612, 618
        }
    }
}
