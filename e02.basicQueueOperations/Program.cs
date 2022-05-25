using System;
using System.Collections.Generic;
using System.Linq;

namespace e02.basicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = numbers[0];//You will be given an integer N representing the number of elements to enqueue (add)
            int s = numbers[1]; //the number of elements to dequeue (remove) 
            int x = numbers[2]; //an element that you should look for in the queue
                                // List<int> listNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] listNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(listNumbers[i]);
            }
            for (int i = s; i > 0; i--)
            {
                queue.Dequeue();
            }
            if (queue.Count>0)
            {
            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
