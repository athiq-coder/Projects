using System;
using System.Collections.Generic;
using System.Linq;

namespace Billing
{
    class Flower
    {
        string name;

        public Flower(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

    };

     class Bouquet
    {
        List<Flower> flowers;
        const int capacity = 10;

        public Bouquet() { }

        public Bouquet(List<Flower> flowers)
        {
            if (capacity == flowers.Count)
            {
                this.flowers = flowers;
            }
        }

         public int getCapacity() 
        {
            return capacity;
        }
       
    };


    class Price
    {
       Dictionary<string, int> priceList;
       const int bouquetCover = 100;
       const int design = 300;

        public Price()
        {
            priceList = new Dictionary<string, int>();

            priceList.Add("jasmine", 10);
            priceList.Add("hibiscus", 20);
            priceList.Add("rose", 30);
            
        }

        public int getPrice(string name)
        {
            return this.priceList[name];
        }

        public int getPrice(List<Flower>flowers)
        {
            int cost = bouquetCover + design;
            foreach(Flower flower in flowers)
            {
                cost += this.priceList[flower.getName()];
            }
            return cost;
        }

        public void showAllItems()
        {
            int i = 1;

            Console.WriteLine("Items available:");
            foreach (KeyValuePair<string,int> item in priceList)
            {
                Console.WriteLine(i + "." + " " + item.Key + " " + item.Value+"rs");
                i++;
            }
            Console.WriteLine();
        }

        public int getDesignPrice()
        {
            return design;
        }

        public int getBouquetCoverPrice()
        {
            return bouquetCover;
        }

    };

    class Menu
    {
        Price priceList;

        public Menu()
        {
            priceList = new Price();
        }

        public int getBouquetPrice(Bouquet bouquet)
        {
            return this.priceList.getPrice(bouquet.getName());
        }

        public int getFlowerPrice(Flower flower)
        {
            return this.priceList.getPrice(flower.getName());
        }

        public int getFlowerPrice(string name)
        {
            return this.priceList.getPrice(name);
        }

        public int getSpecialBouquetPrice(List<Flower>flowers)
        {
            return this.priceList.getPrice(flowers);
        }

        public void showAllItems()
        {
            priceList.showAllItems();
        }
    };

    class Order
    {
        Flower flower;
        Bouquet bouquet;
        List<Flower> flowers;

        public Order(string name)
        {
            this.flower = new Flower(name);
        }


        public Order(Flower flower)
        {
            flowers = new List<Flower>();

            for (int i = 0; i < flowers.Capacity; i++)
            {
                this.flowers.Add(flower);
            }

            this.bouquet = new Bouquet(this.flowers);
        }

        public Order(List<Flower>flowers)
        {
            this.bouquet = new Bouquet(flowers);
        }

        public Flower getFlower()
        {
            return this.flower;
        }

        public Bouquet getBouquet()
        {
            return this.bouquet;
        }

    };


    class Shop
    {
        Menu menu;
        Dictionary<Flower, int> flowerCart;
        Dictionary<Bouquet, int> bouquetCart;
        Dictionary<Bouquet, int> specialBouquetCart;
        int totalAmount;

        public Shop()
        {
            menu = new Menu();
            this.flowerCart = new Dictionary<Flower, int>();
            this.bouquetCart = new Dictionary<Bouquet, int>();
            this.specialBouquetCart = new Dictionary<Bouquet, int>();
            this.totalAmount = 0;
        }

        public void showItems()
        {
            menu.showAllItems();
        }

        public void addFlower(string name)
        {
            Order flower = new Order(name);
            flowerCart.Add(flower.getFlower(), menu.getFlowerPrice(name));
        }

        public void addBouquet(Flower flower)
        {
            Order bouquet = new Order(flower);
            Bouquet bouq = bouquet.getBouquet();
            bouquetCart.Add(bouquet.getBouquet(), menu.getBouquetPrice(bouq));
        }

        public void addSpecialBouquet(List<Flower> flowers)
        {
            Order specialBouquet = new Order(flowers);
            specialBouquetCart.Add(specialBouquet.getBouquet(), menu.getSpecialBouquetPrice(flowers));
        }

        public void showCart()
        {
            Console.WriteLine("Total Flowers bought");
            foreach(KeyValuePair<Flower,int> items in flowerCart)
            {
                Console.WriteLine(items.Key.getName() + " "+ items.Value);
            }
            Console.WriteLine();

            Console.WriteLine("Normal bouquets bought");
            foreach (KeyValuePair<Bouquet, int> items in bouquetCart)
            {
                Console.WriteLine(items.Key.getName());
                Console.WriteLine("Price "+items.Value + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Special bouquets bought");
            foreach (KeyValuePair<Bouquet, int> items in specialBouquetCart)
            {
                Console.WriteLine(items.Key);
                Console.WriteLine("Price " + items.Value + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            showTotalBill();
        }

        public void removeItem()
        {

        }

        public void showTotalBill()
        { 
            foreach(KeyValuePair<Flower,int> items in flowerCart)
            {
                this.totalAmount += items.Value;
            }

            foreach (KeyValuePair<Bouquet, int> items in bouquetCart)
            {
                this.totalAmount += items.Value;
            }

            foreach (KeyValuePair<Bouquet, int> items in specialBouquetCart)
            {
                this.totalAmount += items.Value;
            }
            Console.WriteLine("Total amount is: "+this.totalAmount);
        }
    };


}
