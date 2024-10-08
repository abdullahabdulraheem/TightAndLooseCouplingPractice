namespace TightAndLooseCoupling.Models;

public class ToDo
{
    public int ID {get; set;}
    public string Title {get; set;}
    public bool Completed {get; set;}

    public override string ToString()
    {
        string isCompleted = Completed ? "COMPLETED" : "INCOMPLETE";
        return $"{ID}. Task({Title}) {isCompleted}";
    }
}