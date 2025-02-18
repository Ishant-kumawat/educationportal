﻿// <auto-generated />
using System;
using KaniniAcademy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KaniniAcademy.Migrations
{
    [DbContext(typeof(KaniniAcademyContext))]
    [Migration("20250218114514_Migrations")]
    partial class Migrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KaniniAcademy.Models.AboutTheCertificate", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"));

                    b.Property<byte[]>("Image1")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Image2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Image3")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Image4")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Image5")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Image6")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("approtime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("onlinecour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("schedule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shareCert")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.ToTable("AboutTheCertificates");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogId"));

                    b.Property<string>("BlogCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfUpload")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Topic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Certificate", b =>
                {
                    b.Property<int>("Cid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cid"));

                    b.Property<string>("CertificatePass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("KeySkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Projects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainingFormat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VideosDuration")
                        .HasColumnType("int");

                    b.HasKey("Cid");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("KaniniAcademy.Models.CourseResource", b =>
                {
                    b.Property<int>("CourseResourceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseResourceID"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resources")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Thumbnail")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Video")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("CourseResourceID");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseResources");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Creator", b =>
                {
                    b.Property<int>("CreatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CreatorId"));

                    b.Property<byte[]>("CreatorImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("CreatorJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Followers")
                        .HasColumnType("int");

                    b.HasKey("CreatorId");

                    b.ToTable("Creators");
                });

            modelBuilder.Entity("KaniniAcademy.Models.CtcReg", b =>
                {
                    b.Property<int>("CtcId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CtcId"));

                    b.Property<int?>("CertificateId")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("TrainingId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CtcId");

                    b.HasIndex("CertificateId");

                    b.HasIndex("CourseId");

                    b.HasIndex("TrainingId");

                    b.HasIndex("UserId");

                    b.ToTable("CtcRegs");
                });

            modelBuilder.Entity("KaniniAcademy.Models.DetailedCertificate", b =>
                {
                    b.Property<int>("detailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("detailId"));

                    b.Property<string>("AboutAns1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutAns10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutAns11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutAns2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutAns3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutAns4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutAns5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutAns6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutAns7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutAns8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutAns9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaqAns1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaqAns2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaqAns3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaqAns4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaqAns5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaqQues1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaqQues2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaqQues3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaqQues4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaqQues5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Work1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Work2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Work3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkAns1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkAns2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkAns3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("detailId");

                    b.ToTable("DetailedCertificates");
                });

            modelBuilder.Entity("KaniniAcademy.Models.FreeResource", b =>
                {
                    b.Property<int>("FreeRid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FreeRid"));

                    b.Property<string>("Book")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Downloads")
                        .HasColumnType("int");

                    b.Property<string>("Template")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Thumbnail")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Video")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("mainfeature")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FreeRid");

                    b.HasIndex("CreatorId");

                    b.ToTable("FreeResources");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Note", b =>
                {
                    b.Property<int>("NotesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotesId"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("NotesId");

                    b.HasIndex("UserId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Qa", b =>
                {
                    b.Property<int>("Qid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Qid"));

                    b.Property<string>("Ans")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Op1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Op2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Op3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Op4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SkillQuizId")
                        .HasColumnType("int");

                    b.HasKey("Qid");

                    b.HasIndex("SkillQuizId");

                    b.ToTable("Qas");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Review", b =>
                {
                    b.Property<int>("RId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RId"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Rname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Training")
                        .HasColumnType("int");

                    b.Property<int?>("UserDetail")
                        .HasColumnType("int");

                    b.HasKey("RId");

                    b.HasIndex("CourseId");

                    b.HasIndex("Training");

                    b.HasIndex("UserDetail");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("KaniniAcademy.Models.SkillQuiz", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuizId"));

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Thumbnail")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Topic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuizId");

                    b.ToTable("SkillQuizzes");
                });

            modelBuilder.Entity("KaniniAcademy.Models.StatusOfLearner", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<int?>("CourseCompletion")
                        .HasColumnType("int");

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("StatusId");

                    b.HasIndex("CourseID");

                    b.HasIndex("UserID");

                    b.ToTable("StatusOfLearners");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Submission", b =>
                {
                    b.Property<int>("SubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubId"));

                    b.Property<int?>("TrainingId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Work")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubId");

                    b.HasIndex("TrainingId");

                    b.HasIndex("UserId");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Training", b =>
                {
                    b.Property<int>("Tid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Tid"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Resources")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Video")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Tid");

                    b.HasIndex("CreatorId");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Usability", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Usability");
                });

            modelBuilder.Entity("KaniniAcademy.Models.UserDetail", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("MobileNo")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("Point", b =>
                {
                    b.Property<int>("PointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PointId"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Points")
                        .HasColumnType("int");

                    b.Property<int?>("SkillQuizId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PointId");

                    b.HasIndex("SkillQuizId");

                    b.HasIndex("UserId");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Blog", b =>
                {
                    b.HasOne("KaniniAcademy.Models.Creator", null)
                        .WithMany("Blogs")
                        .HasForeignKey("CreatorId");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Course", b =>
                {
                    b.HasOne("KaniniAcademy.Models.Creator", "Creator")
                        .WithMany("Courses")
                        .HasForeignKey("CreatorId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("KaniniAcademy.Models.CourseResource", b =>
                {
                    b.HasOne("KaniniAcademy.Models.Course", "Course")
                        .WithMany("CourseResources")
                        .HasForeignKey("CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("KaniniAcademy.Models.CtcReg", b =>
                {
                    b.HasOne("KaniniAcademy.Models.Certificate", "Certificate")
                        .WithMany("CtcReg")
                        .HasForeignKey("CertificateId");

                    b.HasOne("KaniniAcademy.Models.Course", "Course")
                        .WithMany("Ctcs")
                        .HasForeignKey("CourseId");

                    b.HasOne("KaniniAcademy.Models.Training", "Trainings")
                        .WithMany("ctcs")
                        .HasForeignKey("TrainingId");

                    b.HasOne("KaniniAcademy.Models.UserDetail", "UserDetail")
                        .WithMany("CtcRegs")
                        .HasForeignKey("UserId");

                    b.Navigation("Certificate");

                    b.Navigation("Course");

                    b.Navigation("Trainings");

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("KaniniAcademy.Models.FreeResource", b =>
                {
                    b.HasOne("KaniniAcademy.Models.Creator", null)
                        .WithMany("FreeResources")
                        .HasForeignKey("CreatorId");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Note", b =>
                {
                    b.HasOne("KaniniAcademy.Models.UserDetail", "UserDetail")
                        .WithMany("Notes")
                        .HasForeignKey("UserId");

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Qa", b =>
                {
                    b.HasOne("KaniniAcademy.Models.SkillQuiz", "SkillQuiz")
                        .WithMany("Qas")
                        .HasForeignKey("SkillQuizId");

                    b.Navigation("SkillQuiz");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Review", b =>
                {
                    b.HasOne("KaniniAcademy.Models.Course", null)
                        .WithMany("Reviews")
                        .HasForeignKey("CourseId");

                    b.HasOne("KaniniAcademy.Models.Training", "TraningId")
                        .WithMany("Reviews")
                        .HasForeignKey("Training");

                    b.HasOne("KaniniAcademy.Models.UserDetail", "UserId")
                        .WithMany("Reviews")
                        .HasForeignKey("UserDetail");

                    b.Navigation("TraningId");

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("KaniniAcademy.Models.StatusOfLearner", b =>
                {
                    b.HasOne("KaniniAcademy.Models.Course", "Course")
                        .WithMany("StatusOfLearners")
                        .HasForeignKey("CourseID");

                    b.HasOne("KaniniAcademy.Models.UserDetail", "UserDetail")
                        .WithMany("StatusOfLearner")
                        .HasForeignKey("UserID");

                    b.Navigation("Course");

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Submission", b =>
                {
                    b.HasOne("KaniniAcademy.Models.Training", "Training")
                        .WithMany("Submissions")
                        .HasForeignKey("TrainingId");

                    b.HasOne("KaniniAcademy.Models.UserDetail", "UserDetail")
                        .WithMany("Submissions")
                        .HasForeignKey("UserId");

                    b.Navigation("Training");

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Training", b =>
                {
                    b.HasOne("KaniniAcademy.Models.Creator", "Creator")
                        .WithMany("Training")
                        .HasForeignKey("CreatorId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Point", b =>
                {
                    b.HasOne("KaniniAcademy.Models.SkillQuiz", "SkillQuiz")
                        .WithMany("Points")
                        .HasForeignKey("SkillQuizId");

                    b.HasOne("KaniniAcademy.Models.UserDetail", "UserDetail")
                        .WithMany("Points")
                        .HasForeignKey("UserId");

                    b.Navigation("SkillQuiz");

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Certificate", b =>
                {
                    b.Navigation("CtcReg");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Course", b =>
                {
                    b.Navigation("CourseResources");

                    b.Navigation("Ctcs");

                    b.Navigation("Reviews");

                    b.Navigation("StatusOfLearners");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Creator", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Courses");

                    b.Navigation("FreeResources");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("KaniniAcademy.Models.SkillQuiz", b =>
                {
                    b.Navigation("Points");

                    b.Navigation("Qas");
                });

            modelBuilder.Entity("KaniniAcademy.Models.Training", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("Submissions");

                    b.Navigation("ctcs");
                });

            modelBuilder.Entity("KaniniAcademy.Models.UserDetail", b =>
                {
                    b.Navigation("CtcRegs");

                    b.Navigation("Notes");

                    b.Navigation("Points");

                    b.Navigation("Reviews");

                    b.Navigation("StatusOfLearner");

                    b.Navigation("Submissions");
                });
#pragma warning restore 612, 618
        }
    }
}
