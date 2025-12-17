namespace Minister_Of_Time.Domain
{
    public class EventParticipant : BaseDomainModel
    {
        public int UserId { get; set; }
        public virtual User? User { get; set; }

        // Changed from EventId to CalendarEventId
        public int CalendarEventId { get; set; }
        // Changed from Event to CalendarEvent
        public virtual CalendarEvent? CalendarEvent { get; set; }

        public int EventRoleId { get; set; }
        public virtual EventRole? EventRole { get; set; }

        public string? ParticipationStatus { get; set; }
    }
}