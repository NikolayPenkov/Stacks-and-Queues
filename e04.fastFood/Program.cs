using System;
using System.Collections.Generic;
using System.Linq;

namespace e04.fastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biggestOrder = 0;
            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = orders.Length;
            Queue<int> queueOrder = new Queue<int>(orders);
                biggestOrder = queueOrder.Max();
            for (int i = 0; i < count; i++)
            {
                //if (biggestOrder< queueOrder.Peek())
                //{
                //    biggestOrder = queueOrder.Peek();
                //}
                if (quantity>= queueOrder.Peek())
                {
                    quantity -= queueOrder.Peek();
                    queueOrder.Dequeue();
                }
                else
                {
                    break;
                }
            }
                    Console.WriteLine(biggestOrder);
            if (queueOrder.Count>0)
            {
                foreach (var element in queueOrder)
                {
                    Console.WriteLine($"Orders left: {element} ");
                }
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
