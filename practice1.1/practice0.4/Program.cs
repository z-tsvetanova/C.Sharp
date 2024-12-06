using System.Collections.Concurrent;

namespace practice0._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.input();
            student.output();   

        }
    }
    class student
    {
        private string firstname,secondname,thirdname;
        private int fnumber;
        private string specialty;
        private string course;
        public student()
        {
            ///////
        }
        public student(string ime,string familiq,int fnomer)
        {
            firstname = ime;
            secondname = familiq;
            fnumber = fnomer;
        }
        public student(string ime, string familiq, int fnomer,string course)
        {
            firstname = ime;
            secondname = familiq;
            fnumber = fnomer;
            specialty = course;
        }
        public void input()
        {
            Console.WriteLine("Enter a name :");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter a secondname :");
            secondname = Console.ReadLine();
            Console.WriteLine("Enter a thirdname :");
            thirdname = Console.ReadLine();
            Console.WriteLine("Enter a fnumber  :");
            fnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a specialty :");
            specialty = Console.ReadLine();
            Console.WriteLine("Enter a course :");
            course = Console.ReadLine();
        }
        public void output()
        {
            Console.WriteLine($" firstname : {firstname} : secondname {secondname} : thirdname {thirdname}");
            Console.WriteLine($" fnumber {fnumber} : specialty {specialty} : course {course}");
        }
    }
}