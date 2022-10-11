using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailSendingApi.Migrations
{
    public partial class EmailsTableNameChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipients_Emenils_EmailId",
                table: "Recipients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emenils",
                table: "Emenils");

            migrationBuilder.RenameTable(
                name: "Emenils",
                newName: "Emails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emails",
                table: "Emails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipients_Emails_EmailId",
                table: "Recipients",
                column: "EmailId",
                principalTable: "Emails",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipients_Emails_EmailId",
                table: "Recipients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emails",
                table: "Emails");

            migrationBuilder.RenameTable(
                name: "Emails",
                newName: "Emenils");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emenils",
                table: "Emenils",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipients_Emenils_EmailId",
                table: "Recipients",
                column: "EmailId",
                principalTable: "Emenils",
                principalColumn: "Id");
        }
    }
}
