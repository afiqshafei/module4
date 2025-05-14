using System.Collections.Generic;
using System.Threading.Tasks;
using EventEaseApp;
 
namespace EventEaseApp 
{
    public class EventService 
    {
        private List<EventModel> events = new()
        {
            // Initialize with some dummy data
            new EventModel {
                Id = 1,
                Name = "Tech Conference 2025",
                Date = new DateTime(2025,8,16),
                Location = "Singapore Expo",
                Description = "A conference for tech enthusiasts and professionals."

            },
            new EventModel {
                Id = 2,
                Name = "Art Exhibition",
                Date = new DateTime(2025,9,10),
                Location = "National Gallery",
                Description = "An exhibition showcasing contemporary art."

            }
        };

        public Task<List<EventModel>> GetEventsAsync() => Task.FromResult(events);
        public Task<EventModel> GetEventById(int id) => Task.FromResult(events.Find(e => e.Id == id));
    }
}
