namespace Lab6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dog dog1 = new dog();
            dog dog2 = new dog();
            dog dog3 = new dog();

            dog1.input();
            Console.WriteLine("dog 1:");
            dog1.output();

            dog2.input();
            Console.WriteLine("dog 2:");
            dog2.output();


            dog3.input();
            Console.WriteLine("dog 3:");
            dog3.output();

        }
    }
    class dog
    {
        private string name;
        private int age;
        public void input()
        {
            Console.WriteLine("name");
            name = Console.ReadLine();
            Console.WriteLine("age");
            age = int.Parse(Console.ReadLine());

        }
        public void output()
        {
            Console.WriteLine($"Ime na kuche: {name}, godini: {age}");
        }
    }
}