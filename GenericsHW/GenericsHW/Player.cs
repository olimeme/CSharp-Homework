using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GenericsHW
{
   public class Player
    {
        private Card[] cards;

        public int Number { get; set; }

        public bool IsYou { get; set; }

        public Player()
        {
            cards = new Card[0];
            Number = 0;
            IsYou = false;
        }

        public void TakeOneCard(Deck deck)
        {
            if (cards.Length < 6)
            {
                var copy = deck.GetCards();
                if (copy.lear != Lear.error)
                {
                    Array.Resize(ref cards, cards.Length + 1);
                    cards[cards.Length - 1] = new Card();
                    cards[cards.Length - 1] = copy;
                }
            }
        }

        public Card GetCard(int index)
        {
            return cards[index];
        }

        public void TakeOneCard(Card card)
        {
                    Array.Resize(ref cards, cards.Length + 1);
                    cards[cards.Length - 1] = new Card();
                    cards[cards.Length - 1] = card;                
            }
        

        public int GetCountOfCards()
        {
            return cards.Length;
        }

        public void PlayCard()
        {
            for(int i = 0; i < cards.Length - 1; i++)
            {
                cards[i] = cards[i + 1];
            }
            Array.Resize(ref cards, cards.Length - 1);
        }

        public void RemoveFirstCardToLast()
        {
            var copy = cards[0];
            for(int i = 0; i < cards.Length-1; i++)
            {
                cards[i] = cards[i + 1];
            }
            cards[cards.Length - 1] = copy;
        }
        
        public Lear GetLear(int i)
        {
            if (cards.Length < 0) return Lear.error;
            return cards[i].lear;
        }
        public Player ShowCards()
        {
            if (cards.Length > 0)
            {
                cards[0].ShowInfo();
            }
            return this;
        }
    }
}