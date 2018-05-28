using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 2000;
            myCar.Colour = "Black";

            Console.WriteLine("{0} {1} {2} {3}", 
                              myCar.Make, 
                              myCar.Model, 
                              myCar.Year, 
                              myCar.Colour);


            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            Console.ReadLine();
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;

            return carValue;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;
        }
    }
}
