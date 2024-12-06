namespace Lab8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person();
            person1.Firstname = Console.ReadLine();
            person1.Thirdname = Console.ReadLine();
            person1.Number = Console.ReadLine();
            Console.WriteLine($"Ime {person1.Firstname} : Familiq {person1.Thirdname} : Nomer {person1.Number}");
        }
    }
    class person
    {
        private string firstname;
        private string thirdname;
        private string number;
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Thirdname
        {
            get
            {
                return thirdname;
            }
            set
            {
                thirdname = value;
            }
        }
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public person()
        {

        }
        public person(string firstname,string thirdname,string number)
        {
            this.firstname = firstname;
            this.thirdname = thirdname;
            this.number = number;
        }
        public void input()
        {
            firstname = Console.ReadLine();
            thirdname = Console.ReadLine();
            number = Console.ReadLine();
            Console.WriteLine($"firstname : {firstname} : thirdname :{thirdname} number {number}");
        }
    }
}