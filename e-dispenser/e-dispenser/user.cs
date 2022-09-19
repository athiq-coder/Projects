using System;
using E_dispenser;

namespace User
{
    public class User
    {
        public static void Main(string[] args)
        {
            Refill refill = new Refill();

            Dispenser dispenser = new Dispenser(refill);

            dispenser.use();
            dispenser.use();
            dispenser.use();
            dispenser.use();
            dispenser.use();
            dispenser.use();
            dispenser.use();
            dispenser.use(); 
            dispenser.use();
            dispenser.use();
            dispenser.use();
            dispenser.use();
            dispenser.use();
            dispenser.use();
            dispenser.use();
            dispenser.use();
        }
    }
}
