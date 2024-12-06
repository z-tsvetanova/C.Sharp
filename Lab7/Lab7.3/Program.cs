using System.Collections.Concurrent;

namespace Lab7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();
            student1.InPut();
            student1.OutPut();

        }
    }
    class student
    {
        private string name,secondname,thirdname;
        private int fnumber;
        private string specialty;
        private string course;
        public student()
        {

        }
        public student(string ime, string familiq, int fnomer)
        {
            name = ime;
            thirdname = familiq;
            fnumber = fnomer;
        }
        public student(string ime, string familiq,int fnomer,string course)
        {
            name = ime;
            secondname = familiq;
            fnumber = fnomer;
            specialty = course;
        }
        public void InPut()
        {
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Secondname:");
            secondname = Console.ReadLine();
            Console.WriteLine("Thirdname :");
            thirdname = Console.ReadLine();
            Console.WriteLine("Fnumber :");
            fnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Specialty :");
            specialty = Console.ReadLine();
            Console.WriteLine("Course :");
            course = Console.ReadLine();
        }
        public void OutPut()
        {
            Console.WriteLine($"ime : {name} prezime : {secondname} familiq : {thirdname}");
            Console.WriteLine($"fakulteten nomer : {fnumber} specialnost : {specialty} kurs : {course}");
        }
    }
    
}