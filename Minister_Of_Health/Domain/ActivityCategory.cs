using System.ComponentModel.DataAnnotations;
using Minister_Of_Time.Data;

namespace Minister_Of_Time.Domain
{
    public class ActivityCategory : BaseDomainModel
    {
        [Key] // Explicitly sets this as the Primary Key
        public int CategoryId { get; set; } 

        public int StressLevel { get; set; } 
        public int FatigueLevel { get; set; }
        public int CalendarEventId { get; set; }
        public string UserId { get; set; } 
        public virtual User? User { get; set; }
        
        // Navigation to events
        public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();
    }
}