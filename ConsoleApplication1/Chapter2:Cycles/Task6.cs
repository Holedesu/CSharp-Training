using System;

namespace ConsoleApplication1
{
    public class Task6
    {
        public void Start()
        {
            int startNum = 0;
            Console.WriteLine("Your message: ");
            string message = Console.ReadLine();
            
            Console.WriteLine("Repeat number: ");
            int repeat = Convert.ToInt32(Console.ReadLine());

            while (startNum++ < repeat)
            {
                Console.WriteLine(message);
            }
        }
    }
}