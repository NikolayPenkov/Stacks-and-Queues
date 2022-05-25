//using System;
//using System.Collections;
//using System.Linq;
//using System.Collections.Generic;

//namespace e03maximumAndMinimumElement
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            int n = int.Parse(Console.ReadLine());
//            Stack<int>  stack = new Stack<int>();
//            for (int i = 0; i < n; i++)
//            {
//                int[] order = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//               int toDo = order[0];

//                switch (toDo)
//                {
//                    case 1:
//                    int element = order[1];
//                        stack.Push(element);
//                        break;
//                    case 2:
//                        stack.Pop();
//                        break;
//                    case 3:
//                        if (stack.Count>0)
//                        {
//                            int maxNumber = stack.Max();
//                            Console.WriteLine(maxNumber);
//                        }
                       
//                        break;
//                    case 4:
//                        if (stack.Count > 0)
//                        {
//                            int minNumber = stack.Min();
//                            Console.WriteLine(minNumber);
//                        }
//                        break;
                   
//                }
               
//            }
//            for (int i = stack.Count; i > 0; i--)
//            {
//                //List<int> currElement = new List<int>();
//                for (int j = stack.Count; j > 0; j--)
//                {
//                    int [] array = stack.Split(" ")Select
//                    stack.Pop();
//                    if (stack.Count > 1)
//                    {
//                        Console.WriteLine($"{stack.Peek},");
//                    }
//                    else
//                    {
//                        Console.WriteLine(stack.First);
//                    }
//                }
                    
              
//            }
           
//        }
//    }
//}
