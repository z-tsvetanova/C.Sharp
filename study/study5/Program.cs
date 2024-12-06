using System.Threading.Channels;

namespace study5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();
            student1.InPut();
        }
    }
}
public class student
{
    private string firstname,secondname,lastname;
    private int fnumber;
    private string specialty;
    private int course;
    public student()
    {
        firstname = string.Empty;
        secondname = string.Empty;
        lastname = string.Empty;
        fnumber = 0;
        specialty = string.Empty;
        course = 0;
    }
    public student(string Firstname,string Lastname,int Fnumber)
    {
        firstname = Firstname;
        lastname = Lastname;
        fnumber = Fnumber;
    }
    public student(string Firstname,string Lastname,int Fnumber,int Course)
    {
        firstname = Firstname;
        lastname = Lastname;
        fnumber = Fnumber;
        course = Course;
    }
    public void InPut()
    {
        firstname = Console.ReadLine();
        secondname = Console.ReadLine();
        lastname = Console.ReadLine();
        fnumber = int.Parse(Console.ReadLine());
        specialty = Console.ReadLine();
        course = int.Parse(Console.ReadLine());
        Console.WriteLine($" firstname of student : {firstname} | secondname of student : {secondname} | lastname of student : {lastname} fnumber of student {fnumber} course of student : {course}");
    }
}