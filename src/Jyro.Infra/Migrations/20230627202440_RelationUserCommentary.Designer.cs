﻿// <auto-generated />
using System;
using Jyro.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Jyro.Infra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230627202440_RelationUserCommentary")]
    partial class RelationUserCommentary
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CommentaryUser", b =>
                {
                    b.Property<Guid>("CommentaryMentionnedId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MentionnedId")
                        .HasColumnType("uuid");

                    b.HasKey("CommentaryMentionnedId", "MentionnedId");

                    b.HasIndex("MentionnedId");

                    b.ToTable("CommentaryUser");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Column", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Columns");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Commentary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AuthorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("TaskId");

                    b.ToTable("Commentaries");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Sprint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Sprints");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ColumnId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ResponsableId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SprintId")
                        .HasColumnType("uuid");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("interval");

                    b.HasKey("Id");

                    b.HasIndex("ColumnId");

                    b.HasIndex("ResponsableId");

                    b.HasIndex("SprintId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Time", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Commentary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uuid");

                    b.Property<TimeSpan>("Times")
                        .HasColumnType("interval");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.HasIndex("UserId");

                    b.ToTable("Times");
                });

            modelBuilder.Entity("Jyro.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CommentaryUser", b =>
                {
                    b.HasOne("Jyro.Core.Entities.Commentary", null)
                        .WithMany()
                        .HasForeignKey("CommentaryMentionnedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jyro.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("MentionnedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Jyro.Core.Entities.Column", b =>
                {
                    b.HasOne("Jyro.Core.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Commentary", b =>
                {
                    b.HasOne("Jyro.Core.Entities.User", "Author")
                        .WithMany("CommentariesWrote")
                        .HasForeignKey("AuthorId");

                    b.HasOne("Jyro.Core.Entities.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Sprint", b =>
                {
                    b.HasOne("Jyro.Core.Entities.Project", "Project")
                        .WithMany("Sprints")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Task", b =>
                {
                    b.HasOne("Jyro.Core.Entities.Column", "Column")
                        .WithMany("Tasks")
                        .HasForeignKey("ColumnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jyro.Core.Entities.User", "Responsable")
                        .WithMany()
                        .HasForeignKey("ResponsableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jyro.Core.Entities.Sprint", "Sprint")
                        .WithMany("Tasks")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Column");

                    b.Navigation("Responsable");

                    b.Navigation("Sprint");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Time", b =>
                {
                    b.HasOne("Jyro.Core.Entities.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jyro.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Column", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Project", b =>
                {
                    b.Navigation("Sprints");
                });

            modelBuilder.Entity("Jyro.Core.Entities.Sprint", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Jyro.Core.Entities.User", b =>
                {
                    b.Navigation("CommentariesWrote");
                });
#pragma warning restore 612, 618
        }
    }
}
