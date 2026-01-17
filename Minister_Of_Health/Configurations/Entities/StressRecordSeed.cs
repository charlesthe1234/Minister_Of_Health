using Microsoft.EntityFrameworkCore;
using Minister_Of_Time.Domain;

namespace Minister_Of_Time.Configurations.Entities
{
    public class ActivityCategorySeed : IEntityTypeConfiguration<ActivityCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ActivityCategory> builder)
        {
        }
    }
}
