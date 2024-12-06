using System.Collections.Concurrent;
using System.Threading.Channels;
using System.Xml.Schema;

namespace study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dog dog1 = new dog();
            //dog.output("sharo", 4);

            //dog[] dog1 = { new dog() };
            //foreach(var dog in dog1) 
            //{
            //    dog.output("sharo", 4);

            //}
            dog[] dog1 = { new dog() };
            {
                for(int i=0;i<dog1.Length; i++)
                {
                    dog.output("sharo", 4);
                }
            }

        }
    }   
 }
public class dog
{
    private string name;
    private int age;
    public dog()
    {
        name = string.Empty;
        age = 0;
    }
    public dog(string Name,int Age)
    {
        name = Name;
        age = Age;
    }
    public static void input(string name,int age)
    {
        name = Console.ReadLine();
        age = int.Parse(Console.ReadLine());
    }
    public static void output(string name,int age)
    {
        Console.WriteLine($"name of the dog : {name} | age of the dog : {age}");
    }
}













