using System;
using System.Diagnostics;

namespace ConsoleApplication1
{
    //SetName – установить имя;
    //ChangeConsoleColor- изменить цвет консоли;
    //SetPassword – установить пароль;
    //WriteName – вывести имя (после ввода пароля);
    //Esc – выход из программы.
    public class Task11
    {
        public void Start()
        {
            string name = string.Empty;
            string password = string.Empty;
            while (true)
            {
                Console.WriteLine("What option do you need?:\n" + 
                                  "1. SetName\n" + "2. ChangeConsoleColor\n" +
                                  "3. SetPassword\n" + "4. WriteName\n" + "5. Exit");
                string response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        Console.WriteLine("What is your name?");
                        name = Console.ReadLine();
                        break;
                    case "2":
                        ChangeConsoleColor();
                        break;
                    case "3":
                        password = Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine(name);
                        break;
                    case "5":
                        return;
                }
            }

        }

        private void ChangeConsoleColor()
        {
            while (true)
            {
                Console.WriteLine("What color do you want?(type number):\n" +
                                  "1. Grey\n" + "2. Green\n" + "3. Blue\n");
                string color = Console.ReadLine();
                switch (color)
                {
                    case "1":
                        Console.BackgroundColor = ConsoleColor.Gray;
                        return;
                    case "2":
                        Console.BackgroundColor = ConsoleColor.Green;
                        return;
                    case "3":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        return;
                    default:
                        Console.WriteLine("Type number from 1 to 3\n");
                        break;
                }
            }
        }
    }
}