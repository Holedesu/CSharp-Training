using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter6_OOP.Task39
{
    public class CardPack
    {
        private List<Card> _deck;

        public CardPack()
        {
            _deck = new List<Card>();
        }

        private void AddCard(Card card)
        {
            _deck.Add(card);
        }

        public void GenerateDeck()
        {
            int counter = 36;

            while (counter > 0)
            {
                Card newCard = new Card();

                AddCard(newCard);
                counter--;
            }
        }

        public void ShowDeck()
        {
            foreach (var card in _deck)
            {
                card.ShowCard();
            }
        }

        public int ShowLength()
        {
            return _deck.Count;
        }

        public Card GetCard()
        {
            return _deck[0];
        }

        public void DeleteCard()
        {
            _deck.RemoveAt(0);
        }
    }
}