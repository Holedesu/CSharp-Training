using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter6_OOP.Task39
{
    public class CardPlayer
    {
        private List<Card> _playerDeck;
        private static CardPack _cardPack = new CardPack();

        // Создает игрока с пустой рукой
        public CardPlayer()
        {
            _playerDeck = new List<Card>();
        }

        // Начало игры
        public void StartGame()
        {
            bool cycleSwitcher = true;
            int num;
            
            //Генерирует колоду дилера для игры
            _cardPack.GenerateDeck();
            
            
            while (cycleSwitcher)
            {
                Console.WriteLine($"В колоде {_cardPack.ShowLength()} карт");
                Console.WriteLine("1. Взять карту\n2. Взять какое-то кол-ва карт\n3. Посмотреть руку");
                string playerAnswer = Convert.ToString(Console.ReadLine());

                switch (playerAnswer)
                {
                    default:
                        Console.WriteLine("Введен непонятный символ, попробуйте снова!");
                        continue;
                    case "1":
                        _playerDeck.Add(_cardPack.GetCard());
                        _cardPack.DeleteCard();
                        continue;
                    case "2":
                        Console.WriteLine("Какое кол-во карт вы возьмете?");
                        string cardQuantity = Convert.ToString(Console.ReadLine());
                        
                        //Провепяет что введена цифра, если нет, выводит сообщение
                        if (int.TryParse(cardQuantity, out num))
                        {
                            TakeSeveralCards(Convert.ToInt32(cardQuantity)); 
                        }
                        else
                        {
                            Console.WriteLine("Введен невнрный символ, попробуйте снова");
                        }
                        continue;
                    case "3":
                        ShowPlayerDeck();
                        cycleSwitcher = false;
                        break;
                }
            }
        }
        
        // Показывает карты в руке
        public void ShowPlayerDeck()
        {
            foreach (var card in _playerDeck)
            {
                card.ShowCard();
            }
        }

        // Метод для набора более одной карты
        public void TakeSeveralCards(int userAnswer)
        {
            // Проверка, что карт хватает в колоде и игрок ввел положительное число
            if (userAnswer < _cardPack.ShowLength() && userAnswer > 0)
            {
                while (userAnswer > 0)
                {
                    _playerDeck.Add(_cardPack.GetCard());
                    _cardPack.DeleteCard();
                    userAnswer--;
                }
            }
            else
            {
                Console.WriteLine("Вы взяли неверное кол-во карт, попробуйте снова!");
            }
        }
    }
}