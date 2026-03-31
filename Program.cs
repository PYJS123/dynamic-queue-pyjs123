using System;

namespace DynamicQueue
{
	public class Program
	{
		static public void Main(string[] args)
		{
            // You can use this to test the queue's functionality
			DyQueue<string> q = new DyQueue<string>();

			q.Enqueue("Item1");
			Console.WriteLine(q.Length);
			Console.WriteLine(q.Dequeue());
			Console.WriteLine(q.Length);

			q.Enqueue("Item2");
			q.Enqueue("Item3");
			Console.WriteLine(q.Length);
			while (true)
			{
				try
				{
					Console.WriteLine(q.Dequeue());
				}
				catch { break; }
			}

			q.Enqueue("Item4");
			q.Enqueue("Item5");
			q.Enqueue("Item6");
			Console.WriteLine(q.Length);
			while (true) { Console.WriteLine(q.Dequeue()); }
		}
	}
}