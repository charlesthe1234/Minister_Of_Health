using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Minister_Of_Time.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Minister_Of_Time.Data
{
    public class Minister_Of_TimeContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public Minister_Of_TimeContext (DbContextOptions<Minister_Of_TimeContext> options)
            : base(options)
        {
        }

        public DbSet<Minister_Of_Time.Domain.User> User { get; set; } = default!;
        public DbSet<Minister_Of_Time.Domain.EventRole> EventRole { get; set; } = default!;
        public DbSet<Minister_Of_Time.Domain.CalendarEvent> CalendarEvent { get; set; } = default!;
        public DbSet<Minister_Of_Time.Domain.EventParticipant> EventParticipant { get; set; } = default!;
        public DbSet<Minister_Of_Time.Domain.UserActivity> Activity { get; set; } = default!;
        public DbSet<Minister_Of_Time.Domain.CloseConnection> CloseConnection { get; set; } = default!;
        public DbSet<Minister_Of_Time.Domain.StressRecord> StressRecord { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Fix CloseConnection (Multiple paths to User)
            modelBuilder.Entity<CloseConnection>(entity => {
                entity.HasOne(d => d.User).WithMany().HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(d => d.ConnectedUser).WithMany().HasForeignKey(d => d.ConnectedUserId).OnDelete(DeleteBehavior.Restrict);
            });

            // 2. Fix CalendarEvent (HostUser loop)
            modelBuilder.Entity<CalendarEvent>(entity => {
                entity.HasOne(d => d.HostUser).WithMany().HasForeignKey(d => d.HostUserId).OnDelete(DeleteBehavior.Restrict);
            });

            // 3. Fix EventParticipant (The final cycle error you saw)
            modelBuilder.Entity<EventParticipant>(entity => {
                entity.HasOne(d => d.User).WithMany().HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<StressRecord>(entity =>
            {
                entity.HasOne(d => d.User).WithMany().HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
            });

        }
    }
}
