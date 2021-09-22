using System;
namespace CodingEvents.Models

{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string EventLocation { get; set; }
        public int NumOfAttendees { get; set; }

        public int Id { get; }
        private static int nextId = 1;

        public Event()
        {
            Id = nextId;
            nextId++;
        }

        public Event(string name, string description, string contactEmail, string eventLocation, int numOfAttendees) :this()
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
            EventLocation = eventLocation;
            NumOfAttendees = numOfAttendees;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
