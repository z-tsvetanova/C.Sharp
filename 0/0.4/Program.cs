namespace _0._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();
            student1.input();
            student1.output();
        }
        public class student
        {
            private string firstname;
            private string secondname;
            private string thirdname;
            private string fnumber;
            private string specialty;
            public void input()
            {
                Console.WriteLine("First name:");
                firstname=Console.ReadLine();
                Console.WriteLine("Second name:");
                secondname = Console.ReadLine();
                Console.WriteLine("Third name:");
                thirdname = Console.ReadLine();
                Console.WriteLine("Fnumber:");
                fnumber = Console.ReadLine();
                Console.WriteLine("Specialty:");
                specialty = Console.ReadLine();
            }
            public void output()
            {
                string newfnumber;
                Console.WriteLine("Vuvedete fakulteten nomer:");
                newfnumber = Console.ReadLine();
                if (newfnumber == fnumber)
                {
                    Console.WriteLine($"names: {firstname} {secondname} {thirdname}");
                    Console.WriteLine($"specialty:{specialty} fnumber: {fnumber}");

                }
                else
                {
                    Console.WriteLine("Invalid student");
                }
            }

        }

    }
}