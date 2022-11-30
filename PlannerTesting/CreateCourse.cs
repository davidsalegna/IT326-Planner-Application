using Bunit;
using IT_326___Planner_Application.Models;
using IT_326___Planner_Application.Pages;
using Xunit.Sdk;

namespace PlannerTesting
{
    public class CreateCourse : TestContext
    {
        [Fact]
        public void CourseWithAllParameters()
        {
            Course testCourse = Course.CreateCourse(DateTime.Today, DateTime.Today, "Test Course", "green", "Rishi");
            Assert.Equal(DateTime.Today, testCourse.Start);
            Assert.Equal(DateTime.Today, testCourse.End);
            Assert.Equal("Test Course", testCourse.Text);
            Assert.Equal("green", testCourse.Color);
            Assert.Equal("Rishi", testCourse.Teacher);
        }

        [Fact]
        public void CourseWithOnlyRequiredParameters()
        {
            Course testCourse = Course.CreateCourse(DateTime.Today, DateTime.Today);
            Assert.Equal(DateTime.Today, testCourse.Start);
            Assert.Equal(DateTime.Today, testCourse.End);
            Assert.Null(testCourse.Text);
            Assert.Null(testCourse.Color);
            Assert.Null(testCourse.Teacher);


        }
    }
}