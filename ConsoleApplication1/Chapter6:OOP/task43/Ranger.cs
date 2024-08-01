using System;

namespace ConsoleApplication1.Chapter6_OOP.task43
{
    public class Ranger : IChampion
    {
        private int _hp;
        private int _def;
        private int _mana;
        private int _dmg;
        private int _abilityCoolDown = 0;
        
        public Ranger(int hp, int def, int mana, int dmg)
        {
            _hp = hp;
            _def = def;
            _mana = mana;
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
                _dmg += 3;
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
            return _dmg;
        }
        
        public void ManaRegen()
        {
            if (_mana < 10)
            {
                _mana += 1;
            }
        }
        
        public void ShowStats()
        {
            Console.WriteLine($"HP: {_hp}");
            Console.WriteLine($"DEF: {_def}");
            Console.WriteLine($"MANA: {_mana}");
            Console.WriteLine($"DMG: {_dmg}");
        }
        
        public void AbilityExpired()
        {
            _dmg -= 3;
        }
        
    }
}