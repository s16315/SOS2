using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyPlanLessons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyPlanLessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Replacement = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
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
                    DailyPlanLessonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_DailyPlanLessons_DailyPlanLessonId",
                        column: x => x.DailyPlanLessonId,
                        principalTable: "DailyPlanLessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_Lesson_Lesson01Id",
                        column: x => x.Lesson01Id,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_Lesson_Lesson02Id",
                        column: x => x.Lesson02Id,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_Lesson_Lesson03Id",
                        column: x => x.Lesson03Id,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_Lesson_Lesson04Id",
                        column: x => x.Lesson04Id,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_Lesson_Lesson05Id",
                        column: x => x.Lesson05Id,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_Lesson_Lesson06Id",
                        column: x => x.Lesson06Id,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_Lesson_Lesson07Id",
                        column: x => x.Lesson07Id,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_Lesson_Lesson08Id",
                        column: x => x.Lesson08Id,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_Lesson_Lesson09Id",
                        column: x => x.Lesson09Id,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_Lesson_Lesson10Id",
                        column: x => x.Lesson10Id,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Room_DailyPlanLessonId",
                table: "Room",
                column: "DailyPlanLessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Lesson01Id",
                table: "Room",
                column: "Lesson01Id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Lesson02Id",
                table: "Room",
                column: "Lesson02Id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Lesson03Id",
                table: "Room",
                column: "Lesson03Id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Lesson04Id",
                table: "Room",
                column: "Lesson04Id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Lesson05Id",
                table: "Room",
                column: "Lesson05Id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Lesson06Id",
                table: "Room",
                column: "Lesson06Id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Lesson07Id",
                table: "Room",
                column: "Lesson07Id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Lesson08Id",
                table: "Room",
                column: "Lesson08Id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Lesson09Id",
                table: "Room",
                column: "Lesson09Id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Lesson10Id",
                table: "Room",
                column: "Lesson10Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "DailyPlanLessons");

            migrationBuilder.DropTable(
                name: "Lesson");
        }
    }
}
