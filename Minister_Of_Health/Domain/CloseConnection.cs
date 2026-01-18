using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Minister_Of_Time.Data;

namespace Minister_Of_Time.Domain
{
    public class CloseConnection : BaseDomainModel
    {
        // The person who SENT the invite
        public string RequesterUserId { get; set; }
        [ForeignKey("RequesterUserId")]
        public virtual User? RequesterUser { get; set; }

        // The person RECEIVING the invite
        public string TargetUserId { get; set; }
        [ForeignKey("TargetUserId")]
        public virtual User? TargetUser { get; set; }

        // Pending, Accepted, Rejected
        public string Status { get; set; } = "Pending";

        // Optional: Helper to store email if User object isn't loaded immediately
        public string? TargetUserEmail { get; set; }
    }
}