using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaniniAcademy.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutTheCertificates",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    shareCert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    onlinecour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    schedule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image4 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image5 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    approtime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image6 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    language = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutTheCertificates", x => x.ImageId);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Cid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Projects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideosDuration = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    KeySkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificatePass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Cid);
                });

            migrationBuilder.CreateTable(
                name: "Creators",
                columns: table => new
                {
                    CreatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Followers = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creators", x => x.CreatorId);
                });

            migrationBuilder.CreateTable(
                name: "DetailedCertificates",
                columns: table => new
                {
                    detailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutAns1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutAns2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutAns3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutAns4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutAns5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutAns6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutAns7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutAns8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutAns9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutAns10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutAns11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Work1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkAns1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Work2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkAns2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Work3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkAns3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaqQues1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaqAns1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaqQues2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaqAns2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaqQues3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaqAns3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaqQues4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaqAns4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaqQues5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaqAns5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailedCertificates", x => x.detailId);
                });

            migrationBuilder.CreateTable(
                name: "SkillQuizzes",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thumbnail = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillQuizzes", x => x.QuizId);
                });

            migrationBuilder.CreateTable(
                name: "Usability",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usability", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfUpload = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_Blogs_Creators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creators",
                        principalColumn: "CreatorId");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Creators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creators",
                        principalColumn: "CreatorId");
                });

            migrationBuilder.CreateTable(
                name: "FreeResources",
                columns: table => new
                {
                    FreeRid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Downloads = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thumbnail = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Book = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Template = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: true),
                    mainfeature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreeResources", x => x.FreeRid);
                    table.ForeignKey(
                        name: "FK_FreeResources_Creators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creators",
                        principalColumn: "CreatorId");
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Tid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Tname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Resources = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Tid);
                    table.ForeignKey(
                        name: "FK_Training_Creators_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creators",
                        principalColumn: "CreatorId");
                });

            migrationBuilder.CreateTable(
                name: "Qas",
                columns: table => new
                {
                    Qid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Op1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Op2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Op3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Op4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ans = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillQuizId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qas", x => x.Qid);
                    table.ForeignKey(
                        name: "FK_Qas_SkillQuizzes_SkillQuizId",
                        column: x => x.SkillQuizId,
                        principalTable: "SkillQuizzes",
                        principalColumn: "QuizId");
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NotesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NotesId);
                    table.ForeignKey(
                        name: "FK_Notes_UserDetails_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Points",
                columns: table => new
                {
                    PointId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Points = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    SkillQuizId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.PointId);
                    table.ForeignKey(
                        name: "FK_Points_SkillQuizzes_SkillQuizId",
                        column: x => x.SkillQuizId,
                        principalTable: "SkillQuizzes",
                        principalColumn: "QuizId");
                    table.ForeignKey(
                        name: "FK_Points_UserDetails_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "CourseResources",
                columns: table => new
                {
                    CourseResourceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Video = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Thumbnail = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resources = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseResources", x => x.CourseResourceID);
                    table.ForeignKey(
                        name: "FK_CourseResources_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId");
                });

            migrationBuilder.CreateTable(
                name: "StatusOfLearners",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCompletion = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    CourseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusOfLearners", x => x.StatusId);
                    table.ForeignKey(
                        name: "FK_StatusOfLearners_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseId");
                    table.ForeignKey(
                        name: "FK_StatusOfLearners_UserDetails_UserID",
                        column: x => x.UserID,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "CtcRegs",
                columns: table => new
                {
                    CtcId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    TrainingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtcRegs", x => x.CtcId);
                    table.ForeignKey(
                        name: "FK_CtcRegs_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certificates",
                        principalColumn: "Cid");
                    table.ForeignKey(
                        name: "FK_CtcRegs_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId");
                    table.ForeignKey(
                        name: "FK_CtcRegs_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "Tid");
                    table.ForeignKey(
                        name: "FK_CtcRegs_UserDetails_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    RId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Training = table.Column<int>(type: "int", nullable: true),
                    UserDetail = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.RId);
                    table.ForeignKey(
                        name: "FK_Reviews_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId");
                    table.ForeignKey(
                        name: "FK_Reviews_Training_Training",
                        column: x => x.Training,
                        principalTable: "Training",
                        principalColumn: "Tid");
                    table.ForeignKey(
                        name: "FK_Reviews_UserDetails_UserDetail",
                        column: x => x.UserDetail,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Submissions",
                columns: table => new
                {
                    SubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Work = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    TrainingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions", x => x.SubId);
                    table.ForeignKey(
                        name: "FK_Submissions_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "Tid");
                    table.ForeignKey(
                        name: "FK_Submissions_UserDetails_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CreatorId",
                table: "Blogs",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseResources_CourseId",
                table: "CourseResources",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CreatorId",
                table: "Courses",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_CtcRegs_CertificateId",
                table: "CtcRegs",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_CtcRegs_CourseId",
                table: "CtcRegs",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CtcRegs_TrainingId",
                table: "CtcRegs",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_CtcRegs_UserId",
                table: "CtcRegs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FreeResources_CreatorId",
                table: "FreeResources",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UserId",
                table: "Notes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Points_SkillQuizId",
                table: "Points",
                column: "SkillQuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Points_UserId",
                table: "Points",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Qas_SkillQuizId",
                table: "Qas",
                column: "SkillQuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CourseId",
                table: "Reviews",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Training",
                table: "Reviews",
                column: "Training");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserDetail",
                table: "Reviews",
                column: "UserDetail");

            migrationBuilder.CreateIndex(
                name: "IX_StatusOfLearners_CourseID",
                table: "StatusOfLearners",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_StatusOfLearners_UserID",
                table: "StatusOfLearners",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_TrainingId",
                table: "Submissions",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_UserId",
                table: "Submissions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_CreatorId",
                table: "Training",
                column: "CreatorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutTheCertificates");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "CourseResources");

            migrationBuilder.DropTable(
                name: "CtcRegs");

            migrationBuilder.DropTable(
                name: "DetailedCertificates");

            migrationBuilder.DropTable(
                name: "FreeResources");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Points");

            migrationBuilder.DropTable(
                name: "Qas");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "StatusOfLearners");

            migrationBuilder.DropTable(
                name: "Submissions");

            migrationBuilder.DropTable(
                name: "Usability");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "SkillQuizzes");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "Creators");
        }
    }
}
