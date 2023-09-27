using System;
using System.Collections.Generic;
using KaniniAcademy.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace KaniniAcademy.Models
{
    public partial class KaniniAcademyContext : DbContext
    {
        public KaniniAcademyContext()
        {
        }

        public KaniniAcademyContext(DbContextOptions<KaniniAcademyContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseResource> CourseResources { get; set; }
        public virtual DbSet<Creator> Creators { get; set; }
        public virtual DbSet<CtcReg> CtcRegs { get; set; }
        public virtual DbSet<FreeResource> FreeResources { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<Qa> Qas { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<SkillQuiz> SkillQuizzes { get; set; }
        public virtual DbSet<StatusOfLearner> StatusOfLearners { get; set; }
        public virtual DbSet<Submission> Submissions { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public  virtual DbSet<Usability> Usability { get; set; }
        public virtual DbSet<AboutTheCertificate> AboutTheCertificates { get; set; }
        public virtual DbSet<DetailedCertificate> DetailedCertificates { get; set; }
     /*   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

            => optionsBuilder.UseSqlServer("Data Source=ISHANT\\SQLEXPRESS;Initial Catalog=KaniniAcad8;Integrated Security=True;trustservercertificate=True");
       */ protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


    }
}