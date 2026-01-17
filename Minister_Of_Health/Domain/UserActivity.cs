using Minister_Of_Time.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Minister_Of_Time.Domain
{
    public class UserActivity : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public string? Description { get; set; }
        public int DefaultStressValue { get; set; }

        // Relationship: Activity belongs to a User (the creator)
        public String UserId { get; set; }
        public String? ActivityType { get; set; }
        public int CategoryId { get; set; } // The actual database column

        [ForeignKey("CategoryId")]
        public virtual User? User { get; set; }

        // Optional: Navigation property to see all events using this activity
        public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();
    }
}