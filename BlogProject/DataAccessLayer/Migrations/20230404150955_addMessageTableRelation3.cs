using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class addMessageTableRelation3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MessageSenderID",
                table: "Messages2",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MessageReceiverID",
                table: "Messages2",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_MessageReceiverID",
                table: "Messages2",
                column: "MessageReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_MessageSenderID",
                table: "Messages2",
                column: "MessageSenderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages2_Writers_MessageReceiverID",
                table: "Messages2",
                column: "MessageReceiverID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages2_Writers_MessageSenderID",
                table: "Messages2",
                column: "MessageSenderID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages2_Writers_MessageReceiverID",
                table: "Messages2");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages2_Writers_MessageSenderID",
                table: "Messages2");

            migrationBuilder.DropIndex(
                name: "IX_Messages2_MessageReceiverID",
                table: "Messages2");

            migrationBuilder.DropIndex(
                name: "IX_Messages2_MessageSenderID",
                table: "Messages2");

            migrationBuilder.AlterColumn<string>(
                name: "MessageSenderID",
                table: "Messages2",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MessageReceiverID",
                table: "Messages2",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
