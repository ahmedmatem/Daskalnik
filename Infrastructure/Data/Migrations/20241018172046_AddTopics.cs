using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class AddTopics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Topic name"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Topic description."),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Topic contents items separated each in a new line."),
                    CreatorId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Unique identifier of the creator of the topic."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupTopic",
                columns: table => new
                {
                    GroupsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TopicsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupTopic", x => new { x.GroupsId, x.TopicsId });
                    table.ForeignKey(
                        name: "FK_GroupTopic_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupTopic_Topics_TopicsId",
                        column: x => x.TopicsId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupTopic_TopicsId",
                table: "GroupTopic",
                column: "TopicsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupTopic");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
