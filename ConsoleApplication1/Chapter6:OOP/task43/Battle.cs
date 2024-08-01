using System;
using System.Xml;
using ConsoleApplication1.Chapter6_OOP.Task42;

namespace ConsoleApplication1.Chapter6_OOP.task43
{
    public class Battle
    {
        private IChampion _firstPlayer;
        private IChampion _secondPlayer;

        public Battle()
        {
            
        }
        public void StartBattle()
        {
            Console.WriteLine("Первый игрок, выбери себе персонажа - на выбор:\nБерсерк, Воин, Стрелок, Маг, Плут.");
            
            string firstPlayerAnswer = Convert.ToString(Console.ReadLine());
             _firstPlayer = ChooseChamp(firstPlayerAnswer);
             Console.Clear();
             
             Console.WriteLine("Второй игрок, выбери себе персонажа - на выбор:\nБерсерк, Воин, Стрелок, Маг, Плут.");
            string secondPlayerAnswer = Convert.ToString(Console.ReadLine());
             _secondPlayer = ChooseChamp(secondPlayerAnswer);
             Console.Clear();
            
            while (_firstPlayer.IsAlive() || _secondPlayer.IsAlive())
            {
                Console.WriteLine("Первый игрок, ваш ход");
                _firstPlayer.ShowStats();
                Console.WriteLine("Выберите атаку или Спец способность");
                firstPlayerAnswer = Convert.ToString(Console.ReadLine());
                PlayerTurn(firstPlayerAnswer, "первый");
                Console.ReadLine();
                Console.Clear();
                
                Console.WriteLine("Второй игрок, ваш ход");
                _secondPlayer.ShowStats();
                Console.WriteLine("Выберите атаку или Спец способность");
                firstPlayerAnswer = Convert.ToString(Console.ReadLine());
                PlayerTurn(firstPlayerAnswer, "второй");
                Console.ReadLine();
                Console.Clear();

            }
        }

        private IChampion ChooseChamp(string champ)
        {
            champ = champ.ToLower();
            IChampion playerChampion = null;
            switch (champ)
            {
                case "берсерк":
                    playerChampion = new Berserk(15, 3, 10, 4);
                    break;
                case "воин":
                    playerChampion = new Warrior(14, 4, 4);
                    break;
                case "стрелок":
                    playerChampion = new Ranger(8, 1, 10, 5);
                    break;
                case "маг":
                    playerChampion = new Mage(7, 1, 10, 4);
                    break;
                case "плут":
                    playerChampion = new Rogue(12, 2, 10, 4);
                    break;
            }

            return playerChampion;
        }

        private void PlayerTurn(string answer, string whichPlayer)
        {
            answer = answer.ToLower();
            if (whichPlayer == "первый")
            {
                switch (answer)
                {
                    case "атака":
                        _secondPlayer.TakeHit(_firstPlayer.GetDamage());
                        break;
                    case "спец способность":
                        _firstPlayer.UseAbility(3, _firstPlayer.IsAbilityCoolDown());
                        break;
                
                }
            }
            
            if (whichPlayer == "второй")
            {
                switch (answer)
                {
                    default:
                        Console.WriteLine("попробуйте снова");
                        break;
                    case "атака":
                        _firstPlayer.TakeHit(_secondPlayer.GetDamage());
                        break;
                    case "спец способность":
                        _secondPlayer.UseAbility(3,_secondPlayer.IsAbilityCoolDown());
                        break;
                }
            }
            
        }
    }
}