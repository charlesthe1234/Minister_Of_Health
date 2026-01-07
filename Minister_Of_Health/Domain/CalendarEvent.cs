using System.Diagnostics;
using Minister_Of_Time.Data;
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
        public string? Description { get; set; }

        // Foreign Keys 
        public String HostUserId { get; set; }
        public int UserActivityId { get; set; }

        // Navigation Properties
        public virtual User? HostUser { get; set; } // Link back to the User who is hosting
        public virtual UserActivity? UserActivity { get; set; }
    }
}