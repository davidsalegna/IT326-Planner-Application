namespace IT_326___Planner_Application.Models{


public class Assignment : object
{
    public string? Title {get;set;}

    public string? CourseName { get; set; }

    public string? Description {get;set;}

    public bool IsDone { get; set; }

    public DateTime DueDate {get;set;}

    public Course? course {get;set;}
}
}