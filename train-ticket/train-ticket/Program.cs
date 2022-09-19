using System;
using System.Collections.Generic;

namespace train_ticket
{
    class Seat
    {
        int id;
        int no;
    };

    class Compartment
    {
        string name;
        int noOfSeats;
        Seat[] seats;

        public Compartment(string name, int noOfSeats) {
            this.name = name;
            this.noOfSeats = noOfSeats;

            this.seats = new Seat[this.noOfSeats];
        }

        public string getName()
        {
            return this.name;
        }

        public int capacity()
        {
            return this.noOfSeats;
        }

    };

    class Train
    {
        string name;
        int number;
        Dictionary<string,Compartment> compartments;

        public Train(string name,int number)
        {
            this.name = name;
            this.number = number;

            this.compartments = new Dictionary<string, Compartment>();
        }

        public void addCompartment(String name, Compartment compartment)
        {
            this.compartments.Add(name, compartment);
        }

        public int getTrainNumber()
        {
            return this.number;
        }

        public string getTrainName()
        {
            return this.name;
        }
    };



}
