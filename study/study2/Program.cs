namespace study2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person();
            person1.InPut();
            Console.WriteLine($" birthday = " + person1.OutPutBirthday());
            person1.OutPut();
        }
    }
}
public class person
{
    private string firstname, secondname, lastname;
    private int birthday;
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
    private string LASTNAME
    {
        get
        {
            return lastname;
        }
        set
        {
            lastname = value;
        }
    }
    private int BIRTHDAY
    {
        get
        {
            return birthday;
        }
        set
        {
            birthday = value;
        }
    }
    public person() 
    {
        firstname = "";
        secondname = "";
        lastname = "";
        birthday = 0;
    }
    public person(string Firstname, string Secondname, string Lastname,int Birthday)
    {
        FIRSTNAME = Firstname;
        SECONDNAME = Secondname;
        LASTNAME = Lastname;
        BIRTHDAY = Birthday;
    }
    public void InPut()
    {
        FIRSTNAME = Console.ReadLine();
        SECONDNAME = Console.ReadLine();
        LASTNAME = Console.ReadLine();
        BIRTHDAY = int.Parse(Console.ReadLine());
    }
    public int OutPutBirthday()
    {
        int diff = 2023 - BIRTHDAY;
        return diff;
    }
    public void OutPut()
    {
        Console.WriteLine($"| firstname {firstname} |  secondname : {secondname} |  lastname : {lastname} |  birthday : {birthday} |");
    }
}