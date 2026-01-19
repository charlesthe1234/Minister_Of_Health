using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minister_Of_Time.Domain;

public class UserActivitySeed : IEntityTypeConfiguration<UserActivity>
{
    public void Configure(EntityTypeBuilder<UserActivity> builder)
    {
        builder.HasData(
            // Admin's Activities
            new UserActivity { Id = 1, Name = "Time Management", UserId = "3781efa7-66dc-47f0-860f-e506d04102e4", ActivityTypeId = 1, Category = "Work" },
            new UserActivity { Id = 2, Name = "Clock Repair", UserId = "3781efa7-66dc-47f0-860f-e506d04102e4", ActivityTypeId = 3, Category = "Hobby" },

            // User1's Activities
            new UserActivity { Id = 3, Name = "Strategy Planning", UserId = "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d", ActivityTypeId = 1, Category = "Work" },
            new UserActivity { Id = 4, Name = "Family Brunch", UserId = "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d", ActivityTypeId = 5, Category = "Life" },

            // User2's Activities
            new UserActivity { Id = 5, Name = "Field Research", UserId = "f9e8d7c6-b5a4-4f3e-2d1c-0b9a8f7e6d5c", ActivityTypeId = 1, Category = "Work" },
            new UserActivity { Id = 6, Name = "Archery", UserId = "f9e8d7c6-b5a4-4f3e-2d1c-0b9a8f7e6d5c", ActivityTypeId = 3, Category = "Hobby" }
        );
    }
}