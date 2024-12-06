namespace practice1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            dog dog1 = new dog();
            dog1.InPut();
            dog1.OutPut();

        }
    }
    class dog
    {
        private string name;
        private int age;

        public void InPut()
        {

            Console.WriteLine("name:");
            name = Console.ReadLine();
            Console.WriteLine("age:");
            age = int.Parse(Console.ReadLine());
        }
        public void OutPut()
        {
            Console.WriteLine($"name : {name} age : {age}");
        }
    }

}