using Bunit;
using IT_326___Planner_Application.Models;
using IT_326___Planner_Application.Pages;
using Xunit.Sdk;

namespace PlannerTesting
{
    public class DeleteAssignment : TestContext
    {
        [Fact]
        public void RemoveAssignment()
        {
            Course testCourse = Course.CreateCourse(DateTime.Today, DateTime.Today, "Course to Remove", "green", "Rishi");
            Assignment testAssignment = Assignment.CreateAssignment("math hw","online homework",testCourse,DateTime.Today);
            Assignments.assignmentList.Add(testAssignment);
            Assert.True(Assignments.assignmentList.Contains(testAssignment));
            Assignments.assignmentList.Remove(testAssignment);
            Assert.False(Assignments.assignmentList.Contains(testAssignment));
        }
    }
}