using Microsoft.Extensions.Logging;

namespace Minister_Of_Time.Domain
{
    public class StressRecord : BaseDomainModel
    {
        public int StressLevel { get; set; } // Range like 1-10
        public int FatigueLevel { get; set; }

        // Foreign Key IDs
        public int UserId { get; set; }
        public int CalendarEventId { get; set; }

        // Navigation Properties 
        // These allow EF to "Join" the tables automatically
        public virtual User? User { get; set; }
        public virtual CalendarEvent? CalendarEvent { get; set; }
    }
}