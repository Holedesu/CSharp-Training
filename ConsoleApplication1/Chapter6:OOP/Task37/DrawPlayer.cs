using System;
using ConsoleApplication1.Chapter6_OOP.Task36;

namespace ConsoleApplication1.Chapter6_OOP.Task37
{
    public class DrawPlayer
    {
        private int _coordinateX;
        private int _coordinateY;

        public DrawPlayer(Player1 player)
        {
            _coordinateX = player.PlayerX;
            _coordinateY = player.PlayerY;
        }
        
        public void Draw()
        {
            Console.WriteLine("Player is a '$' symbol");
            Console.SetCursorPosition(_coordinateY, _coordinateX);
            Console.Write('$');
        }
    }
}