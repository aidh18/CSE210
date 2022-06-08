using System;

namespace CSE210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }
    }
}