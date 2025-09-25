using DecoratorPattern.Beverages;
using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new BeverageFactory();

            Beverage espresso = factory.CreateDrink(DrinkType.Espresso, Size.TALL);

            Beverage doppio = factory.CreateDrink(DrinkType.Doppio, Size.GRANDE);

            Beverage lungo = factory.CreateDrink(DrinkType.Lungo, Size.VENDI);

            Beverage macchiato = factory.CreateDrink(DrinkType.Macchiato, Size.TALL);

            Beverage corretta = factory.CreateDrink(DrinkType.Corretta, Size.GRANDE);

            Beverage conPanna = factory.CreateDrink(DrinkType.ConPanna, Size.VENDI);

            Beverage cappuccino = factory.CreateDrink(DrinkType.Cappuccino, Size.TALL);

            Beverage americano = factory.CreateDrink(DrinkType.Americano, Size.GRANDE);

            Beverage caffeLatte = factory.CreateDrink(DrinkType.CaffeLatte, Size.VENDI);

            Beverage flatWhite = factory.CreateDrink(DrinkType.FlatWhite, Size.TALL);

            Beverage romana = factory.CreateDrink(DrinkType.Romana, Size.GRANDE);

            Beverage marocchino = factory.CreateDrink(DrinkType.Marocchino, Size.VENDI);

            Beverage mocha = factory.CreateDrink(DrinkType.Mocha, Size.TALL);

            Beverage bicerin = factory.CreateDrink(DrinkType.Bicerin, Size.GRANDE);

            Beverage breve = factory.CreateDrink(DrinkType.Breve, Size.VENDI);

            Beverage rafCoffee = factory.CreateDrink(DrinkType.RafCoffee, Size.TALL);

            Beverage meadRaf = factory.CreateDrink(DrinkType.MeadRaf, Size.GRANDE);

            Beverage galao = factory.CreateDrink(DrinkType.Galao, Size.VENDI);

            Beverage caffeAffogato = factory.CreateDrink(DrinkType.CaffeAffogato, Size.TALL);

            Beverage viennaCoffee = factory.CreateDrink(DrinkType.ViennaCoffee, Size.GRANDE);

            Beverage glace = factory.CreateDrink(DrinkType.Glace, Size.VENDI);

            Beverage chocolateMilk = factory.CreateDrink(DrinkType.ChocolateMilk, Size.TALL);

            Beverage demiCreme = factory.CreateDrink(DrinkType.DemiCreme, Size.GRANDE);

            Beverage latteMacchiato = factory.CreateDrink(DrinkType.LatteMacchiato, Size.VENDI);

            Beverage freddo = factory.CreateDrink(DrinkType.Freddo, Size.TALL);

            Beverage frappuccino = factory.CreateDrink(DrinkType.Frappuccino, Size.GRANDE);

            Beverage caramelFrappuccino = factory.CreateDrink(DrinkType.CaramelFrappuccino, Size.VENDI);

            Beverage frappe = factory.CreateDrink(DrinkType.Frappe, Size.TALL);

            Beverage irishCoffee = factory.CreateDrink(DrinkType.IrishCoffee, Size.GRANDE);
        }
    }
}
