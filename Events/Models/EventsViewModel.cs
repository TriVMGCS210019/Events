namespace Events.Models
{
    public class EventsViewModel
    {
        public IEnumerable<Event> UpcomingEvents { get; set; }
        public IEnumerable<Event> PastEvents { get; set; }
        public EventsViewModel(IEnumerable<Event> upcomingEvents, IEnumerable<Event> pastEvents) 
        {
            UpcomingEvents = upcomingEvents;
            PastEvents = pastEvents;
        }
    }
}
