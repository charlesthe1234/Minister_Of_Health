using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minister_Of_Time.Domain;

public class EventParticipantSeed : IEntityTypeConfiguration<EventParticipant>
{
    public void Configure(EntityTypeBuilder<EventParticipant> builder)
    {
        builder.HasData(
            // User1 and User2 attending Admin's Audit
            new EventParticipant { Id = 1, UserId = "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d", CalendarEventId = 1, EventRoleId = 2, ParticipationStatus = "Accepted" },
            new EventParticipant { Id = 2, UserId = "f9e8d7c6-b5a4-4f3e-2d1c-0b9a8f7e6d5c", CalendarEventId = 1, EventRoleId = 2, ParticipationStatus = "Accepted" },

            // Admin attending User1's Family Reunion
            new EventParticipant { Id = 3, UserId = "3781efa7-66dc-47f0-860f-e506d04102e4", CalendarEventId = 2, EventRoleId = 2, ParticipationStatus = "Pending" },

            // Admin and User1 attending User2's Tournament
            new EventParticipant { Id = 4, UserId = "3781efa7-66dc-47f0-860f-e506d04102e4", CalendarEventId = 3, EventRoleId = 2, ParticipationStatus = "Accepted" },
            new EventParticipant { Id = 5, UserId = "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d", CalendarEventId = 3, EventRoleId = 2, ParticipationStatus = "Rejected" }
        );
    }
}