using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2310857_Task4
{
    internal class Vender
    {
        private int tea = 10;
        public int TeaStock
        {
            get { return this.tea; }
        }

        private int sugar = 10;
        public int SugarStock
        {
            get { return this.sugar; }
        }

        private int milk = 10;
        public int MilkStock
        {
            get { return this.milk; }
        }

        private int coffee = 10;
        public int CoffeeStock
        {
            get { return this.coffee; }
        }

        public bool dispenseTea(bool milk, bool sugar) // dispense tea
        {
            if ((milk && this.milk <= 0) || (sugar && this.sugar <= 0) || this.tea <= 0) // if any no stock, return no dispense
            {
                return false;
            }
            else
            {
                this.tea--;
                if (milk) { this.milk--; }
                if (sugar) { this.sugar--; }
                return true;
            }
        }

        public bool dispenseCoffee(bool milk, bool sugar) // dispense coffee
        {
            if ((milk && this.milk <= 0) || (sugar && this.sugar <= 0) || this.coffee <= 0) // if any no stock, return no dispense
            {
                return false;
            }
            else
            {
                this.coffee--;
                if (milk) { this.milk--; }
                if (sugar) { this.sugar--; }
                return true;
            }
        }
    }
}
