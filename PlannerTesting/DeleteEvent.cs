using Bunit;
using IT_326___Planner_Application.Models;
using IT_326___Planner_Application.Pages;
using Xunit.Sdk;

namespace PlannerTesting
{
    public class DeleteEvent : TestContext
    {
        [Fact]
        public void RemoveEvent()
        {
            Event testEvent = Event.CreateEvent(DateTime.Today, DateTime.Today, "Event to Remove", "green");
            Calendar.eventList.Add(testEvent);
            Assert.True(Calendar.eventList.Contains(testEvent));
            Calendar.eventList.Remove(testEvent);
            Assert.False(Calendar.eventList.Contains(testEvent));
        }
    }
}