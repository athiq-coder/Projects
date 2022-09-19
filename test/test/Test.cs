using System;
using Home;

namespace Test
{
    public class Test
    {
        public static void Main(String[] args)
        {
            Refill refill = new Refill(Ink.blue);

            Container container = new Container(refill);

            Cap topCap = new Cap();
            Cap bottomCap = new Cap();

            Pen pen = new Pen(container, topCap, bottomCap);
            pen.write(Intensity.dark, "In Indian domestic cricket he played for Bihar and Jharkhand Cricket team. He is the captain of Chennai Super Kings (CSK) in the Indian Premier League. He captained the side to championships in the 2010, 2011, 2018 and 2021 editions of IPL league. Also under his captaincy Chennai Super Kings (CSK) Won Champions League T20 two times, in 2010 and 2014.Dhoni made his ODI debut on 23 December 2004, against Bangladesh in Chittagong,[14] and played his first Test a year later against Sri Lanka.[15] He played his first T20I also a year later against South Africa.[16] In 2007, he took over the ODI captaincy from Rahul Dravid and he also selected as T20I captain of India in this year.[17] In 2008, he was selected as Test Captain.");
        }
    }
}
