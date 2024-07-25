using System;

namespace ConsoleApplication1.Chapter6_OOP.Task37
{
    public class Player1
    {
        public int PlayerX;
        public int PlayerY;

        public Player1()
        {
            
        }

        public Player1(int playerX, int playerY)
        {
            PlayerX = playerX;
            PlayerY = playerY;
        }

        public void ShowCoordinates()
        {
            Console.WriteLine($"Player coordinates: {PlayerX} {PlayerY}");
        }
    }
}