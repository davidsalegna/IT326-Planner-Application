using Bunit;
using IT_326___Planner_Application.Models;
using IT_326___Planner_Application.Pages;
using Xunit.Sdk;

namespace PlannerTesting
{
    public class EditEvent : TestContext
    {
        [Fact]
        public void EditEventAttributes()
        {
            Event testEvent = Event.CreateEvent(DateTime.Today, DateTime.Today, "Test Event", "green");
            testEvent.Text = "Changed Test Event";
            Assert.Equal("Changed Test Event", testEvent.Text);
            testEvent.Color = "orange";
            Assert.Equal("orange", testEvent.Color);
        }

        [Fact]
        public void EditEventAttributeToNull()
        {
            Event testEvent = Event.CreateEvent(DateTime.Today, DateTime.Today, "Test Event", "green");
            testEvent.Text = null;
            Assert.Null(testEvent.Text);
            testEvent.Color = null;
            Assert.Null(testEvent.Color);

        }
    }
}