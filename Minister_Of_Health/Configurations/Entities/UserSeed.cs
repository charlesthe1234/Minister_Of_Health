using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minister_Of_Time.Data;

public class UserSeed : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        var hasher = new PasswordHasher<User>();
        builder.HasData(
            new User
            {
                Id = "d666a2c8-3d9c-4ca3-9354-e33305c23414", // Matches your screenshot
                Email = "ma@local.com",
                NormalizedEmail = "MA@LOCAL.COM",
                Name = "Charles",
                UserName = "ma@local.com",
                NormalizedUserName = "MA@LOCAL.COM",
                PasswordHash = hasher.HashPassword(null, "Ma1234567!"),
                EmailConfirmed = true,
                Gender = "Male"
            },
            new User
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                Name = "Charles Admin",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                Gender = "Male"
            },
            new User
            {
                Id = "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d",
                Email = "user1@chronos.com",
                NormalizedEmail = "USER1@CHRONOS.COM",
                Name = "Lady Time",
                UserName = "user1@chronos.com",
                NormalizedUserName = "USER1@CHRONOS.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                Gender = "Female"
            },
            new User
            {
                Id = "f9e8d7c6-b5a4-4f3e-2d1c-0b9a8f7e6d5c",
                Email = "user2@aeon.com",
                NormalizedEmail = "USER2@AEON.COM",
                Name = "Sir Aeon",
                UserName = "user2@aeon.com",
                NormalizedUserName = "USER2@AEON.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                Gender = "Male"
            }
        );
    }
}