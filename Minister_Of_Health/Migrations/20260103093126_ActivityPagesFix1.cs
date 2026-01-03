using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Minister_Of_Time.Migrations
{
    /// <inheritdoc />
    public partial class ActivityPagesFix1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_AspNetUsers_UserId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_CalendarEvent_Activity_ActivityId",
                table: "CalendarEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activity",
                table: "Activity");

            migrationBuilder.RenameTable(
                name: "Activity",
                newName: "UserActivity");

            migrationBuilder.RenameColumn(
                name: "ActivityId",
                table: "CalendarEvent",
                newName: "UserActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_CalendarEvent_ActivityId",
                table: "CalendarEvent",
                newName: "IX_CalendarEvent_UserActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_UserId",
                table: "UserActivity",
                newName: "IX_UserActivity_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserActivity",
                table: "UserActivity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CalendarEvent_UserActivity_UserActivityId",
                table: "CalendarEvent",
                column: "UserActivityId",
                principalTable: "UserActivity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivity_AspNetUsers_UserId",
                table: "UserActivity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalendarEvent_UserActivity_UserActivityId",
                table: "CalendarEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivity_AspNetUsers_UserId",
                table: "UserActivity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserActivity",
                table: "UserActivity");

            migrationBuilder.RenameTable(
                name: "UserActivity",
                newName: "Activity");

            migrationBuilder.RenameColumn(
                name: "UserActivityId",
                table: "CalendarEvent",
                newName: "ActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_CalendarEvent_UserActivityId",
                table: "CalendarEvent",
                newName: "IX_CalendarEvent_ActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_UserActivity_UserId",
                table: "Activity",
                newName: "IX_Activity_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activity",
                table: "Activity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_AspNetUsers_UserId",
                table: "Activity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CalendarEvent_Activity_ActivityId",
                table: "CalendarEvent",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
