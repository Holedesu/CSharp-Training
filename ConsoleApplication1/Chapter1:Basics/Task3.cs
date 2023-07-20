using System;

namespace ConsoleApplication1
{
    public class Task3
    {
        public void Start()
        {
            string name = "Smith";
            string surname = "Mike";
            string correctName = surname;
            string correctSurname = name;
            
            Console.WriteLine($"Your name is not {name} {surname}");
            name = correctName;
            surname = correctSurname;
            Console.WriteLine($"Your name is {name} {surname}");
        }
    }
}