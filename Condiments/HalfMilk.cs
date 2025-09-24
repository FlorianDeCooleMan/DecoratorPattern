using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class HalfMilk : CondimentDecorator
    {
        public HalfMilk(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double condimentCost = 0.20;

            switch (Size)
            {
                case Size.GRANDE: condimentCost = 0.25; break;
                case Size.VENDI: condimentCost = 0.30; break;
            }

            return baseBeverage.cost() + condimentCost;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", HalfMilk";
        }
    }
}
