using System;

namespace ConsoleApplication1.Chapter6_OOP.task43
{
    public class Mage : IChampion
    {
        private int _hp;
        private int _def;
        private int _mana;
        private int _dmg;
        private int _abilityCoolDown = 0;
        private int _currDef;
        
        public Mage(int hp, int def, int mana, int dmg)
        {
            _hp = hp;
            _def = def;
            _mana = mana;
            _dmg = dmg;
            _currDef = def;
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
            if (_mana >= 5)
            {
                _mana -= 5;
                _abilityCoolDown = 5;
                _def = 20;
            }
            else
            {
                Console.WriteLine("You don't have enough mana");
            }
        }
        
        public void AbilityExpired()
        {
            _def = _currDef;
        }

        public void ManaRegen()
        {
            if (_mana < 10)
            {
                _mana += 1;
            }
        }
        
        public bool IsAlive()
        {
            if (_hp <= 0)
            { 
                Console.WriteLine("Берсерк погиб");
                return false;
            }
            
            return true;
        }
        
        public bool IsAbilityCoolDown()
        {
            _abilityCoolDown--;
            return _abilityCoolDown > 0;
        }
        
        public void ShowStats()
        {
            Console.WriteLine($"HP: {_hp}");
            Console.WriteLine($"DEF: {_def}");
            Console.WriteLine($"Mana: {_mana}");
            Console.WriteLine($"DMG: {_dmg}");
        }

        public int GetDamage()
        {
            return _dmg;
        }
    }
}