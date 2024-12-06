using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

namespace lab52024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.WriteLine("Enter the card type you would like to visit: ");
            string card = Console.ReadLine();
            switch (card.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackFactory(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(100000, 0);
                    break;
                case "visadebit":
                    factory = new VisaCardFactory(200000, 0);
                    break;
                default:
                    break;
            }
            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("Your card details are below");
            Console.WriteLine("Card Type: {0}\nCreditLimit: {1}\nAnnualCharge:{2}", creditCard.CardType, creditCard.CREDITLIMIT, creditCard.ANNUALCHARGE);

        }
    }
    public abstract class CreditCard  // 1.Suzdava se absktrakten bazov klas creditCard koito opisva kreditna karta
    {
        protected string cardType;
        protected int creditLimit;
        protected int annualCharge;
        public CreditCard(int creditLimit, int annualCharge)
        {
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }
        public abstract string CardType { get; }
        public int CREDITLIMIT
        {
            get
            {
                return creditLimit;
            }
            set
            {
                creditLimit = value;
            }
        }
        public int ANNUALCHARGE
        {
            get
            {
                return annualCharge;
            }
            set
            {
                annualCharge = value;
            }
        }
    }
    public class MoneyBackCreditCard : CreditCard //2.Suzdavat se proizvodni na CreditCard koito opisvat konkretni vidove karti : MoneyBackCreditCard  i TitaniumCard
    {
        public MoneyBackCreditCard(int creditLimit, int annualCharge) : base(creditLimit, annualCharge)
        {
            cardType = "MoneyBack";
        }
        public override string CardType
        {
            get
            {
                return cardType;
            }
        }
    }
    public class TitaniumCard : CreditCard
    {
        public TitaniumCard(int creditLimit, int annualCharge) : base(creditLimit, annualCharge)
        {
            cardType = "Titanium";
        }
        public override string CardType
        {
            get
            {
                return cardType;
            }
        }
    }
    public abstract class CardFactory //3.Suzdava se absktrakten klas CardFactory koito shte sudurja metoda "Fabrika" - absktrakten metod GetCreditCard() koito shte se griji za suzdavaneto na obektite
    {
        public abstract CreditCard GetCreditCard();
    }
    public class MoneyBackFactory : CardFactory //4. Suzdavat se dva proizvodni klasa - MoneyBackFactory i TitaniumFactory v koito se predifinirat metoda fabrika i se suzdavat suotvenite obekti 
    {
        private int creditLimit;
        private int annualCharge;
        public MoneyBackFactory(int creditLimit, int annualCharge)
        {
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }
        public override CreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(creditLimit, annualCharge);
        }
    }
    public class TitaniumFactory : CardFactory
    {
        private int creditLimit;
        private int annualCharge;
        public TitaniumFactory(int creditLimit, int annualCharge)
        {
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }
        public override CreditCard GetCreditCard()
        {
            return new TitaniumCard(creditLimit, annualCharge);
        }
    }
    public class VisaDebit : CreditCard
    {
        public VisaDebit(int creditLimit, int annualCharge) : base(creditLimit, annualCharge)
        {
            cardType = "visadebit";
        }
        public override string CardType
        {
            get
            {
                return cardType;
            }

        }
    }
    public class VisaCardFactory : CardFactory
    {
        private int creditLimit;
        private int annualCharge;
        public VisaCardFactory(int creditLimit, int annualCharge)
        {
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }
        public override CreditCard GetCreditCard()
        {
            return new VisaDebit(creditLimit, annualCharge);
        }
    }
}

