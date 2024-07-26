using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter6_OOP.Task39
{
    public class CardPlayer
    {
        private List<Card> _playerDeck;
        private static CardPack _cardPack = new CardPack();

        public CardPlayer()
        {
            _playerDeck = new List<Card>();
        }

        public void StartGame()
        {
            bool cycleSwitcher = true;
            _cardPack.GenerateDeck();
            int num;
            
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
        
        public void ShowPlayerDeck()
        {
            foreach (var card in _playerDeck)
            {
                card.ShowCard();
            }
        }

        public void TakeSeveralCards(int userAnswer)
        {
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