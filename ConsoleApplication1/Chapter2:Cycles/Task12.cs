using System;

namespace ConsoleApplication1
{
    public class Task12
    {
        private int sidechars = 2;
        public void Start()
        {
            Console.WriteLine("What is your name?: ");
            string userName = Console.ReadLine();
            
            Console.WriteLine("What symbol would you like to use?: ");
            string symbol = Console.ReadLine();
            
            string symbolString = string.Empty;

            for (int i = 0; i < userName.Length + sidechars; i++)
            {
                symbolString += symbol;
            }
            Console.WriteLine($"{symbolString}\n{symbol}{userName}{symbol}\n{symbolString}");
        }
    }
}