namespace Lab202410._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            Console.WriteLine("Proverka za avtorstvo na kniga:");

            if (facade.IsLecturerBookAuthor())
            {
                facade.ShowBook();
            }

            Console.WriteLine("Proverka za avtorstvo na doklad:");
            if (facade.IsLecturerPaperAuthor())
            {
                facade.ShowPaper();
            }
        }
    }
}
public class Lecturer
{
    private string firstName;
    private string secondName;
    private string lastName;
    private string affiliation;
    private string department;
    public Lecturer(string fN, string sN, string lN, string aff, string dep)
    {
        firstName = fN;
        secondName = sN;
        lastName = lN;
        affiliation = aff;
        department = dep;
    }
    public string FirstName
    {
        get { return firstName; }
    }
    public string LastName
    {
        get { return lastName; }
    }

    public void Add()
    {
        Console.WriteLine("Lecturer {0} {1} {2} {3} has been added!", affiliation, firstName, secondName, lastName);
    }
    public void Update(string fN, string sN, string lN, string aff, string dep)
    {
        firstName = fN;
        secondName = sN;
        lastName = lN;
        affiliation = aff;
        department = dep;
        Console.WriteLine("Lecturer {0} {1} {2} {3} has been updated!", affiliation, firstName, secondName, lastName);
    }
    public void Remove()
    {
        Console.WriteLine("Lecturer {0} {1} {2} {3} has been removed!", affiliation, firstName, secondName, lastName);
    }
    public void Show()
    {
        Console.WriteLine("Lecturer information:");
        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Second name: " + secondName);
        Console.WriteLine("Family name: " + lastName);
        Console.WriteLine("Affiliation " + affiliation);
        Console.WriteLine("Department: " + department);
    }
}
public class Author
{
    private string firstName;
    private string lastName;
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
}
class Book
{
    private Author author = new Author();
    private string title;
    private string ISBN;
    private string details;
    private string type;
    public void Add()
    {
        Console.Write("Author's first name:");
        author.FirstName = Console.ReadLine();
        Console.Write("Author's family name:");
        author.LastName = Console.ReadLine();
        Console.Write("Title:");
        title = Console.ReadLine();
        Console.Write("Details:");
        details = Console.ReadLine();
        Console.Write("ISBN:");
        ISBN = Console.ReadLine();
        Console.Write("type:");
        type = Console.ReadLine();
        Console.WriteLine("Book {0} {1} {2} {3} has been added!", author.FirstName, author.LastName, title, details);
    }
    public void Update(Author author, string title, string ISBN, string details, string type)
    {
        this.author = author;
        this.title = title;
        this.ISBN = ISBN;
        this.details = details;
        this.type = type;
        Console.WriteLine("Book {0} {1} {2} {3} has been updated!", author.FirstName, author.LastName, title, details); ;
    }

    public void Show()
    {
        Console.WriteLine("Book information:");
        Console.WriteLine("Author: {0} {1}", author.FirstName, author.LastName);
        Console.WriteLine("Title: " + title);
        Console.WriteLine(details);
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("type: " + type);
    }
    public string GetAuthor()
    {
        return author.FirstName + author.LastName;
    }
}
class Paper
{
    private int numberOfAuthors;
    private List<Author> authors = new List<Author>();
    private string title;
    private string ISBN;
    private string details;
    private string type;

    public Paper(int n)
    {
        numberOfAuthors = n;
    }
    public void Add()
    {
        Author author;
        for (int i = 0; i < numberOfAuthors; i++)
        {
            author = new Author();
            Console.Write("Author's first name:");
            author.FirstName = Console.ReadLine();
            Console.Write("Author's family name:");
            author.LastName = Console.ReadLine();
            authors.Add(author);
        }
        Console.Write("Title:");
        title = Console.ReadLine();
        Console.Write("Details:");
        details = Console.ReadLine();
        Console.Write("ISBN:");
        ISBN = Console.ReadLine();
        Console.Write("type:");
        type = Console.ReadLine();
        Console.WriteLine("Paper {0} {1} has been added!", title, details);
    }
    public void Update()
    {
        Author author;
        for (int i = 0; i < numberOfAuthors; i++)
        {
            author = new Author();
            Console.Write("Author's first name:");
            author.FirstName = Console.ReadLine();
            Console.Write("Author's family name:");
            author.LastName = Console.ReadLine();
            authors.Add(author);
        }

        Console.Write("Title:");
        title = Console.ReadLine();
        Console.Write("Details:");
        details = Console.ReadLine();
        Console.Write("ISBN:");
        ISBN = Console.ReadLine();
        Console.Write("type:");
        type = Console.ReadLine();
        Console.WriteLine("Paper {0} {1} has been updated!", title, details);
    }

    public void Show()
    {
        Console.WriteLine("Paper information:");
        foreach (Author author in authors)
        {
            Console.WriteLine("Author: {0} {1}", author.FirstName, author.LastName);
        }
        Console.WriteLine("Title: " + title);
        Console.WriteLine(details);
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("type: " + type);
    }
    public bool SearchAuthor(string name, string family)
    {
        bool found = false;
        foreach (Author author in authors)
        {
            if (author.FirstName == name && author.LastName == family) found = true;
        }
        return found;
    }
}
public class Facade
{
    Lecturer lecturer;
    Book book;
    Paper paper;
    public Facade()
    {
        lecturer = new Lecturer("Ivan", "Petrov", "Ivanov", "doc.d-r", "KST");
        book = new Book();
        book.Add();
        paper = new Paper(2);
        paper.Add();
    }
    public void ShowBook()
    {
        book.Show();
    }
    public void ShowPaper()
    {
        paper.Show();
    }
    public bool IsLecturerBookAuthor()
    {
        string author = book.GetAuthor();

        if (lecturer.FirstName + lecturer.LastName == author) return true;
        else return false;
    }
    public bool IsLecturerPaperAuthor()
    {
        return paper.SearchAuthor(lecturer.FirstName, lecturer.LastName);
    }
}

