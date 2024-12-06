namespace Lab202410
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lecturer lecturer = new Lecturer();
            Console.WriteLine("Enter Lecturer Information:");
            lecturer.InPut();
            lecturer.OutPut();

            Book book = new Book();

            Console.WriteLine("\nEnter Book Information:");

            book.InPut();
            book.OutPut();
            try
            {
                Facade facade = new Facade(lecturer, book, null, null);
                bool isAuthor = facade.IsLecturerAuthorOfBook(lecturer, book);

                Console.WriteLine($"\nIs the lecturer the author of the book? {isAuthor}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}
public class Lecturer
{
    private string firstname;
    private string secondname;
    private string lastname;
    private string affiliaton;
    private string department;
    public string Firstname { get { return firstname; } set { firstname = value; } }
    public string Secondname { get { return secondname; } set { secondname = value; } }
    public string Lastname { get { return lastname; } set { lastname = value; } }
    public void InPut()
    {
        Console.Write("Firstname: ");
        firstname = Console.ReadLine();
        Console.Write("Secondname: ");
        secondname = Console.ReadLine();
        Console.Write("Lastname: ");
        lastname = Console.ReadLine();
        Console.Write("Affiliation: ");
        affiliaton = Console.ReadLine();
        Console.Write("Department: ");
        department = Console.ReadLine();
    }
    public void OutPut()
    {
        Console.WriteLine($"Firstname: {firstname}, Secondname: {secondname}, Lastname: {lastname}, Affiliation: {affiliaton}, Department: {department}");
    }
    public void UpdateLecturer(string Firstname, string SecondName, string Lastname, string Affiliaton)
    {
        firstname = Firstname;
        secondname = SecondName;
        lastname = Lastname;
        affiliaton = Affiliaton;
    }
}
public class Book
{
    private string author;
    private string tittle;
    private string isbn;
    private string details;
    public string Author { get { return author; } set { author = value; } }
    public void InPut()
    {
        Console.Write("Author: ");
        author = Console.ReadLine();
        Console.Write("Title: ");
        tittle = Console.ReadLine();
        Console.Write("ISBN: ");
        isbn = Console.ReadLine();
        Console.Write("Details: ");
        details = Console.ReadLine();
    }
    public void OutPut()
    {
        Console.WriteLine($"Author: {author}, Title: {tittle}, ISBN: {isbn}, Details: {details}");
    }
    public void UpdateBook(string Author, string Tittle, string Isbn, string Details)
    {
        author = Author;
        tittle = Tittle;
        isbn = Isbn;
        details = Details;
    }
}
public class Paper
{
    private string tittle;
    private string isbn;
    private string issn;
    private string details;
    private List<Author> authors = new List<Author>();
    public void InPut()
    {
        Console.WriteLine("Enter Paper Information:");
        Console.WriteLine("List of authors in a publication");
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            Author author = new Author();
            Console.WriteLine($"Enter details for Author {i + 1}:");
            Console.Write("Firstname: ");
            author.Firstname = Console.ReadLine();
            Console.Write("Lastname: ");
            author.Lastname = Console.ReadLine();
            authors.Add(author);
        }
        Console.WriteLine("Tittle");
        tittle = Console.ReadLine();
        Console.WriteLine("Isbn");
        isbn = Console.ReadLine();
        Console.WriteLine("Issn");
        issn = Console.ReadLine();
        Console.WriteLine("Details:");
        details = Console.ReadLine();
    }
    public void OutPut()
    {
        Console.WriteLine($"Title: {tittle}, ISBN: {isbn}, ISSN: {issn}, Details: {details}");
        for (int i = 0; i < authors.Count; i++)
        {
            Console.WriteLine($"[{i}] {authors[i].Firstname} {authors[i].Lastname}");
        }
    }
        public void UpdatePaper(string Tittle, string Isbn, string Isnn, string Details)
        {
            tittle = Tittle;
            isbn = Isbn;
            issn = Isnn;
            details = Details;
        }
    }
public class Author
{
    private string firstname;
    private string secondname;
    private string lastname;
    public string Firstname { get { return firstname; } set { firstname = value; } }
    public string SecondName { get { return secondname; } set { secondname = value; } }
    public string Lastname { get { return lastname; } set { lastname = value; } }
}
public class Facade
{
    private Lecturer lecturer;
    private Book book;
    private Paper paper;
    private Author author;
    private List<Lecturer> lecturers = new List<Lecturer>();
    private List<Book> books = new List<Book>();
    public void AddLecturer(Lecturer lecturer)
    {
        lecturers.Add(lecturer);
    }
    public void RemoveLecturer(Lecturer lecturer)
    {
        lecturers.Remove(lecturer);
    }
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }
    public Facade(Lecturer lecturer, Book book, Paper paper, Author author)
    {
        this.lecturer = lecturer;
        this.book = book;
        this.paper = paper;
        this.author = author;
    }
    public bool IsLecturerAuthorOfBook(Lecturer lecturer, Book book)
    {
        string LecturerFullName = $"{lecturer.Firstname} {lecturer.Secondname} {lecturer.Lastname}";
        return book.Author == LecturerFullName;
    }

}