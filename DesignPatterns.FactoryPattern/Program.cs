PizzaStore aPizzaStore = new APizzaStore();
PizzaStore bPizzaStore = new BPizzaStore();

IPizza aCheesePizza = aPizzaStore.OrderPizza("cheese");
IPizza aVeggiPizza = aPizzaStore.OrderPizza("veggi");

IPizza bCheesePizza = bPizzaStore.OrderPizza("cheese");
IPizza bVeggiPizza = bPizzaStore.OrderPizza("veggi");
interface IPizza
{
    void Prepare();
    void Bake();
    void Cut();
}

class CheesePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Cheese pizza baked");
    }

    public void Cut()
    {
        Console.WriteLine("Cheese pizza cut");
    }

    public void Prepare()
    {
        Console.WriteLine("Cheese pizza prepared");
    }
}

class VeggiPizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Veggi pizza baked");
    }

    public void Cut()
    {
        Console.WriteLine("Veggi pizza cut");
    }

    public void Prepare()
    {
        Console.WriteLine("Veggi pizza prepared");
    }
}

abstract class PizzaStore
{
    protected abstract IPizza CreatePizza(string type);
    public IPizza OrderPizza(string type)
    {
        IPizza pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();

        return pizza;
    }
}

class APizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new CheesePizza(),
            "veggi" => new VeggiPizza(),
            _ => throw new ArgumentException("Invalid pizza type", nameof(type))
        };
    }
}

class BPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new CheesePizza(),
            "veggi" => new VeggiPizza(),
            _ => throw new ArgumentException("Invalid pizza type", nameof(type))
        };
    }
}