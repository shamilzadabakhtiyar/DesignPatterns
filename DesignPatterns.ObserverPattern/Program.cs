var amazon = new Amazon(); 

var samsung = new Product("Galaxy S23", 1000);
var aObserver = new AObserver("Bakhtiyar");

var iphone = new Product("iPhone 15", 1000);
var bObserver = new BObserver("Shamilzada");

amazon.Register(aObserver, samsung);
amazon.Register(bObserver, iphone);

amazon.NotifyForProductName("Galaxy S23");
amazon.NotifyForProductName("iPhone 15");

//amazon.NotifyAll();

class Amazon
{
    private Dictionary<IObserver, Product> observers = new();
    public void Register(IObserver observer, Product product)
    {
        observers.TryAdd(observer, product);
    }

    public void UnRegister(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyAll()
    {
        foreach (var item in observers)
        {
            item.Key.StockUpdate(item.Value);
        }
    }

    public void NotifyForProductName(string productName)
    {
        foreach (var item in observers)
        {
            if (item.Value.Name == productName)
                item.Key.StockUpdate(item.Value);
        }
    }
}

interface IObserver
{
    public string Fullname { get; set; }
    public void StockUpdate(Product product);
}

class AObserver : IObserver
{
    public string Fullname { get; set; }

    public AObserver(string fullname)
    {
        Fullname = fullname;
    }

    public void StockUpdate(Product product)
    {
        Console.WriteLine($"{Fullname}, Product {product.Name} in stock now");
    }
}

class BObserver : IObserver
{
    public string Fullname { get; set; }

    public BObserver(string fullname)
    {
        Fullname = fullname;
    }

    public void StockUpdate(Product product)
    {
        Console.WriteLine($"{Fullname}, Product {product.Name} in stock now");
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}