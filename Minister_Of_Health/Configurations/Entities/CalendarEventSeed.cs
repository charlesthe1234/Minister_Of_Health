using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minister_Of_Time.Domain;

namespace Minister_Of_Time.Configurations.Entities
{
    public class CalendarEventSeed : IEntityTypeConfiguration<CalendarEvent>
    {
        public void Configure(EntityTypeBuilder<CalendarEvent> builder)
        {
            builder.HasData(
                new CalendarEvent
                {
                    Id = 1,
                    EventName = "Project Launch Meeting",
                    Location = "Conference Room A",
                    StartDateTime = new DateTime(2026, 1, 10, 9, 0, 0),
                    EndDateTime = new DateTime(2026, 1, 10, 11, 0, 0),
                    CalendarType = "Work",
                    HostUserId = "3781efa7-66dc-47f0-860f-e506d04102e4", // Admin
                    UserActivityId = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now
                },
                new CalendarEvent
                {
                    Id = 2,
                    EventName = "Gym Session",
                    Location = "Local Fitness Center",
                    StartDateTime = new DateTime(2026, 1, 11, 17, 30, 0),
                    EndDateTime = new DateTime(2026, 1, 11, 19, 0, 0),
                    CalendarType = "Life",
                    HostUserId = "3781efa7-66dc-47f0-860f-e506d04102e4", // Admin
                    UserActivityId = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now
                },
                new CalendarEvent
                {
                    Id = 3,
                    EventName = "User's Private Workshop",
                    Location = "Online",
                    StartDateTime = new DateTime(2026, 1, 12, 14, 0, 0),
                    EndDateTime = new DateTime(2026, 1, 12, 15, 30, 0),
                    CalendarType = "Work",
                    HostUserId = "4781efa7-66dc-47f0-860f-e506d04102e5", // Regular User
                    UserActivityId = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now
                }
            );
        }
    }
}