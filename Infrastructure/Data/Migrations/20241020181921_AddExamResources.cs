using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class AddExamResources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamsAndResources",
                columns: table => new
                {
                    ResourceId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Part of primary key"),
                    ExamId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Part of primary key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamsAndResources", x => new { x.ExamId, x.ResourceId });
                    table.ForeignKey(
                        name: "FK_ExamsAndResources_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamsAndResources_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Many-to-many mapping table for Exam and Resource.");

            migrationBuilder.CreateIndex(
                name: "IX_ExamsAndResources_ResourceId",
                table: "ExamsAndResources",
                column: "ResourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamsAndResources");
        }
    }
}
