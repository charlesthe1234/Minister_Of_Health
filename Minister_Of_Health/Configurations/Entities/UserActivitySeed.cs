using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minister_Of_Time.Domain;

namespace Minister_Of_Time.Configurations.Entities
{
    public class UserActivitySeed : IEntityTypeConfiguration<UserActivity>
    {
        public void Configure(EntityTypeBuilder<UserActivity> builder)
        {
            builder.HasData(
                new UserActivity
                {
                    Id = 1,
                    Name = "General Activity",
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4", // Link to Admin
                    DefaultStressValue = 5,
                    DateCreated = DateTime.Now,
                    CreatedBy = "System"
                }
            );
        }
    }
}