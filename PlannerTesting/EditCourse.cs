using Bunit;
using IT_326___Planner_Application.Models;
using IT_326___Planner_Application.Pages;
using Xunit.Sdk;

namespace PlannerTesting
{
    public class EditCourse : TestContext
    {
        [Fact]
        public void EditCourseAttributes()
        {
            Course testCourse = Course.CreateCourse(DateTime.Today, DateTime.Today, "Test Course", "red", "Carl");
            testCourse.Text = "Changed Test Course";
            Assert.Equal("Changed Test Course", testCourse.Text);
            testCourse.Color = "purple";
            Assert.Equal("purple", testCourse.Color);
            testCourse.Teacher = "Dan";
            Assert.Equal("Dan", testCourse.Teacher);
        }

        [Fact]
        public void EditCourseAttributeToNull()
        {
            Course testCourse = Course.CreateCourse(DateTime.Today, DateTime.Today, "Test Course", "red", "Carl");
            testCourse.Text = null;
            Assert.Null(testCourse.Text);
            testCourse.Color = null;
            Assert.Null(testCourse.Color);
            testCourse.Teacher = null;
            Assert.Null(testCourse.Teacher);

        }
    }
}