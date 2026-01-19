using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minister_Of_Time.Domain;

public class CloseConnectionSeed : IEntityTypeConfiguration<CloseConnection>
{
    public void Configure(EntityTypeBuilder<CloseConnection> builder)
    {
        builder.HasData(
            new CloseConnection
            {
                Id = 1,
                RequesterUserId = "3781efa7-66dc-47f0-860f-e506d04102e4", // Admin
                TargetUserId = "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d", // User 1
                Status = "Accepted",
                TargetUserEmail = "user1@chronos.com"
            },
            new CloseConnection
            {
                Id = 2,
                RequesterUserId = "a1b2c3d4-e5f6-4a5b-8c9d-0e1f2a3b4c5d", // User 1
                TargetUserId = "f9e8d7c6-b5a4-4f3e-2d1c-0b9a8f7e6d5c", // User 2
                Status = "Accepted",
                TargetUserEmail = "user2@aeon.com"
            }
        );
    }
}