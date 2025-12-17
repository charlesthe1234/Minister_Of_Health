namespace Minister_Of_Time.Domain
{
    public class User : BaseDomainModel
    {
        public required string Name { get; set; }
        public required string PasswordHash { get; set; }
        public string? Email { get; set; }
        public string? ContactNumber { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Address { get; set; }
        public required string Gender { get; set; }

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