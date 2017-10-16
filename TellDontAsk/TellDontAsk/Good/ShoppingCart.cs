using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellDontAsk.Good
{
    public class ShoppingCart
    {
        public ProductItems ProductItems;

        public ShoppingCart(ProductItems productItems)
        {
            ProductItems = productItems;
        }

        public bool HasItemsOnSale()
        {
            return ProductItems.Any(item => item.IsOnSale);
        }
    }

    public class ProductItems : IEnumerable<ProductItem>
    {
        private IEnumerable<ProductItem> _productItems;

        public ProductItems(IEnumerable<ProductItem> productItems)
        {
            _productItems = productItems;
        }

        public bool HasItemsOnSale()
        {
            return this._productItems.Any(item => item.IsOnSale);
        }

        public IEnumerator<ProductItem> GetEnumerator()
        {
            return _productItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
