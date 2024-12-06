namespace Lab20249
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStudent student = new MyStudent();
            student.SetData();
            student.DisplayData();
            Console.WriteLine($"Grade : {student.CalculateGrade()}");
        }
    }
}
public class Group
{
    private string [] data = { "Ivan", "Ivanov", "123456", "ivan.ivanov@gmail.com", "27.5" };
    public string GetItem(string item)
    {
        switch(item.ToLower())
        {
            case "firstname": return data[0];
            case "lastname": return data[1];
            case "id": return data[2];
            case "email": return data[3];
            case "points": return data[4];
            default: return "Invalid Field";
        }
    }
}
public abstract class Student
{
    public abstract void SetData();
    public abstract void DisplayData();
    public abstract string CalculateGrade();
}
public class MyStudent : Student
{
    private Group group = new Group();
    protected string firstname;
    protected string lastname;
    protected string id;
    protected string email;
    protected double points;
    public override void SetData()
    {
        firstname = group.GetItem("Firstname");
        lastname = group.GetItem("Lastname");
        id = group.GetItem("Id");
        email = group.GetItem("email");
        points = double.Parse(group.GetItem("Points"));
    }
    public override void DisplayData()
    {
        Console.WriteLine($"Firstname: {firstname}");
        Console.WriteLine($"Lastname: {lastname}");
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Points: {points}");
    }
    public override string CalculateGrade()
    {
        if(points>=25.5) { return "Excelent (6)"; }
        if (points >= 22.5) { return "Very good (5)"; }
        if (points >= 18) { return "Good (4)"; }
        if (points >= 13.5) { return "Average (5)"; }
        else return "Poor 2";
    }
}