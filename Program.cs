using System;
using System.Collections.Generic;
using System.Linq;

namespace e06.songsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> songArray = Console.ReadLine().Split(", ").ToList();
            Queue<string> songs = new Queue<string>(songArray);
            while (songs.Count>0)
            {
                string command = Console.ReadLine();
                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string song = command.Substring(4);
                    if (!songs.Contains(song))
                    {
                    songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
                if (songs.Count < 1)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
            }
        }
    }
}
