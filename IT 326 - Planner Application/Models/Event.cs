using IT_326___Planner_Application.Pages;
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

        public string? Color { get; set; }

        public static Event CreateEvent(DateTime start, DateTime end, string? text = null, string? color = null)
        {
            Event newEvent = new Event();
            newEvent.Start = start;
            newEvent.End = end;
            if (text != null)
            {
                newEvent.Text = text;
            }
            if (color != null)
            {
                newEvent.Color = color;

            }
            return newEvent;
        }

    }

    public class Course : Event
    {
        public string? Teacher { get; set; }

        public Array? Assignments { get; set; }

        public static Course CreateCourse(DateTime start, DateTime end, string? text = null, string? color = null, string? teacher = null)
        {
            Course newEvent = new Course();
            newEvent.Start = start;
            newEvent.End = end;
            if (text != null)
            {
                newEvent.Text = text;
            }
            if (color != null)
            {
                newEvent.Color = color;

            }
            if (teacher != null)
            {
                newEvent.Teacher = teacher;

            }
            return newEvent;
        }

    }
}

