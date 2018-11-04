using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHW
{
    public class Deck
    {
        private Card[] cards;
        public Card this[int index]
        {
            get { return cards[index]; }
            set { cards[index] = value; }
        }

        public int GetSizeOfDeck()
        {
            return cards.Length;
        }

        public Deck()
        {
            cards = new Card[36];
            int i = 0;

            for (; i < 36; i++)
            {
                cards[i] = new Card();
            }

            i = 0;

            for (; i < 4; i++)
            {
                cards[i].lear = Lear.six;
            }

            for (; i < 8; i++)
            {
                cards[i].lear = Lear.seven;
            }

            for (; i < 12; i++)
            {
                cards[i].lear = Lear.eight;
            }

            for (; i < 16; i++)
            {
                cards[i].lear = Lear.nine;
            }

            for (; i < 20; i++)
            {
                cards[i].lear = Lear.ten;
            }

            for (; i < 24; i++)
            {
                cards[i].lear = Lear.man;
            }

            for (; i < 28; i++)
            {
                cards[i].lear = Lear.woman;
            }

            for (; i < 32; i++)
            {
                cards[i].lear = Lear.king;
            }

            for (; i < 36; i++)
            {
                cards[i].lear = Lear.ace;
            }

        }

        public void MixDeck()
        {
            Card[] cards1 = new Card[cards.Length];
            Random rand = new Random();
            for (int i = 0; i < cards1.Length; i++)
            {
                int randomNumber = rand.Next(0, cards.Length - 1);
                cards1[i] = cards[randomNumber];
                var copy = cards.ToList();
                copy.RemoveAt(randomNumber);
                cards = copy.ToArray();
            }
            cards = cards1;
        }

        public Card GetCards()
        {
            if (GetSizeOfDeck() > 0)
            {
                var card = cards[cards.Length - 1];
                Array.Resize(ref cards, cards.Length - 1);
                return card;
            }
            return new Card(-1);
        }

    }
}