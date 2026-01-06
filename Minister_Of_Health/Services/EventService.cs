using Microsoft.EntityFrameworkCore;
using Minister_Of_Time.Data;
using Minister_Of_Time.Domain;
using Minister_Of_Time.Models;

namespace Minister_Of_Time.Services
{
    public class EventService
    {
        private readonly Minister_Of_TimeContext _context;

        public EventService(Minister_Of_TimeContext context)
        {
            _context = context;
        }

        public async Task<List<ActivityTimeSummary>> GetActivityDistributionAsync(int userId)
        {
            // 1. Fetch raw data first to avoid complex translation errors
            var events = await _context.CalendarEvent // Singular 'CalendarEvent'
                .Where(e => e.HostUserId == userId)
                .Include(e => e.UserActivity)
                .ToListAsync();

            // 2. Filter in memory (Safe way)
            return events
                .Where(e => e.UserActivity != null) // <--- THIS PREVENTS THE CRASH
                .GroupBy(e => e.UserActivity!.Name)
                .Select(g => new ActivityTimeSummary
                {
                    ActivityName = g.Key,
                    TotalHours = g.Sum(e => (e.EndDateTime - e.StartDateTime).TotalHours)
                })
                .ToList();
        }
    }
}