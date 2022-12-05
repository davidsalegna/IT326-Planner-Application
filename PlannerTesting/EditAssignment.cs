using Bunit;
using IT_326___Planner_Application.Models;
using IT_326___Planner_Application.Pages;
using Xunit.Sdk;

namespace PlannerTesting
{
    public class EditAssignment : TestContext
    {
        [Fact]
        public void EditAssignmentAttributes()
        {
            Course testCourse = Course.CreateCourse(DateTime.Today, DateTime.Today, "Test Course", "red", "Carl");
            Assignment testAssignment = Assignment.CreateAssignment("math hw","online homework",testCourse,DateTime.Today);
            testAssignment.Title = "Changed Test Assignment";
            Assert.Equal("Changed Test Assignment", testAssignment.Title);
            testAssignment.Description = "change";
            Assert.Equal("change", testAssignment.Description);
        }

        [Fact]
        public void EditAssignmentAttributeToNull()
        {
            Course testCourse = Course.CreateCourse(DateTime.Today, DateTime.Today, "Test Course", "red", "Carl");
            Assignment testAssignment = Assignment.CreateAssignment("math hw","online homework",testCourse,DateTime.Today);
            testAssignment.Title = null;
            Assert.Null(testAssignment.Title);
            testAssignment.Description = null;
            Assert.Null(testAssignment.Description);
            testAssignment.course = null;
            Assert.Null(testAssignment.course);

        }
    }
}