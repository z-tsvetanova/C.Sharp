namespace Lab32024._2zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>(5);
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);
            myStack.Push(60);  // Trqbva da vurne "Stack overflow"

            Console.WriteLine("Premahnat element: " + myStack.Pop(default(int))); // 50
            Console.WriteLine("Premahnat element: " + myStack.Pop(default(int))); // 40

            Console.WriteLine("Stekat prazen li e ? " + myStack.IsStackEmpty());

        }
    }
    public class Stack<T>
    {
        private T[] stack;
        private int length;
        private int top;
        public Stack(int l)
        {
            top = 0;
            length = l;
            stack = new T[l];
        }
        public T Get(int index)
        {
            return stack[index];
        }
        public void Set(int index, T value)
        {
            stack[index] = value;
        }
        public bool IsStackEmpty()
        {
            if (top == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsStackFull()
        {
            if (top == length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Push(T item)
        {
            if (IsStackFull())
            {
                Console.WriteLine("Stack overflow");
            }
            else
            {
                stack[top] = item;
                top++;
            }
        }
        public T Pop(T item)
        {
            if (IsStackEmpty())
            {
                return default(T);   //Vrushta stoinost koqto e konkretna za suotvetniq tip
            }
            else
            {
                top--;
                return stack[top];
            }

        }
    }
}
