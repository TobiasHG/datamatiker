using System.Text;

namespace Opgave_Kortbunken
{

    class Card
    {

        public string value { get; set; }
        public string suit { get; set;  }

        public Card(string value, string suit)
        {
            this.value = value;
            this.suit = suit;
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return $"{this.value} {this.suit}";
        }


    }

    class CardDeck
    {

        public Card[] cards { get; set; }
        public void Shuffle()
        {
            Random rng = new Random();

            for (int i = cards.Length - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1); // 0 ≤ j ≤ i

                // swap
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public CardDeck()
        {
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            cards = new Card[52];

            int index = 0;

            foreach(string suit in suits)
            {
                foreach(string value in values)
                {
                    cards[index] = new Card(value, suit);
                    index++;
                }

                
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Card card in this.cards)
            {
                sb.Append(card.ToString());
                sb.Append(", ");
            }

            return sb.ToString();
        }
    }

    class Person
    {
        string name { get; set; } 
        Card[] cards { get; set; }

        public Person(string name)
        {
            this.name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            CardDeck cardDeck = new CardDeck();
            cardDeck.Shuffle();

        }
    }
}
