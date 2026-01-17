using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minister_Of_Time.Domain;

public class ActivityTypeSeed : IEntityTypeConfiguration<ActivityType>
{
    public void Configure(EntityTypeBuilder<ActivityType> builder)
    {
        builder.HasData(
            new ActivityType { ActivityTypeId = 1, TypeName = "Meeting", StressLevel = 0.85 },
            new ActivityType { ActivityTypeId = 2, TypeName = "Default Work", StressLevel = 0.65 },
            new ActivityType { ActivityTypeId = 3, TypeName = "General Event", StressLevel = 0.25 },
            new ActivityType { ActivityTypeId = 4, TypeName = "Exercise", StressLevel = -0.40 },
            new ActivityType { ActivityTypeId = 5, TypeName = "Family Time", StressLevel = -0.55 },
            new ActivityType { ActivityTypeId = 6, TypeName = "Hobby", StressLevel = -0.75 }
        );
    }
}