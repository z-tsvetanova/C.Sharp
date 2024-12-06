namespace Lab32024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array<int> myArray = new Array<int>(5);
            myArray.Set(0, 10);
            myArray.Set(1, 20);
            myArray.Set(2, 30);
            myArray.Set(3, 40);
            myArray.Set(4, 50);

            myArray.Print();
            
        }
    }
    public class Array<T>
    {
        private T[] array;
        private int length;
        public Array(int l) 
        { 
            length = l;
            array = new T[l];
        }
        public T Get(int index)
        {
            return array[index];
        }
        public void Set(int index, T value)
        {
            array[index] = value;
        }
        public void Print()
        {
            for(int i=0;i<array.Length;i++) 
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
