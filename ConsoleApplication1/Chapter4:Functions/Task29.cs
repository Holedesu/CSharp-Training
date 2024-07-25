using System;
using System.IO;

namespace ConsoleApplication1.Chapter4_Functions
{
    public class Task29
    {
        public void Start()
        {
            Console.CursorVisible = false;
            
            bool isPlaying = true;
            int pacmanX;
            int pacmanY;
            int directionX = 0;
            int directionY = 1;
            char[,] charMap = ReadMap("map", out pacmanX, out pacmanY);
            
            DrawMap(charMap);
            while (isPlaying)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.W:
                            directionX = -1;
                            directionY = 0;
                            break;
                        case ConsoleKey.S:
                            directionX = 1;
                            directionY = 0;
                            break;
                        case ConsoleKey.A:
                            directionX = 0;
                            directionY = -1;
                            break;
                        case ConsoleKey.D:
                            directionX = 0;
                            directionY = 1;
                            break;
                    }
                }
                if (charMap[pacmanX + directionX, pacmanY + directionY] != '#')
                {
                    PlayerMovement(ref pacmanX, ref pacmanY, directionX, directionY);
                }
                System.Threading.Thread.Sleep(200);
            }
        }

        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void PlayerMovement(ref int X, ref int Y, int DX, int DY)
        {
            Console.SetCursorPosition(Y, X);
            Console.Write(' ');
                        
            X += DX;
            Y += DY;
                        
            Console.SetCursorPosition(Y, X);
            Console.Write('@');
        }

        static char[,] ReadMap(string mapName, out int pacmanX, out int pacmanY)
        {
            pacmanX = 0;
            pacmanY = 0;
            string[] newFile = File.ReadAllLines($"{mapName}.txt");
            char[,] map = new char[newFile.Length, newFile[0].Length];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = newFile[i][j];
                    if (map[i, j] == '@')
                    {
                        pacmanX = i;
                        pacmanY = j;
                    }
                }
            }
            
            return map;
        }
        
        
    }
}