namespace Minister_Of_Time.Domain
{
    public class EventRole : BaseDomainModel
    {
        public string RoleName { get; set; } = string.Empty;

        // Permissions updated for naming consistency
        public bool CanEditCalendarEventDetails { get; set; }
        public bool CanInviteOthers { get; set; }
        public bool CanChangeLocation { get; set; }
        public bool CanChangeDateTime { get; set; }

        // Navigation property: One role can be held by many participants
        public virtual ICollection<EventParticipant> EventParticipants { get; set; } = new List<EventParticipant>();
    }
}