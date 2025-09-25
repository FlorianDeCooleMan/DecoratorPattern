using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    public enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    public abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        public Size size;

        protected string description = "Unknown";
        protected Beverage baseBeverage = null;
        

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
