using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
           int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            // numbers[5] = 42; will throw error as we defined length of 5 for the array

            Console.WriteLine("Get the value of array 'numbers' at index 1: " + numbers[1]);
            Console.WriteLine("Length of array 'numbers': " + numbers.Length);
            Console.ReadLine();


            //ARRAY OF INTEGERS
            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            //ARRAY OF STRINGS
            string[] names = new string[] { "MQ", "JD", "ES", "RH" };
          
            //DISPLAY NAMES IN ARRAY USING FOR
            Console.WriteLine("Array using for");
             for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
           Console.ReadLine();

            //DISPLAY NAMES IN ARRAY USING FOREACH
            Console.WriteLine("Array using foreach");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();


            //SPLITTING STRING INTO INDIVIDUAL CHARACTERS, REVERSING, AND DISPLAYING

            string myName = "My first name is Mahreen, " +
                "My last name is Qureshi";

            char[] charArray = myName.ToCharArray();
            Array.Reverse(charArray);

            foreach (char myNamechar in charArray)
            {
                Console.Write(myNamechar);
            }
            Console.ReadLine();

        }
    }
}
