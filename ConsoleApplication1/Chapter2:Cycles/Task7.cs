using System;

namespace ConsoleApplication1
{
    public class Task7
    {
        public void Start()
        {
            Console.WriteLine("Type Exit to exit");
            
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "Exit")
                {
                    break;
                }
            }
            
        }
    }
}