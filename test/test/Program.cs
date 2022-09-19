using System;
using System.Collections.Generic;

namespace Home
{

    class Refill
    {
        Ink color;

        // Ink filler capacity in milli
        int capacity;

        public Refill(Ink color)
        {
            this.color = color;
            this.capacity = 100;
        }

        public int getCapacity()
        {
            return this.capacity;
        }

        bool isEmpty()
        {
            return this.capacity == 0;
        }

        bool isFull()
        {
            return this.capacity == 100;
        }

        int totalWordsWritable(Intensity intensity)
        {
            if (this.isEmpty())
                return 0;

            if (intensity == Intensity.dark)
            {
                return this.capacity / 3;
            }

            else if (intensity == Intensity.medium)
            {
                return this.capacity / 2;
            }

            return this.capacity;
        }

        public void write(Intensity intensity, String text)
        {
            String[] words = text.Split(" ");

            int writableWords = this.totalWordsWritable(intensity);

            int capacityRequired = words.Length * (int)intensity;

            int currentCapcity = this.capacity - capacityRequired;

            if (currentCapcity > 0)
            {
                Console.WriteLine(text);
                this.capacity = currentCapcity;

            } else if ( writableWords > 0)
            {
                for (int i = 0; i < writableWords; i++)
                {
                    Console.WriteLine(words[i]);
                    this.capacity = this.capacity - (int)intensity;
                }

                Console.WriteLine("Refill ink empty");
            }
        }
    };

    class Container
    {
        public Refill refill;
       
        public Container() {}

        public Container(Refill refill)
        {
            this.refill = refill;
        }

    };

    class Pen
    {
        Container container;
        Cap topCloser;
        Cap bottomCloser;

        public Pen(Container container, Cap topCloser, Cap bottomCloser)
        {
            this.container = container;
            this.topCloser = topCloser;
            this.bottomCloser = bottomCloser;
        }

        public void write(Intensity intensity, String text)
        {
            if (this.isOpen(topCloser) || this.isOpen(bottomCloser))
            {
                Console.WriteLine("Close Cap");
                return;
            }

            this.container.refill.write(intensity, text);
        }

        public bool isOpen(Cap cap)
        {
            return cap.isOpen();
        }

        public void open(Cap cap)
        {
            cap.open();
        }


        public void close(Cap cap)
        {
            cap.close();
        }

        public int getRefillCapacity()
        {
            return this.container.refill.getCapacity();
        }

    };

    public enum Ink
    {
        black = 1,
        blue = 2
    }

    public enum Intensity
    {
        dark = 3,
        medium = 2,
        low = 1
    }

    class Cap
    {
        bool state;

        public bool isOpen()
        {
            return this.state;
        }

        public void open()
        {
            this.state = true;
        }

        public void close()
        {
            this.state = false;
        }
    }
}