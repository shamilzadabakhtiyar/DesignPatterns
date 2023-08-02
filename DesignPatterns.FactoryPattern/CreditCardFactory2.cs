using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.FactoryPattern;

namespace DesignPatterns.FactoryPattern
{
    public abstract class CreditCardFactory2
    {
        protected abstract ICreditCard MakeProduct();
        public ICreditCard CreateProduct()
        {
            ICreditCard creditCard = this.MakeProduct();
            return creditCard;
        }
    }
}
