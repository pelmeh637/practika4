using System.Collections;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    Queue queue = new Queue();

    queue.Enqueue("First"); queue.Enqueue("Second"); queue.Enqueue("Third"); queue.EnqueueC'Fourth");
  while (queue.Count > 0)
      Stack stack = new Stack();
    Stack.Push("First");
    stack.Push("Second");
    stack.Push("Third");
    stack.Push("Fourth");
    while (stack.Count > 0)
    {
      object obj = stack.Pop();
      Console.WriteLine("'From Stack: {0}", obj);
    }

    {
      object obj = queue.Dequeue();
      Console.WriteLine("From Queue: {0}", obj);

    }
  }
}
