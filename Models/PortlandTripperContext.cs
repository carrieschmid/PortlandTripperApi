using Microsoft.EntityFrameworkCore;

namespace PortlandTripper.Models
{
    public class PortlandTripperContext : DbContext
    {
        public PortlandTripperContext(DbContextOptions<PortlandTripperContext> options)
            : base(options)
        {
        }

        public DbSet<TripAdvisor> TripAdvisor { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.Entity<TripAdvisor>()
                .HasData(
                    new TripAdvisor 
                    {
                        PortlandMorningId = 1,
                        Name = "Extracto",
                        Hours = "6am to 6pm",
                        Address = "2921 NE Killingsworth St, Portland, OR 97211",
                        Cost = 8,
                        Description = "Local, award-winning coffe roaster."
                    },
                    new TripAdvisor 
                    {
                        PortlandMorningId = 2,
                        Name = "Southeast Grind",
                        Hours = "24 hours",
                        Address = "1223 SE Powell, Portland, OR 97202",
                        Cost = 8,
                        Description = "24-hour cafe that also serves breakfast."
                    },
                
                    new TripAdvisor
                    {
                        PortlandAfternoonId = 1,
                        Name = "QuarterWorld",
                        Hours = "3pm - 1am",
                        Address = "4811 SE Hawthorne Bvld., Portland, OR 97215",
                        Cost = 15,
                        Description = "Arcade games and drinks."
                    },
                    new TripAdvisor 
                    {
                        PortlandAfternoonId = 2,
                        Name = "Japanese Garden",
                        Hours = "10am-4pm",
                        Address = "611 SW Kingston Ave., Portland OR 97205",
                        Cost = 17,
                        Description = "Japanese-themed garden with special events."
                    },

                    new TripAdvisor
                    {
                        PortlandEveningId = 1,
                        Name = "Hawthorne Theater and Lounge",
                        Hours = "6:30pm-2am",
                        Address = "1507 SE 39th Ave., Portland OR 97214",
                        Cost = 18,
                        Description = "Bands and drinks."
                    },
                    new PortlandEvening 
                    {
                        PortlandEveningId = 2,
                        Name = "Crystal Ballroom",
                        Hours = "6:30pm-2am",
                        Address = "1332 W Burnside, Portland OR 97209",
                        Cost = 70,
                        Description = "Bands and drinks."
                    }

                    

                );
            }
    }
}