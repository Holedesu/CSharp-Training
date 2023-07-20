using System;

namespace ConsoleApplication1
{
    public class Task15
    {
        public void Start()
        {
            Console.WriteLine("Enter the number: ");

            int degreeOfTwo = 2;
            int i = 1;
            
            Random rand = new Random();
            int randInt = rand.Next(1, 1000);
            
            while (degreeOfTwo <= randInt)
            {
                degreeOfTwo *= 2;
                i++;
            }
            Console.WriteLine(randInt);
            Console.WriteLine($"Number is {degreeOfTwo} and degree of two is {i}");
        }
    }
}