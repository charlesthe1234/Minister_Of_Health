using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Minister_Of_Time.Domain;

namespace Minister_Of_Time.Data
{
    public class Minister_Of_TimeContext : DbContext
    {
        public Minister_Of_TimeContext (DbContextOptions<Minister_Of_TimeContext> options)
            : base(options)
        {
        }

        public DbSet<Minister_Of_Time.Domain.User> User { get; set; } = default!;
        public DbSet<Minister_Of_Time.Domain.EventRole> EventRole { get; set; } = default!;
        public DbSet<Minister_Of_Time.Domain.CalendarEvent> CalendarEvent { get; set; } = default!;
        public DbSet<Minister_Of_Time.Domain.EventParticipant> EventParticipant { get; set; } = default!;
        public DbSet<Minister_Of_Time.Domain.Activity> Activity { get; set; } = default!;
        public DbSet<Minister_Of_Time.Domain.CloseConnection> CloseConnection { get; set; } = default!;
        public DbSet<Minister_Of_Time.Domain.StressRecord> StressRecord { get; set; } = default!;
    }
}
