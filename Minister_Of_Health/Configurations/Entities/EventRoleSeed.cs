    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Minister_Of_Time.Domain;

    namespace Minister_Of_Time.Configurations.Entities
    {
        public class EventRoleSeed : IEntityTypeConfiguration<EventRole>
        {
            public void Configure(EntityTypeBuilder<EventRole> builder)
            {
                builder.HasData(
                    new EventRole
                    {
                        Id = 1,
                        RoleName = "Viewer",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System"
                    },
                    new EventRole
                    {
                        Id = 2,
                        RoleName = "Editor",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System"
                    }
                );
            }
        }
    }