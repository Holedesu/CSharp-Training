using System;

namespace ConsoleApplication1.Chapter6_OOP.Task45
{
    public class SquadBattle
    {
        public static void StartBattle()
        {
            Squad squad1 = new Squad("Russia", 13);
            Squad squad2 = new Squad("Germany", 10);
            
            while (!squad1.IsSquadDeceased()&& !squad2.IsSquadDeceased())
            {
                // squad1.ShowSquad();
                // Console.ReadLine();
                // Console.Clear();
                // squad2.ShowSquad();
                // Console.ReadLine();
                // Console.Clear();
                
                // Console.WriteLine("First squad attack");
                // Console.ReadLine();
                squad1.TakeDamage(squad2);
                // Console.WriteLine("Second squad attack");
                // Console.ReadLine();
                squad2.TakeDamage(squad1);
                
                // squad1.ShowDeseased();
                // Console.ReadLine();
                // Console.Clear();
                // squad2.ShowDeseased();
                // Console.ReadLine();
                // Console.Clear();
            }
            
            if (squad2.IsSquadDeceased())
            {
                Console.WriteLine(squad1.GetCountryName() + " won");
                Console.WriteLine("Your casualties: ");
                squad1.ShowDeseased();
                // Console.ReadLine();
                Console.WriteLine("Enemy's casualties: ");
                squad2.ShowDeseased();
            }
            else
            {
                Console.WriteLine(squad2.GetCountryName() + " won");
                Console.WriteLine("Your casualties: ");
                squad2.ShowDeseased();
                // Console.ReadLine();
                Console.WriteLine("Enemy's casualties: ");
                squad1.ShowDeseased();
                Console.ReadLine();
            }
            
            // Console.WriteLine("H");
        }
    }
}