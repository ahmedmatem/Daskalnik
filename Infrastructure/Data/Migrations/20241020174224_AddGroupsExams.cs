using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class AddGroupsExams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Exam title"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "A brief description of the exam’s content, scope, or purpose."),
                    CreatorId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Unique identifier of the creator of the exam."),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The scheduled date and time when the exam is to be taken."),
                    Duration = table.Column<int>(type: "int", nullable: false, comment: "The time duration of the exam, measured in minutes."),
                    TotalMarks = table.Column<int>(type: "int", nullable: false, comment: "The total number of marks the exam is worth (e.g., 100 points)."),
                    PassMarks = table.Column<int>(type: "int", nullable: false, comment: "The minimum marks required to pass the exam (e.g., 40 points out of 100).\r\n"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "The current state of the exam (e.g., Scheduled, Ongoing, Completed, Graded)."),
                    Instruction = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Any special instructions or rules for taking the exam (e.g., No calculators allowed)."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamGroup",
                columns: table => new
                {
                    ExamsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GroupsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamGroup", x => new { x.ExamsId, x.GroupsId });
                    table.ForeignKey(
                        name: "FK_ExamGroup_Exams_ExamsId",
                        column: x => x.ExamsId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamGroup_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamGroup_GroupsId",
                table: "ExamGroup",
                column: "GroupsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamGroup");

            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
