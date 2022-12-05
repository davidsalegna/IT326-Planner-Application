using Bunit;
using IT_326___Planner_Application.Models;
using IT_326___Planner_Application.Pages;
using Xunit.Sdk;

namespace PlannerTesting
{
    public class CreateAssignment : TestContext
    {
        [Fact]
        public void AssignmentWithAllParameters()
        {
            Course testCourse = Course.CreateCourse(DateTime.Today, DateTime.Today, "Test Course", "green", "Rishi");
            Assignment testAssignment = Assignment.CreateAssignment("math hw","online homework",testCourse,DateTime.Today);
            Assert.Equal(DateTime.Today, testAssignment.DueDate);
            Assert.Equal("math hw", testAssignment.Title);
            Assert.Equal("online homework", testAssignment.Description);
            Assert.Equal(testCourse, testAssignment.course);
        }
    }
}