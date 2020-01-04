using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Replacement = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_DailyPlans_DailyPlanId",
                        column: x => x.DailyPlanId,
                        principalTable: "DailyPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Lessons_Lesson01Id",
                        column: x => x.Lesson01Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Lessons_Lesson02Id",
                        column: x => x.Lesson02Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Lessons_Lesson03Id",
                        column: x => x.Lesson03Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Lessons_Lesson04Id",
                        column: x => x.Lesson04Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Lessons_Lesson05Id",
                        column: x => x.Lesson05Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Lessons_Lesson06Id",
                        column: x => x.Lesson06Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Lessons_Lesson07Id",
                        column: x => x.Lesson07Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Lessons_Lesson08Id",
                        column: x => x.Lesson08Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Lessons_Lesson09Id",
                        column: x => x.Lesson09Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Lessons_Lesson10Id",
                        column: x => x.Lesson10Id,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "DailyPlans");

            migrationBuilder.DropTable(
                name: "Lessons");
        }
    }
}
