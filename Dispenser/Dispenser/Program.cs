using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidDispenserV1
{
    public enum DispenserState
    {
        Empty = 0,
        Critical,
        Available,

    }
    public class Dispenser
    {
        ConsoleColor basecolor = Console.ForegroundColor;
        public const int MAXCAPACITY = 100;
        public const int DISPENSEQUANTITY = 5;
        DispenserState _state;
        int _currentCapacity;

        public DispenserState State
        {
            get { return _state; }
            set { _state = value; }
        }

        public int CurrentCapacity
        {
            get
            {
                return _currentCapacity;
            }
            set
            {
                if (value > MAXCAPACITY)
                {
                    PrintMessage("Cannot Proceed with Operation: Exceeds Max Capacity.", ConsoleColor.DarkRed);
                }
                else
                {
                    _currentCapacity = value;
                }
            }
        }

        public Dispenser()
        {
            State = DispenserState.Empty;
            _currentCapacity = 0;
        }

        public override string ToString()
        {

            return string.Format("Current State: {0}, Max Capacity: {1} ml, Current Capacity: {2} ml.", this.State, Dispenser.MAXCAPACITY, this.CurrentCapacity);
        }


        public void FillDispenser(int FillVolume)
        {
            if ((State == DispenserState.Empty || State == DispenserState.Critical) && FillVolume > 0 && (FillVolume + _currentCapacity) <= MAXCAPACITY)
            {
                CurrentCapacity += FillVolume;
                SetDispenserState();
                PrintMessage(string.Format("Filling Dispenser with {0} ml of Liquid.", FillVolume), ConsoleColor.DarkYellow);
            }
            else
            {
                PrintMessage("Cannot Proceed with Fill Operation. Invalid Input Quantity or Dispenser is Full.", ConsoleColor.DarkRed);
            }
        }

        public void DispenseLiquid()
        {
            if (State == DispenserState.Available || State == DispenserState.Critical)
            {
                int dispenseQuantity = Math.Min(DISPENSEQUANTITY, CurrentCapacity);
                CurrentCapacity -= dispenseQuantity;
                PrintMessage(string.Format("Dispensing {0} ml of Liquid.", dispenseQuantity), ConsoleColor.Green);
                SetDispenserState();
            }
            else
            {
                PrintMessage("Cannot Dispense Liquid. Dispenser is Empty.", ConsoleColor.DarkRed);
            }
        }

        private void SetDispenserState()
        {
            if (CurrentCapacity > 25)
            {
                State = DispenserState.Available;
            }
            else if (CurrentCapacity <= 25 && CurrentCapacity > 0)
            {
                State = DispenserState.Critical;
                PrintMessage("!!!Dispenser Capacity is Critical. Fill Dispenser with Liquid!!!", ConsoleColor.Magenta);
            }
            else
            {
                State = DispenserState.Empty;
                PrintMessage("!!!Dispenser is Empty. Fill Dispenser with Liquid!!!", ConsoleColor.Red);
            }
        }

        public void DisplayDispenserState()
        {
            if (State == DispenserState.Empty)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (State == DispenserState.Critical)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine(" --------------------");
            Console.Write("|");

            for (int i = 0; i < MAXCAPACITY / DISPENSEQUANTITY; i++)
            {
                if (i < CurrentCapacity / DISPENSEQUANTITY)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("|");

            Console.WriteLine(" --------------------");

            Console.ForegroundColor = basecolor;
        }

        public void PrintMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = basecolor;
        }
    }

}
    
