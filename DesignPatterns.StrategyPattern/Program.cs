var paymentOptions = new PaymentOptions()
{
    Amount = 1000,
    CardHolderName = "Bakhtiyar Shamilzada",
    CardNumber = 1234_5678_8765_4321,
    Cvv = 123,
    ExpirationDate = new DateTime(2023, 02, 28)
};

var paymentService = new PaymentService(new PashaBankPaymentService());
paymentService.PayViaStrategy(paymentOptions);

paymentService.SetPaymentService(new KapitalBankPaymentService());
paymentService.PayViaStrategy(paymentOptions);

class PaymentService
{
    private IPaymentService paymentService;

    public PaymentService()
    {
        
    }

    public PaymentService(IPaymentService paymentService)
    {
        this.paymentService = paymentService;
    }

    public void SetPaymentService(IPaymentService paymentService)
    {
        this.paymentService = paymentService;
    }

    public bool PayViaStrategy(PaymentOptions options)
    {
        return paymentService.Pay(options);
    }
}

class PashaBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions options)
    {
        Console.WriteLine("Payment with Pasha bank");
        return true;
    }
}

class KapitalBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions options)
    {
        Console.WriteLine("Payment with Kapital bank");
        return true;
    }
}

interface IPaymentService
{
    bool Pay(PaymentOptions options);
}

class PaymentOptions
{
    public long CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int Cvv { get; set; }
    public decimal Amount { get; set; }
}