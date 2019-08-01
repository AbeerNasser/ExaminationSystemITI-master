using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Std_Id = table.Column<int>(nullable: false),
                    Std_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Std_Address = table.Column<string>(maxLength: 50, nullable: false),
                    Std_Age = table.Column<int>(nullable: false),
                    Std_Fauclty = table.Column<string>(maxLength: 50, nullable: false),
                    Std_University = table.Column<string>(maxLength: 50, nullable: false),
                    User_Id = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(maxLength: 12, nullable: true),
                    Track_id = table.Column<int>(nullable: true),
                    Degree = table.Column<double>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreateID = table.Column<int>(nullable: true),
                    EditID = table.Column<int>(nullable: true),
                    EditDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Std_Id);
                });

            migrationBuilder.CreateTable(
                name: "types",
                columns: table => new
                {
                    Type_Id = table.Column<string>(maxLength: 5, nullable: false),
                    MCQ = table.Column<string>(maxLength: 50, nullable: false),
                    True_False = table.Column<bool>(nullable: true),
                    Image = table.Column<byte[]>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_types", x => x.Type_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tracks",
                columns: table => new
                {
                    Trs_Id = table.Column<int>(nullable: false),
                    Trs_Name = table.Column<string>(maxLength: 50, nullable: false),
                    StudentStd_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tracks", x => x.Trs_Id);
                    table.ForeignKey(
                        name: "FK_tracks_students_StudentStd_Id",
                        column: x => x.StudentStd_Id,
                        principalTable: "students",
                        principalColumn: "Std_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    Que_Id = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Type = table.Column<string>(maxLength: 5, nullable: false),
                    Answers_Options = table.Column<string>(nullable: true),
                    Correct_Answers = table.Column<string>(nullable: true),
                    Image = table.Column<string>(maxLength: 20, nullable: true),
                    Type1Type_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.Que_Id);
                    table.ForeignKey(
                        name: "FK_questions_types_Type1Type_Id",
                        column: x => x.Type1Type_Id,
                        principalTable: "types",
                        principalColumn: "Type_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "instructors",
                columns: table => new
                {
                    Inst_Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Inst_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Inst_Age = table.Column<int>(nullable: false),
                    Inst_Address = table.Column<string>(maxLength: 50, nullable: true),
                    Inst_Phone = table.Column<string>(maxLength: 50, nullable: false),
                    User_Id = table.Column<int>(nullable: false),
                    Admin_Id = table.Column<int>(nullable: false),
                    Track_Id = table.Column<int>(nullable: true),
                    TrackTrs_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructors", x => x.Inst_Id);
                    table.ForeignKey(
                        name: "FK_instructors_tracks_TrackTrs_Id",
                        column: x => x.TrackTrs_Id,
                        principalTable: "tracks",
                        principalColumn: "Trs_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    Sub_Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sub_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Track_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.Sub_Id);
                    table.ForeignKey(
                        name: "FK_subjects_tracks_Track_Id",
                        column: x => x.Track_Id,
                        principalTable: "tracks",
                        principalColumn: "Trs_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "exams",
                columns: table => new
                {
                    Exam_Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ex_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Time = table.Column<int>(nullable: true),
                    Sub_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exams", x => x.Exam_Id);
                    table.ForeignKey(
                        name: "FK_exams_subjects_Sub_Id",
                        column: x => x.Sub_Id,
                        principalTable: "subjects",
                        principalColumn: "Sub_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "exam_Questions",
                columns: table => new
                {
                    Ex_Id = table.Column<int>(nullable: false),
                    Que_Id = table.Column<int>(nullable: false),
                    Degree = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exam_Questions", x => new { x.Que_Id, x.Ex_Id });
                    table.UniqueConstraint("AK_exam_Questions_Ex_Id_Que_Id", x => new { x.Ex_Id, x.Que_Id });
                    table.ForeignKey(
                        name: "FK_exam_Questions_exams_Ex_Id",
                        column: x => x.Ex_Id,
                        principalTable: "exams",
                        principalColumn: "Exam_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_exam_Questions_questions_Que_Id",
                        column: x => x.Que_Id,
                        principalTable: "questions",
                        principalColumn: "Que_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stdsAnswers",
                columns: table => new
                {
                    Que_Id = table.Column<int>(nullable: false),
                    Ex_Id = table.Column<int>(nullable: false),
                    Std_Id = table.Column<int>(nullable: false),
                    Choose_Answer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stdsAnswers", x => new { x.Que_Id, x.Ex_Id });
                    table.UniqueConstraint("AK_stdsAnswers_Ex_Id_Que_Id_Std_Id", x => new { x.Ex_Id, x.Que_Id, x.Std_Id });
                    table.ForeignKey(
                        name: "FK_stdsAnswers_exams_Ex_Id",
                        column: x => x.Ex_Id,
                        principalTable: "exams",
                        principalColumn: "Exam_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stdsAnswers_questions_Que_Id",
                        column: x => x.Que_Id,
                        principalTable: "questions",
                        principalColumn: "Que_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stdsAnswers_students_Std_Id",
                        column: x => x.Std_Id,
                        principalTable: "students",
                        principalColumn: "Std_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_exams_Sub_Id",
                table: "exams",
                column: "Sub_Id");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_TrackTrs_Id",
                table: "instructors",
                column: "TrackTrs_Id");

            migrationBuilder.CreateIndex(
                name: "IX_questions_Type1Type_Id",
                table: "questions",
                column: "Type1Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_stdsAnswers_Std_Id",
                table: "stdsAnswers",
                column: "Std_Id");

            migrationBuilder.CreateIndex(
                name: "IX_subjects_Track_Id",
                table: "subjects",
                column: "Track_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tracks_StudentStd_Id",
                table: "tracks",
                column: "StudentStd_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "exam_Questions");

            migrationBuilder.DropTable(
                name: "instructors");

            migrationBuilder.DropTable(
                name: "stdsAnswers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "exams");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropTable(
                name: "subjects");

            migrationBuilder.DropTable(
                name: "types");

            migrationBuilder.DropTable(
                name: "tracks");

            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
