using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Minister_Of_Time.Migrations
{
    /// <inheritdoc />
    public partial class CalendarEventPagefix1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CalendarEvent",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CalendarEvent");
        }
    }
}
