using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    public class CoffeeFactory : BeverageFactory
    {
        public override Beverage CreateBeverage(string type)
        {
            Beverage beverage = null;

            switch (type.ToLower())
            {
                case "espresso":
                    beverage = new Espresso();
                    break;
                case "doppio":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    break;
                case "lungo":
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    break;
                case "macchiato":
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    break;
                case "corretta":
                    beverage = new Espresso();
                    beverage = new Liqour(beverage);
                    break;
                case "con panna":
                    beverage = new Espresso();
                    beverage = new Whip(beverage);
                    break;
                case "cappuccino":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case "americano":
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    beverage = new Water(beverage);
                    break;
                case "caffé latte":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case "flat white":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    break;
                case "romana":
                    beverage = new Espresso();
                    beverage = new Lemon(beverage);
                    break;
                case "morocchino":
                    beverage = new Espresso();
                    beverage = new Chocolate(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case "mocha":
                    beverage = new Espresso();
                    beverage = new Chocolate(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;
                case "bicerin":
                    beverage = new Espresso();
                    beverage = new BlackChocolate(beverage);
                    beverage = new WhiteChocolate(beverage);
                    beverage = new Whip(beverage);
                    break;
                case "breve":
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    beverage = new HalfMilk(beverage);
                    break;
                case "raf coffee":
                    beverage = new Espresso();
                    beverage = new SugerVanilla(beverage);
                    beverage = new Cream(beverage);
                    break;
                case "mead raf":
                    beverage = new Espresso();
                    beverage = new Honey(beverage);
                    beverage = new Cream(beverage);
                    break;
                case "galao":
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case "caffé affogato":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new IceCream(beverage);
                    break;
                case "vienna coffee":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Whip(beverage);
                    beverage = new Whip(beverage);
                    break;
                case "glace":
                    beverage = new Espresso();
                    beverage = new IceCream(beverage);
                    break;
                case "chocolate milk":
                    beverage = new Chocolate();
                    beverage = new Milk(beverage);
                    beverage = new Milk(beverage);
                    break;
                case "demi-créme":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Cream(beverage);
                    break;
                case "latte macchiato":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case "freddo":
                    beverage = new Espresso();
                    beverage = new Liqour(beverage);
                    beverage = new Ice(beverage);
                    break;
                case "frappuccino":
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;
                case "caramel frappuccino":
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Syrup(beverage);
                    break;
                case "frappe":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new IceCream(beverage);
                    break;
                case "irish coffee":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Whiskey(beverage);
                    beverage = new Whip(beverage);
                    break;
                default:
                    throw new ArgumentException($"Unknown beverage type: {type}");
            }

            return beverage;
        }
    }
}
