using System;

namespace ConsoleApplication1.Chapter4_Functions
{
    public class Task27
    {
        public void Start()
        {
            Console.WriteLine("HP:");
            DrawBar(4, 10);
            Console.WriteLine("MP:");
            DrawBar(6, 10, 2);
        }

        public void DrawBar(int currentHealth, int maxHealth, int position = 1)
        {
            string bar = "";
            for (int i = 0; i < currentHealth; i++)
            {
                bar += "#";
            }
            
            Console.SetCursorPosition(5, position);
            Console.Write("[");
            Console.Write(bar);
            bar = "";
            maxHealth -= currentHealth;
            for (int i = 0; i < maxHealth; i++)
            {
                bar += "_";
            }
            Console.Write(bar + "]");
            Console.WriteLine();
        }
    }
}