using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellDontAsk.Bad
{
    public class ShoppingCart
    {
        public ProductItem[] ProductItems;

        public ShoppingCart(ProductItem[] productItems)
        {
            ProductItems = productItems;
        }
    }

    public abstract class ProductItem
    {
        public bool IsOnSale;

        protected ProductItem(bool isOnSale)
        {
            IsOnSale = isOnSale;
        }
    }

    public class Milk: ProductItem
    {
        public Milk(bool isOnSale): base(isOnSale)
        {

        }
    }
}
