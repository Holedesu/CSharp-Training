using System;
// using ConsoleApplication1.Chapter3_Arrays;
// using ConsoleApplication1.Chapter4_Functions;
// using ConsoleApplication1.Chapter5_Collections;
using ConsoleApplication1.Chapter6_OOP.Task36;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Player player1 = new Player(100, 100, "Mark");
            Player player2 = new Player();
            player2.Health = 100;
            player2.Mana = 50;
            player2.Name = "Boris";
            player1.ShowInfo();
            player2.ShowInfo();
        }
    }
}