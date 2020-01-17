using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.Migrations
{
    public partial class many : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_DailyPlans_DailyPlanId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Lessons_Lesson01Id",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Lessons_Lesson02Id",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Lessons_Lesson03Id",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Lessons_Lesson04Id",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Lessons_Lesson05Id",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Lessons_Lesson06Id",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Lessons_Lesson07Id",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Lessons_Lesson08Id",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Lessons_Lesson09Id",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Lessons_Lesson10Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_DailyPlanId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Lesson01Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Lesson02Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Lesson03Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Lesson04Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Lesson05Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Lesson06Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Lesson07Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Lesson08Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Lesson09Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Lesson10Id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "DailyPlanId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Lesson01Id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Lesson02Id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Lesson03Id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Lesson04Id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Lesson05Id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Lesson06Id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Lesson07Id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Lesson08Id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Lesson09Id",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Lesson10Id",
                table: "Rooms");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "Rooms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Lessons",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "Lessons",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DayNo",
                table: "DailyPlans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DayNoInWeek",
                table: "DailyPlans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "DailyPlans",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "WeeklyPlanId",
                table: "DailyPlans",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DailyRoomPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    RoomId1 = table.Column<int>(nullable: true),
                    Lesson01Id = table.Column<int>(nullable: true),
                    Lesson02Id = table.Column<int>(nullable: true),
                    Lesson03Id = table.Column<int>(nullable: true),
                    Lesson04Id = table.Column<int>(nullable: true),
                    Lesson05Id = table.Column<int>(nullable: true),
                    Lesson06Id = table.Column<int>(nullable: true),
                    Lesson07Id = table.Column<int>(nullable: true),
                    Lesson08Id = table.Column<int>(nullable: true),
                    Lesson09Id = table.Column<int>(nullable: true),
                    Lesson10Id = table.Column<int>(nullable: true),
                    DailyPlanId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyRoomPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyRoomPlans_DailyPlans_DailyPlanId",
                        column: x => x.DailyPlanId,
                        principalTable: "DailyPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyRoomPlans_Lessons_Lesson01Id",
                        column: x => x.Lesson01Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyRoomPlans_Lessons_Lesson02Id",
                        column: x => x.Lesson02Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyRoomPlans_Lessons_Lesson03Id",
                        column: x => x.Lesson03Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyRoomPlans_Lessons_Lesson04Id",
                        column: x => x.Lesson04Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyRoomPlans_Lessons_Lesson05Id",
                        column: x => x.Lesson05Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyRoomPlans_Lessons_Lesson06Id",
                        column: x => x.Lesson06Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyRoomPlans_Lessons_Lesson07Id",
                        column: x => x.Lesson07Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyRoomPlans_Lessons_Lesson08Id",
                        column: x => x.Lesson08Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyRoomPlans_Lessons_Lesson09Id",
                        column: x => x.Lesson09Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyRoomPlans_Lessons_Lesson10Id",
                        column: x => x.Lesson10Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyRoomPlans_Rooms_RoomId1",
                        column: x => x.RoomId1,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 255, nullable: false),
                    LastName = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    Login = table.Column<string>(maxLength: 255, nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instructors_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    Login = table.Column<string>(maxLength: 255, nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YearlyPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    ScheduleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearlyPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YearlyPlans_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    InstructorId = table.Column<int>(nullable: true),
                    LanguageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    YearlyPlanId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonthlyPlans_YearlyPlans_YearlyPlanId",
                        column: x => x.YearlyPlanId,
                        principalTable: "YearlyPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StudentId, x.CourseId });
                    table.UniqueConstraint("AK_StudentCourses_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeeklyPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    MonthlyPlanId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeeklyPlans_MonthlyPlans_MonthlyPlanId",
                        column: x => x.MonthlyPlanId,
                        principalTable: "MonthlyPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyPlans_WeeklyPlanId",
                table: "DailyPlans",
                column: "WeeklyPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_LanguageId",
                table: "Courses",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRoomPlans_DailyPlanId",
                table: "DailyRoomPlans",
                column: "DailyPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRoomPlans_Lesson01Id",
                table: "DailyRoomPlans",
                column: "Lesson01Id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRoomPlans_Lesson02Id",
                table: "DailyRoomPlans",
                column: "Lesson02Id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRoomPlans_Lesson03Id",
                table: "DailyRoomPlans",
                column: "Lesson03Id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRoomPlans_Lesson04Id",
                table: "DailyRoomPlans",
                column: "Lesson04Id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRoomPlans_Lesson05Id",
                table: "DailyRoomPlans",
                column: "Lesson05Id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRoomPlans_Lesson06Id",
                table: "DailyRoomPlans",
                column: "Lesson06Id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRoomPlans_Lesson07Id",
                table: "DailyRoomPlans",
                column: "Lesson07Id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRoomPlans_Lesson08Id",
                table: "DailyRoomPlans",
                column: "Lesson08Id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRoomPlans_Lesson09Id",
                table: "DailyRoomPlans",
                column: "Lesson09Id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRoomPlans_Lesson10Id",
                table: "DailyRoomPlans",
                column: "Lesson10Id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRoomPlans_RoomId1",
                table: "DailyRoomPlans",
                column: "RoomId1");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_LanguageId",
                table: "Instructors",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_PersonId",
                table: "Instructors",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyPlans_YearlyPlanId",
                table: "MonthlyPlans",
                column: "YearlyPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_PersonId",
                table: "Students",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_WeeklyPlans_MonthlyPlanId",
                table: "WeeklyPlans",
                column: "MonthlyPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_YearlyPlans_ScheduleId",
                table: "YearlyPlans",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyPlans_WeeklyPlans_WeeklyPlanId",
                table: "DailyPlans",
                column: "WeeklyPlanId",
                principalTable: "WeeklyPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyPlans_WeeklyPlans_WeeklyPlanId",
                table: "DailyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons");

            migrationBuilder.DropTable(
                name: "DailyRoomPlans");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "WeeklyPlans");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "MonthlyPlans");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "YearlyPlans");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_DailyPlans_WeeklyPlanId",
                table: "DailyPlans");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "DayNo",
                table: "DailyPlans");

            migrationBuilder.DropColumn(
                name: "DayNoInWeek",
                table: "DailyPlans");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "DailyPlans");

            migrationBuilder.DropColumn(
                name: "WeeklyPlanId",
                table: "DailyPlans");

            migrationBuilder.AddColumn<int>(
                name: "DailyPlanId",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lesson01Id",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lesson02Id",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lesson03Id",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lesson04Id",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lesson05Id",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lesson06Id",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lesson07Id",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lesson08Id",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lesson09Id",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lesson10Id",
                table: "Rooms",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_DailyPlanId",
                table: "Rooms",
                column: "DailyPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Lesson01Id",
                table: "Rooms",
                column: "Lesson01Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Lesson02Id",
                table: "Rooms",
                column: "Lesson02Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Lesson03Id",
                table: "Rooms",
                column: "Lesson03Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Lesson04Id",
                table: "Rooms",
                column: "Lesson04Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Lesson05Id",
                table: "Rooms",
                column: "Lesson05Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Lesson06Id",
                table: "Rooms",
                column: "Lesson06Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Lesson07Id",
                table: "Rooms",
                column: "Lesson07Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Lesson08Id",
                table: "Rooms",
                column: "Lesson08Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Lesson09Id",
                table: "Rooms",
                column: "Lesson09Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Lesson10Id",
                table: "Rooms",
                column: "Lesson10Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_DailyPlans_DailyPlanId",
                table: "Rooms",
                column: "DailyPlanId",
                principalTable: "DailyPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Lessons_Lesson01Id",
                table: "Rooms",
                column: "Lesson01Id",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Lessons_Lesson02Id",
                table: "Rooms",
                column: "Lesson02Id",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Lessons_Lesson03Id",
                table: "Rooms",
                column: "Lesson03Id",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Lessons_Lesson04Id",
                table: "Rooms",
                column: "Lesson04Id",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Lessons_Lesson05Id",
                table: "Rooms",
                column: "Lesson05Id",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Lessons_Lesson06Id",
                table: "Rooms",
                column: "Lesson06Id",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Lessons_Lesson07Id",
                table: "Rooms",
                column: "Lesson07Id",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Lessons_Lesson08Id",
                table: "Rooms",
                column: "Lesson08Id",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Lessons_Lesson09Id",
                table: "Rooms",
                column: "Lesson09Id",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Lessons_Lesson10Id",
                table: "Rooms",
                column: "Lesson10Id",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
