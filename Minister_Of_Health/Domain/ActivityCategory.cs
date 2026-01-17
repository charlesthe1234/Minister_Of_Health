using System.ComponentModel.DataAnnotations;

namespace Minister_Of_Time.Domain
{
    public class ActivityCategory : BaseDomainModel
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public double StressLevel { get; set; } 

        public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();
    }
}