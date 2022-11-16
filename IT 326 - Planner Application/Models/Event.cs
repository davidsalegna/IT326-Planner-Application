using Radzen.Blazor.Rendering;

namespace IT_326___Planner_Application.Models
{
    public class Event : object
    {
        //Gets or sets the start of the event.
        public DateTime Start { get; set; }

        //Gets or sets the end of the event.
        public DateTime End { get; set; }

        //Gets or sets the text of the event.
        public string? Text { get; set; }

        //Gets or sets the data associated with the event.
        public object? Data { get; set; }

        public string? Color { get; set; }
    }

    public class Course : Event
    {
        public string? Teacher { get; set; }

        public Array? Assignments { get; set; }

    }
}

