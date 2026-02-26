using Microsoft.VisualBasic;

namespace Opgave_Plastic_fantastic
{

    public enum CardTypes {
        Visa,
        Mastercard,
    }

    class CreditCard
    {

        string cardNumber { get; set; }
        CardTypes cardType { get; set; }
        double maxCredit { get; set; }
        string ownerName { get; set; }
            
        public CreditCard(string cardNumber, CardTypes cardType)
            : this(cardNumber, cardType, 0.0, "Unknown")
        {
        }

        public CreditCard(string cardNumber, CardTypes cardType, double maxCredit)
            : this(cardNumber, cardType, maxCredit, "Unknown")
        {

        }

        public CreditCard(string cardNumber, CardTypes cardType, double maxCredit, string ownerName)
        {
            this.cardNumber = cardNumber;
            this.cardType = cardType;
            this.maxCredit = maxCredit;
            this.ownerName = ownerName;
        }
        public override string ToString()
        {
            return $"{cardType} - {cardNumber} - Limit: {maxCredit} - Holder: {ownerName}";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard a = new CreditCard("sdrfvser", CardTypes.Visa);
            CreditCard b = new CreditCard("sdrfvser", CardTypes.Mastercard, 8000.0);
            CreditCard c = new CreditCard("sdrfvser", CardTypes.Visa, 2, "Harry Potter");

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
