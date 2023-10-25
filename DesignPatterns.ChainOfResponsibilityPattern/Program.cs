var order = new Order();

var stockControl = new StockControl();
var paymentControl = new PaymentControl();
var invoiceControl = new InvoiceControl();
var shippingControl = new ShippingControl();

stockControl
    .SetNext(paymentControl)
    .SetNext(invoiceControl)
    .SetNext(shippingControl);

stockControl.Handle(order);

class StockControl : IOrderHandler
{
    private IOrderHandler next;
    public bool Handle(Order order)
    {
        Console.WriteLine("StockControl handle");
        bool stockAvailable = true; // check stock services
        if (next is not null && stockAvailable)
            return next.Handle(order);
        return false;
    }

    public IOrderHandler SetNext(IOrderHandler next)
    {
        return this.next = next;
    }
}

class PaymentControl : IOrderHandler
{
    private IOrderHandler next;
    public bool Handle(Order order)
    {
        Console.WriteLine("PaymentControl handle");
        bool paymentSuccess = true; // check payment services
        if (next is not null && paymentSuccess)
            return next.Handle(order);
        return false;
    }

    public IOrderHandler SetNext(IOrderHandler next)
    {
        return this.next = next;
    }
}

class InvoiceControl : IOrderHandler
{
    private IOrderHandler next;
    public bool Handle(Order order)
    {
        Console.WriteLine("InvoiceControl handle");
        bool invoiceCreated = true; // check invoice services
        if (next is not null && invoiceCreated)
            return next.Handle(order);
        return false;
    }

    public IOrderHandler SetNext(IOrderHandler next)
    {
        return this.next = next;
    }
}

class ShippingControl : IOrderHandler
{
    private IOrderHandler next;
    public bool Handle(Order order)
    {
        Console.WriteLine("ShippingControl handle");
        bool shippingSuccess = true; // check shipping services
        if (next is not null && shippingSuccess)
            return next.Handle(order);
        return false;
    }

    public IOrderHandler SetNext(IOrderHandler next)
    {
        return this.next = next;
    }
}

interface IOrderHandler
{
    bool Handle(Order order);
    IOrderHandler SetNext(IOrderHandler next);
}

class Order
{
    public string ProductName { get; set; }
    public int Quality { get; set; }
    public decimal Price { get; set; }
}