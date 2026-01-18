using System.ComponentModel.DataAnnotations;

namespace Minister_Of_Time.Domain
{
    public class ActivityType : BaseDomainModel
    {
        [Key]
        public int ActivityTypeId { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public double StressLevel { get; set; } 

        public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();
    }
}