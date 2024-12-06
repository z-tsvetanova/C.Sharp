using System.Collections.Concurrent;

namespace Practice0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person();
            person1.input();
            person1.output();
            Console.WriteLine($" outputBday = " + person1.outputBday());
        }
    }
    class person
    {
        private string name, secondname, thirdname;
        private int birthday;
        
        public void input()
        {
            name = Console.ReadLine();
            secondname = Console.ReadLine();
            thirdname = Console.ReadLine();
            birthday = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine($"name : {name} : secondname {secondname} : thirdname {thirdname} : birthday {birthday}");
        }
        public int outputBday()
        {
            int diff = birthday - 2023;
            return diff;
        }
    }

}