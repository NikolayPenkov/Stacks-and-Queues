using System;
using System.Collections.Generic;
using System.Linq;
namespace e01.basicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputForNSX = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] randomNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = inputForNSX[0]; //N representing the number of elements to push into the stack
            int s = inputForNSX[1]; //S representing the number of elements to pop from the stack
            int x = inputForNSX[2]; // an element that you should look for in the stack
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                stack.Push(randomNumbers[i]);
            }
            for (int i = s; i > 0; i--)
            {
                stack.Pop();
            }
            if (stack.Count > 0)
            {
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int minNumber = stack.Min();
                    Console.WriteLine(minNumber);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
