using Microsoft.AspNetCore.Identity;

namespace Minister_Of_Time.Domain
{
    public class User : IdentityUser<int>
    {
        public required string? Name { get; set; } = string.Empty;
        public string? ContactNumber { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Address { get; set; }
        public required string? Gender { get; set; } = string.Empty;

        // This property is NOT stored in the DB, it's calculated on the fly
        public int? Age
        {
            get
            {
                if (!Birthday.HasValue) return null;
                var today = DateTime.Today;
                var age = today.Year - Birthday.Value.Year;
                if (Birthday.Value.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}