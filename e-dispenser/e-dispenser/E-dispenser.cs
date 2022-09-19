using System;

namespace E_dispenser
{
    class Refill
    {
        int totalQuantity;
        int availableQuantity;

        public Refill()
        {
            this.totalQuantity = 100;
            this.availableQuantity = totalQuantity;
        }

        public int getTotalQuantity()
        {
            return this.totalQuantity;
        }

        public int getAvailableQuantity()
        {
            return this.availableQuantity;
        }

        public bool isEmpty()
        {
            return this.availableQuantity == 0;
        }

        public bool hasLowQuantity()
        {
            return this.availableQuantity <= 10;
        }

        public void getGel(int ml)
        {
            this.availableQuantity -= ml;
        }
    };


    class Dispenser
    {
        Refill refill;

        public Dispenser(Refill refill)
        {
            this.refill = refill;
        }

        public void use()
        {
            if(refill.isEmpty())
            {
                Console.WriteLine("Refill is empty");
                return;
            }

            if(refill.hasLowQuantity())
            {
                Console.WriteLine("Warning! Refill quantity is low");
                refill.getGel(2);
                Console.WriteLine("2ml received due to low quantity");
            }else
            {
                refill.getGel(10);
                Console.WriteLine("Sucess 10ml received");
            }
        }

        public int getAvailableGelCapacity()
        {
            return this.refill.getAvailableQuantity();
        }

    };

}
