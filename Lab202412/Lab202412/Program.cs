using System.Reflection.PortableExecutable;

namespace Lab202412
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Enter operation (exit, undo, redo, +): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "exit":
                        running = false;
                        break;

                    case "undo":
                        Console.WriteLine("How many steps back: ");
                        int levels1 = int.Parse(Console.ReadLine());
                        user.Undo(levels1);
                        break;

                    case "redo":
                        Console.WriteLine("How many steps forward: ");
                        int levels2 = int.Parse(Console.ReadLine());
                        user.Redo(levels2);
                        break;

                    case "+":
                        Console.WriteLine("Enter operand: ");
                        int operand = int.Parse(Console.ReadLine());
                        user.Compute('+', operand);
                        break;

                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }
            }
        }
    }
}
public class Calculator
{
    int curr = 0;
    public void ExecuteOperation(char operation, int operand)
    {
        switch (operation)
        {
            case '+': curr += operand; break;
            case '-': curr -= operand; break;
            case '*': curr *= operand; break;
            case '/': curr /= operand; break;

        }
        Console.WriteLine("Current value = {0} (following {1} {2})", curr, operation, operand);
    }
}
public abstract class Command
{
    public abstract void Execute();
    public abstract void UnExecute();
}
public class CalculatorCommand : Command
{
    char operation;
    int operand;
    Calculator calculator;
    public CalculatorCommand(Calculator calculator, char operation, int operand)
    {
        this.calculator = calculator;
        this.operation = operation;
        this.operand = operand;
    }
    public override void Execute()
    {
        calculator.ExecuteOperation(operation, operand);
    }
    public override void UnExecute()
    {
        calculator.ExecuteOperation(Undo(operation), operand);
    }
    private char Undo(char operation)
    {
        switch (operation)
        {
            case '+': return '-';
            case '-': return '+';
            case '*': return '/';
            case '/': return '*';
            default: throw new ArgumentException("operation");
        }
    }
}
public class User
{
    Calculator calculator = new Calculator();
    List<Command> commands = new List<Command>();
    int current = 0;
    public void Redo(int levels)
    {
        Console.WriteLine("\n--- Redo {0} levels", levels);
        for (int i = 0; i < levels; i++)
        {
            if (current < commands.Count - 1)
            {
                Command command = commands[current++];
                command.Execute();
            }
        }
    }
    public void Undo(int levels)
    {
        Console.WriteLine("\n--- Undo {0} levels", levels);
        for (int i = 0; i < levels; i++)
        {
            if (current > 0)
            {
                Command command = commands[--current] as Command;
                command.UnExecute();
            }
        }
    }
    public void Compute(char operation, int operand)
    {
        Command command = new CalculatorCommand(calculator, operation, operand);
        command.Execute();
        commands.Add(command);
        current++;
    }
}
