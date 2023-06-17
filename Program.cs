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

            Console.WriteLine(stack.Top());
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Size());


            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Display();

            queue.Dequeue();
            queue.Display();

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Front());
            Console.WriteLine(queue.Rear());
            Console.WriteLine(queue.IsNull());
            Console.WriteLine(queue.Size());
        }
    }
}