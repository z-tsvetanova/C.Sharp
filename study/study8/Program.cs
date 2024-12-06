namespace study8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           person person1 = new person();
           person1.InPut();
           person1.FIRSTNAME = Console.ReadLine();
           person1.SECONDNAME = Console.ReadLine();
           person1.THIRDNAME = Console.ReadLine();
           person1.PHONENUMBER = int.Parse(Console.ReadLine());
           Console.WriteLine($" {person1.FIRSTNAME} {person1.SECONDNAME} {person1.THIRDNAME} {person1.PHONENUMBER}");
        }
    }
}
public class person
{
    string firstname,secondname,thirdname;
    int phonenumber;
    public person()
    {
        firstname  = string.Empty;
        secondname = string.Empty;
        thirdname  = string.Empty;
        phonenumber = 0;
    }
    public person(string Firstname,string Secondname,string Thirdname,int Phonenumber)
    {
        FIRSTNAME  = Firstname;
        SECONDNAME = Secondname;
        THIRDNAME  = Thirdname;
        PHONENUMBER = Phonenumber;              
    }
    public string FIRSTNAME
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
    public string SECONDNAME
    {
        get
        {
            return secondname;
        }
        set
        {
            secondname = value;
        }
    }
    public string THIRDNAME
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
    public int PHONENUMBER
    {
        get
        {
            return phonenumber;
        }
        set
        {
            phonenumber = value;
        }
    }
    public void InPut()
    {
        FIRSTNAME = Console.ReadLine();
        SECONDNAME = Console.ReadLine(); 
        THIRDNAME = Console.ReadLine();
        PHONENUMBER = int.Parse(Console.ReadLine());
        Console.WriteLine($"firstname : {firstname} | secondname : {secondname} | thirdname : {thirdname} | phonenumber : {phonenumber}");
    }
}