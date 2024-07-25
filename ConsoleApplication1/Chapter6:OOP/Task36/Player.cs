using System;

namespace ConsoleApplication1.Chapter6_OOP.Task36
{
    public class Player
    {
        public int Health;
        public int Mana;
        public string Name;
        private int _id;

        public Player()
        {
            Random random = new Random();
            _id = random.Next(0, 999);
        }
        
        public Player(int health, int mana, string name)
        {
            Random random = new Random();
            Health = health;
            Mana = mana;
            Name = name;
            _id = random.Next(0, 999);
        }

        public void ShowInfo()
        {
            
            Console.WriteLine($"Fist player info:\nHP: {Health}\nMP:{Mana}\nName: {Name}\nID: {_id}");
        }
    }
}