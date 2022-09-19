using System;
using System.Collections.Generic;

namespace Flower_bouquet_shop
{
    public enum FlowerType
    {
        Jasmine = 1,
        rose,
        sunflower
    }

    public enum Color
    {
        white = 1,
        red,
        yellow
    }

    public enum BouquetType
    {
        normal=100,
        mixed=200,
        fancy=300
    }

    public enum FlowerPrice
    {
        jasmine = 10,
        rose = 20,
        sunflower = 30
    }

    class Flower
    {
        FlowerType name;
        Color color;

        public Flower(FlowerType name,Color color)
        {
            this.name = name;
            this.color = color;
        }

        public FlowerType GetName() { return this.name; }

        public Color GetColour() { return this.color; }

    };

    class Bouquet
    {
        BouquetType name;
        List<Flower> bouquet;
        int currentCapacity;
        public const int MAXCAPACITY = 12;

       
        public Bouquet(BouquetType name,List<Flower> FlowerType)
        {
                this.name = name;
                this.bouquet = FlowerType;
                this.currentCapacity = FlowerType.Count;
        }

        public void AddFlower(Flower flower)
        {
            if(this.currentCapacity < MAXCAPACITY)
            {
                this.bouquet.Add(flower);
                currentCapacity++;
            }
        }

        public BouquetType GetName() { return this.name; }

        public int GetCurrentCapacity() { return this.currentCapacity; }

    };

    class Shop
    {
        public List<Flower> flowerCart;
        public List<Bouquet> bouquetCart;
        public int totalCost;

        public Shop()
        {
            this.flowerCart = new List<Flower>();
            this.bouquetCart = new List<Bouquet>();
        }

        public void FlowerTypeection()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("FlowerType SECTION:");
            Console.WriteLine(string.Format("1 : {0} - PRICE: {1}", FlowerType.Jasmine.ToString(), (int)FlowerPrice.jasmine));
            Console.WriteLine(string.Format("2 : {0} - PRICE: {1}", FlowerType.rose.ToString(), (int)FlowerPrice.rose));
            Console.WriteLine(string.Format("3 : {0} - PRICE: {1}", FlowerType.sunflower.ToString(), (int)FlowerPrice.sunflower));
            Console.WriteLine("--------------------------");
            Console.ResetColor();
        }

        public void BouquetTypeection()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("BouquetType SECTION:");
            Console.WriteLine(string.Format("4: NORMAL- PRICE: {0}", (int)FlowerPrice.jasmine * 12 + (int)BouquetType.normal));
            Console.WriteLine(string.Format("5: MIXED - PRICE: {0}", (int)FlowerPrice.jasmine * 4 + (int)FlowerPrice.rose * 8 + (int)BouquetType.mixed));
            Console.WriteLine(string.Format("6: FANCY - BOUQUET PRICE: {0} + FlowerType PRICE", (int)BouquetType.fancy));
            Console.WriteLine("--------------------------");
            Console.ResetColor();
        }

        public void ShowAllItems()
        {
            FlowerTypeection();
            BouquetTypeection();
        }

        public void Buy()
        {
            int choice;
            do
            {
                ShowAllItems();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("PRESS 7 TO QUIT!");
                Console.ResetColor();
                Console.WriteLine("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Flower jasmine = new Flower(FlowerType.Jasmine, (Color)FlowerType.Jasmine);
                            flowerCart.Add(jasmine);
                            totalCost += (int)FlowerPrice.jasmine;
                            break;
                        }
                    case 2:
                        {
                            Flower rose = new Flower(FlowerType.rose, (Color)FlowerType.rose);
                            flowerCart.Add(rose);
                            totalCost += (int)FlowerPrice.rose;
                            break;
                        }
                    case 3:
                        {
                            Flower sunFlower = new Flower(FlowerType.sunflower, (Color)FlowerType.sunflower);
                            flowerCart.Add(sunFlower);
                            totalCost += (int)FlowerPrice.sunflower;
                            break;
                        }
                    case 4:
                        {
                            List<Flower> normal = new List<Flower>(Bouquet.MAXCAPACITY);
                            for (int i = 0; i < Bouquet.MAXCAPACITY; i++)
                            {
                                Flower jasmine = new Flower(FlowerType.Jasmine, (Color)FlowerType.Jasmine);
                                normal.Add(jasmine);
                            }
                            Bouquet normalBouquet = new Bouquet(BouquetType.normal, normal);
                            bouquetCart.Add(normalBouquet);
                            totalCost += (int)FlowerPrice.jasmine * 12 + (int)BouquetType.normal;
                            break;
                        }
                    case 5:
                        {
                            List<Flower> mixed = new List<Flower>(Bouquet.MAXCAPACITY);
                            for (int i = 0; i < Bouquet.MAXCAPACITY; i++)
                            {
                                if (i < 4)
                                {
                                    Flower jasmine = new Flower(FlowerType.Jasmine, (Color)FlowerType.rose);
                                    mixed.Add(jasmine);
                                }
                                else
                                {
                                    Flower rose = new Flower(FlowerType.rose, (Color)FlowerType.rose);
                                    mixed.Add(rose);
                                }
                            }
                            Bouquet mixedBouquet = new Bouquet(BouquetType.normal, mixed);
                            bouquetCart.Add(mixedBouquet);
                            totalCost += (int)FlowerPrice.jasmine * 12 + (int)BouquetType.normal;
                            break;
                        }
                    case 6:
                        {
                            List<Flower> fancy = new List<Flower>(Bouquet.MAXCAPACITY);
                            for(int i=0; i < Bouquet.MAXCAPACITY; i++)
                            {
                                FlowerTypeection();
                                Console.WriteLine("Choose flower");
                                int ch = int.Parse(Console.ReadLine());
                                if(ch == 1)
                                {
                                    Flower jasmine = new Flower(FlowerType.Jasmine, (Color)FlowerType.Jasmine);
                                    fancy.Add(jasmine);
                                    totalCost += (int)FlowerPrice.jasmine;
                                }else if(ch == 2)
                                {
                                    Flower rose = new Flower(FlowerType.rose, (Color)FlowerType.rose);
                                    fancy.Add(rose);
                                    totalCost += (int)FlowerPrice.rose;
                                }else if(ch == 3)
                                {
                                    Flower sunFlower = new Flower(FlowerType.sunflower, (Color)FlowerType.sunflower);
                                    fancy.Add(sunFlower);
                                    totalCost += (int)FlowerPrice.sunflower;
                                }
                            }
                            Bouquet fancyBouquet = new Bouquet(BouquetType.fancy, fancy);
                            bouquetCart.Add(fancyBouquet);
                            totalCost += (int)BouquetType.fancy;
                            break;
                        }
                }
            } while (choice != 7);
        }


        public void ShowCart()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("     BILL DETAILS       ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("----------------------");
            Console.WriteLine("FlowerType BOUGHT:");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            foreach(Flower flower in flowerCart)
            {
                FlowerPrice price = (FlowerPrice)flower.GetName();
                Console.WriteLine(string.Format("{0} - {1}",flower.GetName().ToString().ToUpper(),);
            }

            Console.ResetColor();
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("BouquetType BOUGHT:");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            foreach(Bouquet bouquet in bouquetCart)
            {
                Console.WriteLine(bouquet.GetName().ToString().ToUpper());
            }
            Console.ResetColor();
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("TOTAL: " + this.totalCost);
        }
    };
}
