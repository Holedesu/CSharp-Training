using System;

namespace ConsoleApplication1
{
    public class Task14
    {
        public void Start()
        {
            int startInterval = 1;
            int endInterval = 27;
            int maxNumberToCheck = 1000;
            int minNumberToCheck = 100;
            int numberN;
            Random random = new Random();
            int counter=0;

            numberN = random.Next(startInterval, endInterval);
            Console.WriteLine($"Число N - {numberN}");

            for(int i = 0; i < maxNumberToCheck; i += numberN) 
            {
                if(i >= minNumberToCheck)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Трехзначных чисел кратных N - {counter}");
        }
    }
}