using System.Diagnostics;

namespace Minister_Of_Time.Domain
{
    public class CalendarEvent : BaseDomainModel
    {
        public string EventName { get; set; } = string.Empty;
        public string? Location { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string? CalendarType { get; set; }
        public string? Status { get; set; }

        // Foreign Keys 
        public int HostUserId { get; set; }
        public int ActivityId { get; set; }

        // Navigation Properties
        public virtual User? HostUser { get; set; } // Link back to the User who is hosting
        public virtual UserActivity? Activity { get; set; }
    }
}