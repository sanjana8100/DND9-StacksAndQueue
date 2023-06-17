namespace DND9_StacksAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Display();

            stack.Pop();
            stack.Display();

            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Size());
        }
    }
}