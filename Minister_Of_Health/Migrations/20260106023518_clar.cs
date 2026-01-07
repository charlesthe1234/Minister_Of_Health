using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Minister_Of_Time.Migrations
{
    /// <inheritdoc />
    public partial class clar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventParticipant_EventRole_EventRoleId",
                table: "EventParticipant");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "EventParticipant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EventRoleId",
                table: "EventParticipant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CustomActivity",
                table: "EventParticipant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomCategory",
                table: "EventParticipant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InviteeEmail",
                table: "EventParticipant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EventParticipant_EventRole_EventRoleId",
                table: "EventParticipant",
                column: "EventRoleId",
                principalTable: "EventRole",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventParticipant_EventRole_EventRoleId",
                table: "EventParticipant");

            migrationBuilder.DropColumn(
                name: "CustomActivity",
                table: "EventParticipant");

            migrationBuilder.DropColumn(
                name: "CustomCategory",
                table: "EventParticipant");

            migrationBuilder.DropColumn(
                name: "InviteeEmail",
                table: "EventParticipant");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "EventParticipant",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EventRoleId",
                table: "EventParticipant",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EventParticipant_EventRole_EventRoleId",
                table: "EventParticipant",
                column: "EventRoleId",
                principalTable: "EventRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
