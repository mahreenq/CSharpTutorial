using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Mahreen's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
                 message = "You win a trip around the world!";
            else if (userValue == "2") 
                message = "You win a litter of puppies!";
            else if (userValue == "3")
                message = "You win a MacBook!";
            else 
                message = "No prize for you :(";

            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Mahreen's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
           
            string message = (userValue == "1") ? "a Vacation" : "Oatmeal .. yum";

            Console.WriteLine(" You entered: {0}, You win {1}.", userValue, message);

            Console.ReadLine();



        }
    }
}
