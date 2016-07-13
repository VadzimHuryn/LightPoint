using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Day4WebApi.Models;

namespace Day4WebApi.Models
{
    public static class SampleDataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<EventsContext>();

            if (!context.Locations.Any())
            {
                var Location1 = new Location
                {
                    Name = "Location1",
                    Lat = 2,
                    Long = 5
                };

                Location1.Events.Add(new Event
                {
                    Name = "Event 1",
                    Description = "Good event 1"
                });

                Location1.Events.Add(new Event
                {
                    Name = "Event 2",
                    Description = "Good event 2"

                });

                Location1.Events.Add(new Event
                {
                    Name = "Event 3",
                    Description = "Good event 3"
                });

                context.Locations.Add(Location1);

                context.SaveChanges();
            }
        }
    }
}
