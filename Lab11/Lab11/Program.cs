namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat[] cats = { new Cat(), new Cat() };
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };

            for (int i = 0; i < cats.Length; i++)
            {
                cats[i].Info();
                cats[i].GetSound();
            }

            foreach (var dog in dogs)
            {
                dog.Info();
                dog.GetSound();
            }
        }
    }
    class Pet
    {
        private string name;
        private int age;
        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public int AGE
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public Pet()
        {
            name = "";
            age = 0;
        }
        public Pet(string Name, int Age)
        {
            NAME = Name;
            AGE = Age;
        }
        public virtual void GetSound()
        {

        }
        public virtual void Info()
        {

        }

    }
    class Cat : Pet
    {
        public Cat()
        {

        }
        public Cat(string Name, int Age) : base(Name, Age)
        {

        }
        public override void GetSound()
        {
            Console.WriteLine("Meow");
        }
        public override void Info()
        {
            NAME = Console.ReadLine();
            AGE = int.Parse(Console.ReadLine());
            Console.WriteLine("CAT INFO:");
            Console.WriteLine($"Name:{NAME} | Age: {AGE}");

        }
    }
    class Dog : Pet
    {
        public Dog()
        {

        }
        public Dog(string Name, int Age) : base(Name, Age)
        {

        }
        public override void GetSound()
        {
            Console.WriteLine("Barf");
        }
        public override void Info()
        {
            NAME = Console.ReadLine();
            AGE = int.Parse(Console.ReadLine());
            Console.WriteLine("DOG INFO:");
            Console.WriteLine($"Name:{NAME} | Age: {AGE}");

        }
    }

}