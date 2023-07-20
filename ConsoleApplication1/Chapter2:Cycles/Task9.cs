using System;

namespace ConsoleApplication1
{
    public class Task9
    {
        public void Start()
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 101);
            Console.WriteLine($"Random number: {randNum}");
            for (int i = 0; i <= randNum; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}