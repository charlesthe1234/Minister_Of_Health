using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minister_Of_Time.Domain;

public class ActivityCategorySeed : IEntityTypeConfiguration<ActivityCategory>
{
    public void Configure(EntityTypeBuilder<ActivityCategory> builder)
    {
        builder.HasData(
            new ActivityCategory { CategoryId = 1, Name = "Meeting", StressLevel = 0.85 },
            new ActivityCategory { CategoryId = 2, Name = "Default Work", StressLevel = 0.65 },
            new ActivityCategory { CategoryId = 3, Name = "General Event", StressLevel = 0.25 },
            new ActivityCategory { CategoryId = 4, Name = "Exercise", StressLevel = -0.40 },
            new ActivityCategory { CategoryId = 5, Name = "Family Time", StressLevel = -0.55 },
            new ActivityCategory { CategoryId = 6, Name = "Hobby", StressLevel = -0.75 }
        );
    }
}