using System;
using System.Linq;

namespace TellDontAsk
{
    class Program
    {
        static void Main(string[] args)
        {
            AskUser();
            TellUser();

            ToMuchKnowledgeOfAProduct();
            JustEnoughKnowledgeOfAProduct();

            Console.ReadKey();
        }

        private static void JustEnoughKnowledgeOfAProduct()
        {
            var cart = new Good.ShoppingCart(new Good.ProductItems(new Good.ProductItem[] { new Good.Milk(true) }));

            var thereAreItemsOnSale = cart.HasItemsOnSale();

            var notString = thereAreItemsOnSale ? "" : "not ";
            Console.WriteLine($"There are {notString}items on sale");
        }

        private static void ToMuchKnowledgeOfAProduct()
        {
            var cart = new Bad.ShoppingCart(new Bad.ProductItem[] { new Bad.Milk(true) });

            var thereAreItemsOnSale = cart.ProductItems.Any(item => item.IsOnSale);

            var notString = thereAreItemsOnSale ? "" : "not ";
            Console.WriteLine($"There are {notString}items on sale");
        }

        private static void TellUser()
        {
            var user = new Good.User();

            user.PerformAnAdminOperation();
        }

        private static void AskUser()
        {
            var user = new Bad.User();

            if (user.IsAdmin)
            {
                user.PerformAdminOperation();
            }
        }
    }
}
