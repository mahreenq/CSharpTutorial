using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           // Car myCar = new Car();

            Car.MyMethod();

            /*
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 2000;
            myCar.Colour = "Black";


            Car myThirdCar = new Car("Ford", "Escape", 2005, "white");

            Console.WriteLine("{0} {1} {2} {3}",
                              myOtherCar.Make,
                              myOtherCar.Model,
                              myOtherCar.Year,
                              myOtherCar.Colour);

            myOtherCar.Model = "98";


            
             Console.WriteLine("{0} {1} {2} {3}",
                  myCar.Make,
                  myCar.Model,
                  myCar.Year,
                  myCar.Colour);


            /*Console.WriteLine("{0} {1} {2} {3}",
                  myOtherCar.Make,
                  myOtherCar.Model,
                  myOtherCar.Year,
                  myOtherCar.Colour);
            
            */

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        /*
        public Car()
        {
            this.Make = "Nissan";
        }


        //OVERLOADED CONSTRUCTOR
        public Car (string make, string model, int year, string colour)
        {
            Make = make;
            Model = Model;
            Year = year;
            Colour = colour;
        }
        */

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
        }


    }
}
