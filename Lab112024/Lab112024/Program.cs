using System.Diagnostics;

namespace Lab112024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10000];


            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10000);
            }


            Stopwatch stopwatch = new Stopwatch();


            Context insertionSortContext = new Context(new InsertionSort(), stopwatch);
            insertionSortContext.ContextInterface((int[])array.Clone());


            Context selectionSortContext = new Context(new SelectionSort(), stopwatch);
            selectionSortContext.ContextInterface((int[])array.Clone());


            Context bubbleSortContext = new Context(new BubbleSort(), stopwatch);
            bubbleSortContext.ContextInterface((int[])array.Clone());
        }
    }
}
public abstract class Strategy
{
    public abstract void AlgorithmInterface(int[] array);
    public abstract string AlgorithmName();
}
public class InsertionSort : Strategy
{
    public override void AlgorithmInterface(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (array[j - 1] > array[j])
                {
                    int temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
    public override string AlgorithmName()
    {
        return "Insertion Sort";
    }
}
public class SelectionSort : Strategy
{
    public override void AlgorithmInterface(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
    public override string AlgorithmName()
    {
        return "Selection Sort";
    }
}

public class BubbleSort : Strategy
{
    public override void AlgorithmInterface(int[] array)
    {
        int temp;
        for (int j = 0; j <= array.Length - 2; j++)
        {
            for (int i = 0; i <= array.Length - 2; i++)
            {
                if (array[i] > array[i + 1])
                {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
    public override string AlgorithmName()
    {
        return "Bubble Sort";
    }
}
public class Context
{
    private Strategy strategy;
    private Stopwatch stopwatch;
    public Context(Strategy strategy, Stopwatch stopwatch)
    {
        this.strategy = strategy;
        this.stopwatch = stopwatch;
    }
    public void ContextInterface(int[] array)
    {
        stopwatch.Start();
        strategy.AlgorithmInterface(array);
        stopwatch.Stop();
        Console.WriteLine($"{strategy.AlgorithmName()} took {stopwatch.Elapsed.TotalMilliseconds:N2} ms to finish.");

    }
}
