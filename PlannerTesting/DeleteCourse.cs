using Bunit;
using IT_326___Planner_Application.Models;
using IT_326___Planner_Application.Pages;
using Xunit.Sdk;

namespace PlannerTesting
{
    public class DeleteCourse : TestContext
    {
        [Fact]
        public void RemoveCourse()
        {
            Course testCourse = Course.CreateCourse(DateTime.Today, DateTime.Today, "Course to Remove", "green", "Rishi");
            Calendar.eventList.Add(testCourse);
            Assert.True(Calendar.eventList.Contains(testCourse));
            Calendar.eventList.Remove(testCourse);
            Assert.False(Calendar.eventList.Contains(testCourse));
        }
    }
}