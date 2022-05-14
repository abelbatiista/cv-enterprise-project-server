using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Model.Migrations
{
    public partial class SkillsList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Skills_UserDetailsId",
                table: "Skills");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_UserDetailsId",
                table: "Skills",
                column: "UserDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Skills_UserDetailsId",
                table: "Skills");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_UserDetailsId",
                table: "Skills",
                column: "UserDetailsId",
                unique: true);
        }
    }
}
