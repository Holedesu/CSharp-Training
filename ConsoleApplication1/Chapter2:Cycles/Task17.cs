using System;
using System.Diagnostics;

namespace ConsoleApplication1
{
    public class Task17
    {
        private int _bossHealth = 350;
        private int _playerHealth = 100;
        
        private bool _IsSummoned = false;
        private int _summonedTime = 0;
        
        private int _cursedTime = 0;
        private int fireDamage = 25;
        private int timedOutCursed = 0;

        private bool isSafe = false;
        
        public void Start()
        {
            Console.WriteLine("What is your name, hero?");
            string name = Console.ReadLine();
            int bossAttack = 15;
            while (_bossHealth > 0 && _playerHealth > 0)
            {
                Console.WriteLine("Your attacks:\n" + 
                                  "1. Рашамон – призывает теневого духа для нанесения атаки(35)(-15 hero hp)\n" +
                                  "2. Хуганзакура (Может быть выполнен только после призыва теневого духа), наносит 15 ед. урона\n" + 
                                  "3. Межпространственный разлом – позволяет скрыться в разломе и восстановить 25 хп. Урон босса по вам не проходит\n" +
                                  "4. Проклятый огонь, наносит 25 переодического урона в течении 3-х ходов, откат 4 хода\n");
                
                string response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        Rashamon();
                        break;
                    case "2":
                        Huganzakura();
                        break;
                    case "3":
                        DimensionalRift();
                        break;
                    case "4":
                        CursedFire();
                        break;
                    
                }

                if (_IsSummoned)
                {
                    _summonedTime -= 1;
                    Console.WriteLine("Summoned time: " + _summonedTime);
                }
                if (_summonedTime == 0)
                {
                    _IsSummoned = false;
                    Console.WriteLine("Summon died");
                }

                if (_cursedTime > 0)
                {
                    _bossHealth -= fireDamage;
                }

                if (_cursedTime > 0)
                {
                    _cursedTime -= 1;
                }
                Console.WriteLine("Boss health: " + _bossHealth);
                Console.WriteLine("Player health: " + _playerHealth);
                
                if (isSafe == true)
                {
                    Console.WriteLine("Boss missed");
                }
                else
                {
                    _playerHealth -= bossAttack;
                }
                isSafe = false;
            }

            
            
        }

        public void Rashamon()
        {
            
            _bossHealth -= 35;
            _playerHealth -= 15;
            _IsSummoned = true;
            _summonedTime = 4;
        }

        public void Huganzakura()
        {
            if (_IsSummoned)
            {
                _bossHealth -= 15;
            }
            else
            {
                Console.WriteLine("Условия не выполнены");
            }

        }
        
        public void DimensionalRift()
        {
            if (_playerHealth < 100)
            {
                _playerHealth += 25;
            }
            if (_playerHealth > 100)
            {
                _playerHealth = 100;
            }
            isSafe = true;
        }
        
        public void CursedFire()
        {
            _cursedTime = 4;
        }
    }
}