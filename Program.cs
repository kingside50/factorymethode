using DecoratorPattern;
using DecoratorPattern.Beverages;

internal class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        CoffeeFactory factory = new CoffeeFactory();


        string[] beverages = new string[]
      {
    "espresso",
    "doppio",
    "lungo",
    "macchiato",
    "corretta",
    "con panna",
    "cappuccino",
    "americano",
    "caffé latte",
    "flat white",
    "romana",
    "morocchino",
    "mocha",
    "bicerin",
    "breve",
    "raf coffee",
    "mead raf",
    "galao",
    "caffé affogato",
    "vienna coffee",
    "glace",
    "chocolate milk",
    "demi-créme",
    "latte macchiato",
    "freddo",
    "frappuccino",
    "caramel frappuccino",
    "frappe",
    "irish coffee"
      };



        foreach (var bevName in beverages)
        {
            Beverage beverage = factory.CreateBeverage(bevName);
            beverage.Size = GetRandomSize(rand);
            PrintBeverage(beverage);
        }
        Console.WriteLine("Drankenlijst klaar. Druk op een toets om te sluiten...");
    }

    static void PrintBeverage(Beverage beverage)
    {
        Console.WriteLine($"{beverage.GetDescription()} ({beverage.Size}) ${beverage.cost():0.00}");
    }

    static Size GetRandomSize(Random rand)
    {
        return (Size)rand.Next(3); // 0 = Tall, 1 = Grande, 2 = Venti
    }

}
