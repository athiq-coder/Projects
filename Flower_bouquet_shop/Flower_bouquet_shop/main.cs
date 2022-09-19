using System;
using Flower_bouquet_shop;

namespace main
{
    public class main
    {
        public static void Main(string[] args)
        {
            Shop shop = new Shop();

            shop.Buy();

            shop.ShowCart();

        }
    }
}
