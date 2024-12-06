namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person();
            person1.Input();
            Console.WriteLine(person1.OutputBirthday());
        }
    }
    class person
    {
        private string name, secondname, thirdname;
        private int birthday;

        public void Input()
        {
            Console.WriteLine("name");
            name = Console.ReadLine();
            Console.WriteLine("secondname");
            secondname = Console.ReadLine();
            Console.WriteLine("thirdname");
            thirdname = Console.ReadLine();
            birthday = int.Parse(Console.ReadLine());

        }
        public int OutputBirthday()
        {
            int diff = 2023 - birthday;
            return diff;

        }
    }
}