using System.Collections.Generic;
using System.Threading.Tasks;
using EventEaseApp.Models;
 
namespace EventEaseApp 
{
    public class EventService 
    {
        private List<EventModel> events = new();
        {
            // Initialize with some dummy data
            new EventModel {
                Id = 1,
                Name = "Tech Conference",

            }
        }
    }
}
