using System;

namespace ConsoleApplication1
{
    public class Task1
    {
        public void Start()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Enter your name: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter zoodiac sign: ");
            
            string zodiacSign = Console.ReadLine();
            
            Console.WriteLine("Enter your place of work: ");
            
            string job = Console.ReadLine();
            
            Console.WriteLine($"Your name is {name}, yuor are {age} and your zodiac sign is {zodiacSign}, you job is {job}");
        }
    }
}