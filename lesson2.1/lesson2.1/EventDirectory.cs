namespace lesson2._1
{
    public class EventDirectory
    {
        public static List<Event> events;

        static EventDirectory()
        {
            events = new List<Event>()
        {
            new Event{Id=1,Title="hello",Start=new DateTime(2024,09,21),End=new DateTime()},
            new Event{Id=2,Title="hello",Start=new DateTime(2024,09,21),End=new DateTime()},
            new Event{Id=3,Title="hello",Start=new DateTime(2024,09,21),End=new DateTime()},
            new Event{Id=4,Title="hello",Start=new DateTime(2024,09,21),End=new DateTime()},
            new Event{Id=5,Title="hello",Start=new DateTime(2024,09,21),End=new DateTime()},
            new Event{Id=6,Title="hello",Start=new DateTime(2024,09,21),End=new DateTime()}
        };
        }

        public List<Event> GetList()
        {
            return events;
        }

        public Event GetEventById(int id)
        {
            return events.Find(item => id == item.Id);
        }

        public Event PostEvent(Event value)
        {
            events.Add(value);
            return value;
        }

        public Event PutEvent(int id, Event value)
        {
            var item = events.Find(item => id == item.Id);
            if (item != null)
            {
                item.Title = value.Title;
                item.Start = value.Start;
                item.End = value.End;
            }
            return item;
        }

        public void DeleteEvent(int id)
        {
            events.Remove(events.Find(item => id == item.Id));
        }

    }
}
