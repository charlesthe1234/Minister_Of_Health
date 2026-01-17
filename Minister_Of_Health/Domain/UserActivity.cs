using Minister_Of_Time.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Minister_Of_Time.Domain
{
    public class UserActivity : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public string? Description { get; set; }

        // 1. Fixed User Relationship
        public string UserId { get; set; }
        [ForeignKey("UserId")] // Links string UserId to string User.Id
        public virtual User? User { get; set; }
        public string? Category { get; set; }
        public DateTime RecentRecord { get; set; }
        public int ActivityTypeId { get; set; }
        [ForeignKey("ActivityTypeId")]
        public virtual ActivityType? ActivityType { get; set; }
        public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();
    }
}