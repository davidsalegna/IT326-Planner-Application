using Bunit;
using IT_326___Planner_Application.Models;
using IT_326___Planner_Application.Pages;
using Xunit.Sdk;

namespace PlannerTesting
{
    public class GetCourseList : TestContext
    {
        [Fact]
        public void EditEventAttributes()
        {
            IList<Course> courseListTest = Calendar.getCourseList();
            foreach (var i in courseListTest)
            {
                Assert.Equal(typeof(Course), i.GetType());
            }
        }
    }
}