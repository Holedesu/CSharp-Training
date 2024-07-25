using System;
using ConsoleApplication1.Chapter6_OOP.Task37;

// using ConsoleApplication1.Chapter3_Arrays;
// using ConsoleApplication1.Chapter4_Functions;
// using ConsoleApplication1.Chapter5_Collections;
// using ConsoleApplication1.Chapter6_OOP.Task36;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Player1 player = new Player1(21, 12);
            DrawPlayer draw = new DrawPlayer(player);
            draw.Draw();
        }
    }
}