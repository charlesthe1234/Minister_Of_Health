using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Minister_Of_Time.Migrations
{
    /// <inheritdoc />
    public partial class Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "UserActivity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f2f02ec-9695-4d51-8fbf-74276a260f5d", "AQAAAAIAAYagAAAAEJY5qBalBhXEjtfkxyVkNUUg1sk+scrAJ1B4BAsMBnToyvE1BFAZ4IhLwzHQ4cd1Aw==", "1cbd3716-17cb-401c-b171-ead2e2743032" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4781efa7-66dc-47f0-860f-e506d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62a3527e-5bd3-491c-b11d-763b653533e9", "AQAAAAIAAYagAAAAEHlrt60s0mvFfGG5Np6zqWRGlgAwzVJhDQHCcSyfnHoHCSBBK2jW8Hsr1NwfVij+tw==", "8ac296a8-37ea-4ea5-8646-a3c27bc96f40" });

            migrationBuilder.UpdateData(
                table: "CalendarEvent",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 19, 16, 55, 398, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "CalendarEvent",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 19, 16, 55, 398, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "CalendarEvent",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 19, 16, 55, 398, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "EventRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 19, 16, 55, 115, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "EventRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 19, 16, 55, 115, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "EventRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 19, 16, 55, 115, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "UserActivity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "DateCreated" },
                values: new object[] { null, new DateTime(2026, 1, 10, 19, 16, 55, 398, DateTimeKind.Local).AddTicks(3384) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "UserActivity");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69ff4c39-4452-4b8c-86e4-77b7329504c5", "AQAAAAIAAYagAAAAEPQEGAGJihIZAWqSrcxKcxKu3BoCg4CfjQAGItbRKSEWNFy7/CDGPoG6nsuhMuXYIg==", "0c654046-1249-4138-9243-b55504ea90e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4781efa7-66dc-47f0-860f-e506d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa4f55b8-5c37-4f90-870d-431290c19351", "AQAAAAIAAYagAAAAECRqlRhbk8U8F1uPksQYstz9eXZwgmF6NA+BzcDO1FOpAkqDnDCfjBiWoRjl+7iNYA==", "6fc0f52c-ead8-4b81-8834-39ad58deb859" });

            migrationBuilder.UpdateData(
                table: "CalendarEvent",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 15, 19, 40, 252, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "CalendarEvent",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 15, 19, 40, 252, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "CalendarEvent",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 15, 19, 40, 252, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "EventRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 15, 19, 39, 990, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "EventRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 15, 19, 39, 990, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "EventRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 15, 19, 39, 990, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "UserActivity",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2026, 1, 10, 15, 19, 40, 252, DateTimeKind.Local).AddTicks(9221));
        }
    }
}
