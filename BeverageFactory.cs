using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System.IO;

namespace DecoratorPattern
{
    public class BeverageFactory
    {
        public Beverage CreateDrink(DrinkType type, Size size)
        {
            Beverage beverage;
            static void PrintBeverage(Beverage beverage)
            {
                Console.WriteLine($"{beverage.GetDescription()} ({beverage.Size}) ${beverage.cost():0.00}");
            }

            switch (type)
            {
                case DrinkType.Espresso:
                    beverage = new Espresso();
                    break;

                case DrinkType.Doppio:
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    break;

                case DrinkType.Lungo:
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    break;

                case DrinkType.Macchiato:
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    break;

                case DrinkType.Corretta:
                    beverage = new Espresso();
                    beverage = new Liquor(beverage);
                    break;

                case DrinkType.ConPanna:
                    beverage = new Espresso();
                    beverage = new Whip(beverage);
                    break;

                case DrinkType.Cappuccino:
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case DrinkType.Americano:
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    beverage = new Water(beverage);
                    break;

                case DrinkType.CaffeLatte:
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case DrinkType.FlatWhite:
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    break;

                case DrinkType.Romana:
                    beverage = new Espresso();
                    beverage = new Lemon(beverage);
                    break;

                case DrinkType.Marocchino:
                    beverage = new Espresso();
                    beverage = new Chocolate(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case DrinkType.Mocha:
                    beverage = new Espresso();
                    beverage = new Chocolate(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;

                case DrinkType.Bicerin:
                    beverage = new Espresso();
                    beverage = new BlackChocolate(beverage);
                    beverage = new WhiteChocolate(beverage);
                    beverage = new Whip(beverage);
                    break;

                case DrinkType.Breve:
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    beverage = new HalfMilk(beverage);
                    break;

                case DrinkType.RafCoffee:
                    beverage = new Espresso();
                    beverage = new VanillaSugar(beverage);
                    beverage = new Cream(beverage);
                    break;

                case DrinkType.MeadRaf:
                    beverage = new Espresso();
                    beverage = new Honey(beverage);
                    beverage = new Cream(beverage);
                    break;

                case DrinkType.Galao:
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case DrinkType.CaffeAffogato:
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new IceCream(beverage);
                    break;

                case DrinkType.ViennaCoffee:
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Whip(beverage);
                    beverage = new Whip(beverage);
                    break;

                case DrinkType.Glace:
                    beverage = new Espresso();
                    beverage = new IceCream(beverage);
                    break;

                case DrinkType.ChocolateMilk:
                    beverage = new Chocolate();
                    beverage = new Milk(beverage);
                    beverage = new Milk(beverage);
                    break;

                case DrinkType.DemiCreme:
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Cream(beverage);
                    break;

                case DrinkType.LatteMacchiato:
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case DrinkType.Freddo:
                    beverage = new Espresso();
                    beverage = new Liquor(beverage);
                    beverage = new Ice(beverage);
                    break;

                case DrinkType.Frappuccino:
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;

                case DrinkType.CaramelFrappuccino:
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Syrup(beverage);
                    break;

                case DrinkType.Frappe:
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new IceCream(beverage);
                    break;

                case DrinkType.IrishCoffee:
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Whiskey(beverage);
                    beverage = new Whip(beverage);
                    break;

                default:
                    throw new ArgumentException("whoopsie deze bestaat niet");
            }
            beverage.Size = size;
            PrintBeverage(beverage);

            return beverage;
        }
    }
}
