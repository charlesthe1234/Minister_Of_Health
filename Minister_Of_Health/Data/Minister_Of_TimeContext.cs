using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Minister_Of_Time.Domain;
using Minister_Of_Time.Configurations.Entities;



namespace Minister_Of_Time.Data
{
    public class Minister_Of_TimeContext : IdentityDbContext<User>
    {
        public Minister_Of_TimeContext(DbContextOptions<Minister_Of_TimeContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<EventRole> EventRole { get; set; } = default!;
        public DbSet<CalendarEvent> CalendarEvent { get; set; } = default!;
        public DbSet<EventParticipant> EventParticipant { get; set; } = default!;
        public DbSet<UserActivity> UserActivity { get; set; } = default!;
        public DbSet<CloseConnection> CloseConnection { get; set; } = default!;
        public DbSet<ActivityType> ActivityCategories { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- 1. CASCADE DELETE FIXES (Crucial for SQL Server) ---

            modelBuilder.Entity<CloseConnection>(entity => {
                entity.HasOne(d => d.User).WithMany().HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(d => d.ConnectedUser).WithMany().HasForeignKey(d => d.ConnectedUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CalendarEvent>(entity => {
                entity.HasOne(d => d.HostUser).WithMany().HasForeignKey(d => d.HostUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<EventParticipant>(entity => {
                entity.HasOne(d => d.User).WithMany().HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
            });

            // --- 2. APPLY DATA SEEDS ---

            modelBuilder.ApplyConfiguration(new EventRoleSeed()); // For Event Roles (Organizer, etc)
            modelBuilder.ApplyConfiguration(new UserRoleSeed()); // Identity Roles (Admin, etc)
            modelBuilder.ApplyConfiguration(new UserSeed()); // The actual Users
            modelBuilder.ApplyConfiguration(new UserRoleAssignmentSeed()); // Linking Users to Roles

            // Feature seeds
            modelBuilder.ApplyConfiguration(new ActivityTypeSeed());
            modelBuilder.ApplyConfiguration(new UserActivitySeed());
            modelBuilder.ApplyConfiguration(new CalendarEventSeed());
        }

        // Optional: Automate DateCreated/DateUpdated timestamps
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries()
                .Where(q => q.Entity is BaseDomainModel &&
                       (q.State == EntityState.Added || q.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}