using Minister_Of_Time.Data;
using System.Collections.Generic;

namespace Minister_Of_Time.Domain
{
    public class CalendarEvent : BaseDomainModel
    {
        public string EventName { get; set; } = string.Empty;
        public string? Location { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string? CalendarType { get; set; }
        public string? Status { get; set; } = "Upcoming"; // Default status
        public string? Description { get; set; }

        // Foreign Keys 
        public string? HostUserId { get; set; }
        public int UserActivityId { get; set; }

        // Navigation Properties
        public virtual User? HostUser { get; set; }
        public virtual UserActivity? UserActivity { get; set; }
        public virtual ICollection<EventParticipant> EventParticipant { get; set; } = new List<EventParticipant>();
    }
}