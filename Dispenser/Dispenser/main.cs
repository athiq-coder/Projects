using System;
using LiquidDispenserV1;

namespace main
{
    public class main
    {
        public static void Main()
        {
            Dispenser dispenser = new Dispenser();
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();

            dispenser.FillDispenser(35);
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();

            dispenser.DispenseLiquid();
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();

            dispenser.DispenseLiquid();
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();

            dispenser.DispenseLiquid();
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();

            dispenser.DispenseLiquid();
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();

            dispenser.DispenseLiquid();
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();

            dispenser.DispenseLiquid();
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();

            dispenser.DispenseLiquid();
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();

            dispenser.DispenseLiquid();
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();

            dispenser.FillDispenser(105);
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();

            dispenser.FillDispenser(20);
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();

            dispenser.FillDispenser(100);
            Console.WriteLine(dispenser);
            dispenser.DisplayDispenserState();
        }
    }
}
