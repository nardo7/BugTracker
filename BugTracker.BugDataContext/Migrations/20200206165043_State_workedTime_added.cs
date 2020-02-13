using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.BugDataContext.Migrations
{
    public partial class State_workedTime_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "WorkedTime",
                table: "Bugs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "stateId",
                table: "Bugs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_stateId",
                table: "Bugs",
                column: "stateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_States_stateId",
                table: "Bugs",
                column: "stateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_States_stateId",
                table: "Bugs");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_stateId",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "WorkedTime",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "stateId",
                table: "Bugs");
        }
    }
}
