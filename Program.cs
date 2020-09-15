using System;

namespace HelloYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello You!");
            Console.WriteLine("My name is Gøran, what's yours?");
            string name = Console.ReadLine();
            int nameLength = name.Length;
            char firstLetter = name[0];
            Console.WriteLine($"Hello {name}, your name is {nameLength} characters long and starts with an {firstLetter}", name, nameLength, firstLetter);
        }
    }
}
