using System.Security.Cryptography.X509Certificates;

namespace AAAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student1=new Student();
            //student1.Input();
            //student1.OutPut();

            Student[] student1= { new Student(),new Student() };
            foreach (var student in student1) 
            {
                student.Input();
                student.OutPut();
            }

        }
    }
}
public class Person
{
    private string name;
    private int egn;
    private string id;
    public Person()
    {
        name = "";
        egn = 0;
        id = "";
    }
    public string NAME { get; set;}
    public string ID { get; set; }
    public int EGN { get; set;}
    public Person(string Name,int Egn,string Id)
    {
        NAME = Name;
        EGN = Egn;
        ID = Id;
    }
}
public class Student:Person
{
    private string specialty;
    private int group;
    private int fnumber;
    public Student()
    {
        specialty = "";
        group = 0;
        fnumber = 0;
    }
    public Student(string Specialty,int Group,int Fnumber,string Name,int Egn,string Id):base(Name,Egn,Id)
    {
        SPECIALTY = Specialty;
        GROUP = Group;
        FNUMBER = Fnumber;
    }
    public string SPECIALTY
    {
        get
        {
            return specialty;
        }
        set
        {
            specialty = value;
        }
    }
    public int GROUP
    {
        get
        {
            return group;
        }
        set
        {
            group = value;
        }
    }
    public int FNUMBER
    {
        get
        {
            return fnumber;
        }
        set
        {
            fnumber = value;
        }
    }
    public void Input()
    {
        Console.WriteLine("NAME");
        NAME = Console.ReadLine();
        Console.WriteLine("ID");
        ID = Console.ReadLine();
        Console.WriteLine("EGN");
        EGN = int.Parse(Console.ReadLine());
        Console.WriteLine("SPECIALTY:");
        SPECIALTY = Console.ReadLine();
        Console.WriteLine("GROUP");
        GROUP = int.Parse(Console.ReadLine());
        Console.WriteLine("FNUMBER");
        FNUMBER = int.Parse(Console.ReadLine());
    }
    public void OutPut()
    {
        Console.WriteLine($"NAME : {NAME} ID : {ID} EGN : {EGN}");
        Console.WriteLine($"SPECIALTY : {SPECIALTY} GROUP : {GROUP} FNUMBER : {FNUMBER}");
    }
}
