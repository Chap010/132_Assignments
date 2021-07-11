using System;

namespace Week2Assignment_
{
    class Program
    {
        static void Main(string[] args)
        {
            PastryBox pastries = new PastryBox();
            pastries.items = 10;
            pastries.chocolateChipCookies = 4;
            pastries.brownies = 3;
            pastries.oatmealCookies = 3;
            pastries.brand = "Pancho's Bakery";

            Console.WriteLine($"Welcome To {pastries.brand}");
            Console.ReadLine();


        }

    }
    class PastryBox
    {
        public int items;
        public int chocolateChipCookies;
        public int brownies;
        public int oatmealCookies;
        public string brand;

    }
}
