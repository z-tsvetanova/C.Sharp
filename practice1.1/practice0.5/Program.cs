using System.Security.Cryptography.X509Certificates;

namespace practice0._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           student student1 = new student();
           student.input(" ", 0, 0) ; //Vikane na statichen metod i podavane na parametri
           student1.input(); //Vikane na metod na ekzemplqrite
        }
        class student
        {  
            //poleta
            private string Name;
            private int Age;
            private int phonenumber;
            public student()
            {
                //// prazen konstruktor pod podrazbirane
            }
            public student(string name, int age, int phonenumber) //konstruktor s parametri koito sochat kum poletata
            {
                Name = name; 
                Age = age;
                this.phonenumber = phonenumber;

            }
            public string Names  //svoistvo koeto vzima stoinostta na poleto name
            {
                get //vzima stoinostta na poleto Name
                {
                    return Name;
                }
                set //zapisva stoinostta na poleto Name na svoistvoto Names
                {
                    Name = value;
                }
            }
            public static void input(string name, int age, int phonenumber) //statichen metod
            {  
                name = Console.ReadLine();
                age = int.Parse(Console.ReadLine());
                phonenumber = int.Parse(Console.ReadLine());
                Console.WriteLine($" name : {name} : age {age} : phonenumber {phonenumber}");

            }
            public void input() //metod na ekzemplqrite
            {
                Name = Console.ReadLine();
                Age = int.Parse(Console.ReadLine());
                phonenumber = int.Parse(Console.ReadLine());
                Console.WriteLine($" name : {Name} : age {Age} : phonenumber {phonenumber}");

            }

        }
    }
}