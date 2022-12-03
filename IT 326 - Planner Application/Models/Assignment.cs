namespace IT_326___Planner_Application.Models{


public class Assignment : object
{
    public string? Title {get;set;}

    public string? CourseName { get; set; }

    public string? Description {get;set;}

    public bool IsDone { get; set; }

    public DateTime DueDate {get;set;}

    public Course? course {get;set;}

public static Assignment CreateAssignment(String Title, String description, Course course, DateTime dueDate){
 Assignment asgt = new Assignment();
 asgt.Title = Title;
 asgt.Description = description;
 asgt.course = course;
asgt.DueDate = dueDate;
return asgt;

}

}
}