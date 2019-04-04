using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApiProject.Migrations
{
    public partial class OneToManyPpeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Animals_PersonId",
                table: "Animals");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_PersonId",
                table: "Animals",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Animals_PersonId",
                table: "Animals");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_PersonId",
                table: "Animals",
                column: "PersonId",
                unique: true);
        }
    }
}
