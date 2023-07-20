using System;

namespace ConsoleApplication1
{
    public class Task4
    {
        private const int CRYSTAL_PRICE = 7;
        public void Start()
        {
            Console.WriteLine("How many coins do you have?: ");
            int money = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("How many crystals do you want?: ");
            int crystals = Convert.ToInt32(Console.ReadLine());
            
            money -= crystals * CRYSTAL_PRICE;
            
            Console.WriteLine($"You still have {money} coins and {crystals} crystals");
        }
    }
}