using System;

namespace ConsoleApplication1.Chapter6_OOP.task43
{
    public class Warrior : IChampion
    {
        private int _hp;
        private int _def;
        private int _dmg;
        private int _currDef;
        private int _abilityCoolDown = 0;
        
        public Warrior(int hp, int def, int dmg)
        {
            _hp = hp;
            _def = def;
            _dmg = dmg;
            
        }
        
        public void TakeHit(int opponentDmg)
        {
            if (_def < opponentDmg)
            {
                _hp -= opponentDmg;
            }
            else
            {
                Console.WriteLine("Your opponent blocked your attack");
            }
        }
        
        public void UseAbility(int mana, bool cooldown)
        {
            if (!cooldown)
            {
                _hp += 2;
                _abilityCoolDown = 3;
            }
        }

        public void UseAbility(bool cooldown)
        {
            if (!cooldown)
            {
                _hp += 2;
                _abilityCoolDown = 3;
            }
        }
        
        public bool IsAbilityCoolDown()
        {
            _abilityCoolDown--;
            return _abilityCoolDown > 0;
        }

        public bool IsAlive()
        {
            if (_hp <= 0)
            { 
                Console.WriteLine("Воин погиб");
                return false;
            }
            
            return true;
        }
        
        

        public int GetDamage()
        {
            int playerDamage = _dmg;
            return playerDamage;
        }
        
        public void ShowStats()
        {
            Console.WriteLine($"HP: {_hp}");
            Console.WriteLine($"DEF: {_def}");
            Console.WriteLine($"DMG: {_dmg}");
        }
    }
}