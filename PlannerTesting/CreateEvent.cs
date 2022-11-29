using Bunit;
using IT_326___Planner_Application.Models;
using IT_326___Planner_Application.Pages;
using Xunit.Sdk;

namespace PlannerTesting
{
    public class CreateEvent : TestContext
    {
        [Fact]
        public void EventWithAllParameters()
        {
            Event testEvent = Event.CreateEvent(DateTime.Today, DateTime.Today, "Test Event", "green");
            Assert.Equal(DateTime.Today, testEvent.Start);
            Assert.Equal(DateTime.Today, testEvent.End);
            Assert.Equal("Test Event", testEvent.Text);
            Assert.Equal("green", testEvent.Color);
        }

        [Fact]
        public void EventWithOnlyRequiredParameters()
        {
            Event testEvent = Event.CreateEvent(DateTime.Today, DateTime.Today);
            Assert.Equal(DateTime.Today, testEvent.Start);
            Assert.Equal(DateTime.Today, testEvent.End);
            Assert.Null(testEvent.Text);
            Assert.Null(testEvent.Color);

        }
    }
}