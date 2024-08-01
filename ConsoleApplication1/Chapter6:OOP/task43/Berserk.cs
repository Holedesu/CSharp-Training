using System;

namespace ConsoleApplication1.Chapter6_OOP.task43
{
    public class Berserk : IChampion
    {
        private int _hp;
        private int _def;
        private int _rage;
        private int _dmg;
        private int _abilityCoolDown = 0;

        public Berserk(int hp, int def, int rage, int dmg)
        {
            _hp = hp;
            _def = def;
            _rage = rage;
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

        public void UseAbility(int rage, bool cooldown)
        {
            if (!cooldown && _rage > 5)
            {
                _rage = 0;
                _dmg += 2;
                _abilityCoolDown = 3;
            }
        }
        
        public void RageRegen()
        {
            if (_rage < 10)
            {
                _rage += 1;
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
                Console.WriteLine("Берсерк погиб");
                return false;
            }
            
            return true;
        }

        public void AbilityExpired()
        {
            _dmg -= 2;
        }

        public int GetDamage()
        {
            return _dmg;
        }

        public int GetRage()
        {
            return _rage;
        }
        
        public void ShowStats()
        {
            Console.WriteLine($"HP: {_hp}");
            Console.WriteLine($"DEF: {_def}");
            Console.WriteLine($"RAGE: {_rage}");
            Console.WriteLine($"DMG: {_dmg}");
        }
    }
}