using System;

namespace ConsoleApplication1.Chapter6_OOP.Task45
{
    public class Soldier
    {
        private int _health;
        private int _damage;
        
        public Soldier(int health, int damage)
        {
            _health = health;
            _damage = damage;
        }
        
        public int GetDamage()
        {
            return _damage;
        }
        
        public int GetHealth()
        {
            return _health;
        }
        
        public void TakeDamage(int damage)
        {
            _health -= damage;
        }
        
        public bool IsDead()
        {
            
            return _health <= 0;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"Soldier's health: {_health}");
        }
    }
}