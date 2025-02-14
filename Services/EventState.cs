using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class EventState
{
    private List<EventModel> events = new();

    public IReadOnlyList<EventModel> Events => events;

    public void AddEvent(EventModel newEvent)
    {
        newEvent.Id = events.Count + 1; // Genera un ID automático
        events.Add(newEvent);
    }

    public EventModel? GetEventById(int id)
    {
        return events.FirstOrDefault(e => e.Id == id);
    }

    public void LoadMockEvents()
    {
        if (events.Count == 0)
        {
            events = Enumerable.Range(1, 10).Select(i => new EventModel
            {
                Id = i,
                Name = $"Evento {i}",
                Date = System.DateTime.Now.AddDays(i),
                Location = "Ubicación Aleatoria"
            }).ToList();
        }
    }
}
