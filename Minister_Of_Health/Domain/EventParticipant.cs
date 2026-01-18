using Minister_Of_Time.Data;

namespace Minister_Of_Time.Domain
{
    public class EventParticipant : BaseDomainModel
    {
        public String? UserId { get; set; } // Make nullable; we might not have a UserId until they accept
        public virtual User? User { get; set; }

        public int CalendarEventId { get; set; }
        public virtual CalendarEvent? CalendarEvent { get; set; }

        public int EventRoleId { get; set; } // Link to your EventRole table
        public virtual EventRole EventRole { get; set; }

        // --- NEW FIELDS ---
        public string? InviteeEmail { get; set; } // To track the invite by email
        public string? ParticipationStatus { get; set; } // "Pending", "Accepted", "Rejected, Left"
        public string? CustomActivity { get; set; } // The invitee's chosen activity, note to self to save under the event participants own activities
        public string? CustomCategory { get; set; } // The invitee's chosen category (Work/Life)
    }
}