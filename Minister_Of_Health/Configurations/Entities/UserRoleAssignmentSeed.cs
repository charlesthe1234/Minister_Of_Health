//THIS IS NEEDED TO SEED SECURITY IDENTIY ROLES TO USERS SO 

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Minister_Of_Time.Configurations.Entities 
{
    public class UserRoleAssignmentSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba", // From your UserRoleSeed
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"  // From your UserSeed
                }
            );
        }
    }
}