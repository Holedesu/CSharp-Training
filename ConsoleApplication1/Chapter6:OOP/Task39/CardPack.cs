using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter6_OOP.Task39
{
    public class CardPack
    {
        private List<Card> _deck;

        // Создает пустую колоду
        public CardPack()
        {
            _deck = new List<Card>();
        }

        // Добавляет в колоду карту
        private void AddCard(Card card)
        {
            _deck.Add(card);
        }

        // Генерирует готовую колоду
        public void GenerateDeck()
        {
            // Размер стандартной колоды
            int counter = 36;
            
            // Добавляется до тех пор, пока колода не будет заполнена
            while (counter > 0)
            {
                Card newCard = new Card();

                AddCard(newCard);
                counter--;
            }
        }

        // Показывает текущую колоду
        public void ShowDeck()
        {
            foreach (var card in _deck)
            {
                card.ShowCard();
            }
        }
        
        // Показывает размер колоды
        public int ShowLength()
        {
            return _deck.Count;
        }

        // Возращает вытянутую карту из колоды
        public Card GetCard()
        {
            return _deck[0];
        }

        // Удаляет вытянутую карту из колоды
        public void DeleteCard()
        {
            _deck.RemoveAt(0);
        }
    }
}