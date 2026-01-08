using System.ComponentModel.DataAnnotations.Schema;
using Minister_Of_Time.Data;

namespace Minister_Of_Time.Domain
{
    public class CloseConnection : BaseDomainModel
    {
        // The User who "owns" the connection
        public String UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User? User { get; set; }

        // The person they are connected to
        public string ConnectedUserId { get; set; }

        [ForeignKey("ConnectedUserId")]
        public virtual User? ConnectedUser { get; set; }

        public string? ConnectionType { get; set; }
        public bool ViewLifeCalendar { get; set; }
        public bool ViewWorkCalendar { get; set; }
    }
}