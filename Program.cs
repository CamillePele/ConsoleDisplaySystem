using System;

namespace ConsoleDisplaySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen(30, 10);
            Element helloWorld = new Element(new string[] {"Hello", "World"},
                new Coordinates(15, 5),
                Animation.Typing, Placement.mid, ConsoleColor.White, ConsoleColor.Black);
            screen.DisplayElement(helloWorld);
            string wait = Console.ReadLine();
        }
    }
}