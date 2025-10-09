using DecoratorPattern.Beverages;

namespace DecoratorPattern
{
 
    public abstract class BeverageFactory
    {
       
        public abstract Beverage CreateBeverage(string type);
    }
}
