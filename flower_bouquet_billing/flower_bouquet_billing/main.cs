using System;
using System.Collections.Generic;
using Billing;

namespace flower_bouquet_billing
{
    public class main
    {
        public static void Main(string[] args)
        {
            Shop shop = new Shop();

            shop.showItems();

            //Flower
            shop.addFlower("hibiscus");
            shop.addFlower("jasmine");

            //Normal bouquet
            Flower flower = new Flower("rose");
            shop.addBouquet(flower);


            //Special bouquet
            Flower jasmine = new Flower("jasmine");
            Flower hibiscus = new Flower("hibiscus");
            Flower rose = new Flower("rose");
            Flower jasmine2 = new Flower("jasmine");
            Flower hibiscus2 = new Flower("hibiscus");
            Flower rose2 = new Flower("rose");
            Flower jasmine3 = new Flower("jasmine");
            Flower hibiscus3 = new Flower("hibiscus");
            Flower rose3 = new Flower("rose");
            Flower jasmine4 = new Flower("jasmine");

            List<Flower> flowers = new List<Flower>();
            flowers.Add(jasmine);
            flowers.Add(jasmine2);
            flowers.Add(jasmine3);
            flowers.Add(hibiscus);
            flowers.Add(hibiscus2);
            flowers.Add(hibiscus3);
            flowers.Add(rose);
            flowers.Add(rose2);
            flowers.Add(rose3);
            flowers.Add(jasmine4);
            shop.addSpecialBouquet(flowers);

            shop.showCart();
        }
    }
}
