using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApiProject.Migrations
{
    public partial class AddGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "People",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_PersonId",
                table: "Animals",
                column: "PersonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_People_PersonId",
                table: "Animals",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_People_PersonId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_PersonId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "People");
        }
    }
}
