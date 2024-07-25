using System;

using ConsoleApplication1.Chapter6_OOP.Task38;
// using ConsoleApplication1.Chapter6_OOP.Task37;
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
            PlayerPartThree player = new PlayerPartThree("Öbama", 1);
            PlayerPartThree player2 = new PlayerPartThree("Babadzaki", 1);

            DataBase playersBase = new DataBase();
            
            playersBase.AddData(player);
            playersBase.AddData(player2);
            playersBase.BanPlayer(1);
            playersBase.ShowAllData();
            playersBase.BanPlayer(2);
            playersBase.UnbanPlayer(1);
            playersBase.ShowAllData();
        }
    }
}