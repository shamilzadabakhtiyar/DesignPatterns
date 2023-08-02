using DesignPatterns.FactoryPattern;
using DesignPatterns.FactoryPattern;

#region Method1
//string cardType = "MoneyBack";
//ICreditCard creditCard = null;

//if (cardType == "MoneyBack")
//    creditCard = new MoneyBack();
//else if (cardType == "Titanium")
//    creditCard = new Titanium();
//else if (cardType == "Platinum")
//    creditCard = new Platinum();

//if (creditCard != null)
//{
//    Console.WriteLine(creditCard.GetCardType());
//    Console.WriteLine(creditCard.GetCreditLimit());
//    Console.WriteLine(creditCard.GetAnnualCharge());
//}
//else
//    Console.WriteLine("Invalid card type");
#endregion

#region Method2
//ICreditCard cardDetails = CreditCardFactory1.GetCreditCard("Platinum");
//if (cardDetails != null)
//{
//    Console.WriteLine(cardDetails.GetCardType());
//    Console.WriteLine(cardDetails.GetCreditLimit());
//    Console.WriteLine(cardDetails.GetAnnualCharge());
//}
//else
//    Console.Write("Invalid Card Type");
#endregion

#region Method3
ICreditCard creditCard = new PlatinumFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine(creditCard.GetCardType());
    Console.WriteLine(creditCard.GetCreditLimit());
    Console.WriteLine(creditCard.GetAnnualCharge());
}
else
    Console.Write("Invalid Card Type");
#endregion