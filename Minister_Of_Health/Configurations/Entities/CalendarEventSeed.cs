using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minister_Of_Time.Domain;

public class CalendarEventSeed : IEntityTypeConfiguration<CalendarEvent>
{
    public void Configure(EntityTypeBuilder<CalendarEvent> builder)
    {
        builder.HasData(
            new CalendarEvent
            {
                Id = 1,
                EventName = "Annual Time Audit",
                Location = "The Great Hall",
                StartDateTime = new DateTime(2026, 2, 1, 9, 0, 0),
                EndDateTime = new DateTime(2026, 2, 1, 12, 0, 0),
                CalendarType = "Work",
                Status = "Upcoming",
                HostUserId = "3781efa7-66dc-47f0-860f-e506d04102e4", // Admin
                UserActivityId = 1
            },
            new CalendarEvent
            {
                Id = 2,
                EventName = "Royal Family Reunion",
                Location = "Gardens",
                StartDateTime = new DateTime(2026, 2, 5, 12, 0, 0),
                EndDateTime = new DateTime(2026, 2, 5, 18, 0, 0),
                CalendarType = "Life",
                Status = "Upcoming",
                HostUserId = "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d", // User1
                UserActivityId = 4
            },
            new CalendarEvent
            {
                Id = 3,
                EventName = "Tournament of Hours",
                Location = "Arena",
                StartDateTime = new DateTime(2026, 2, 10, 15, 0, 0),
                EndDateTime = new DateTime(2026, 2, 10, 17, 0, 0),
                CalendarType = "Hobby",
                Status = "Upcoming",
                HostUserId = "f9e8d7c6-b5a4-4f3e-2d1c-0b9a8f7e6d5c", // User2
                UserActivityId = 6
            }
        );
    }
}