using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter6_OOP.Task39
{
    public class Card
    {
        private Dictionary<string, string> _card;
        
        private string _suit;
        private string _seniority;
        
        private string[] _suitType = new[] { "spades", "hearts", "diamods", "clubs" };
        private string[] _seniorityType = new[] { "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        
        // Создает нужную вам карту
        private Card(string suit, string seniority)
        {
            _suit = suit;
            _seniority = seniority;
        }
        
        // Создает карту автоматически
        public Card()
        {
            Card card = GenerateCard();
            _card = new Dictionary<string, string>();

            _card.Add(card.GetSuit(), card.GetSeniority());
        }

        // Создает вашу автоматически
        public void ShowCard()
        {
            Console.WriteLine($"Your card is : {_seniority} {_suit}");
        }

        // Возвращает масть
        public string GetSuit()
        {
            return _suit;
        }
        
        // Возвращает название карты
        public string GetSeniority()
        {
            return _seniority;
        }

        // Генератор карты
        public Card GenerateCard()
        {
            Random randomSuit = new Random();
            Random randomSeniority = new Random();

            _suit = _suitType[randomSuit.Next(_suitType.Length)];
            _seniority = _seniorityType[randomSeniority.Next(_seniorityType.Length)];
            
            Card generated = new Card(_suit, _seniority);
            
            return generated;
        }
        
        

    }
}