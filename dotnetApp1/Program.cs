namespace dotnetApp1
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hi {name}! The current time is {DateTimeOffset.UtcNow} UTC");
        }
    }
}