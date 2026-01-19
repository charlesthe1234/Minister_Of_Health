using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minister_Of_Time.Domain;

public class EventRoleSeed : IEntityTypeConfiguration<EventRole>
{
    public void Configure(EntityTypeBuilder<EventRole> builder)
    {
        builder.HasData(
            new EventRole { Id = 1, RoleName = "Viewer", CanEditCalendarEventDetails = false, CanInviteOthers = false, CanChangeLocation = false, CanChangeDateTime = false },
            new EventRole { Id = 2, RoleName = "Editor", CanEditCalendarEventDetails = true, CanInviteOthers = true, CanChangeLocation = true, CanChangeDateTime = true }
        );
    }
}