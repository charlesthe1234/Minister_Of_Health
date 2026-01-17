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

        // 2. Fixed Category Relationship
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")] // Links int CategoryId to int ActivityCategory.CategoryId
        public virtual ActivityCategory? ActivityCategory { get; set; }

        public string? ActivityType { get; set; }
        public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();
    }
}