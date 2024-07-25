using System;
using System.Globalization;

namespace ConsoleApplication1.Chapter4_Functions
{
    public class Task28
    {
        private bool cycleBool = true;
        public void Start()
        {
            while (cycleBool)
            {
                Console.WriteLine("Enter the num: ");
                string userInput = Console.ReadLine();
                ParseInt(userInput);
            }
        }

        public void ParseInt(string userInt)
        {
            int num;

            if (int.TryParse(userInt, out num))
            {
                Console.WriteLine("Succsessful convertion");
                cycleBool = false;
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
    }
}