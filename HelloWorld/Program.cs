﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if(i==7)
                {
                    Console.WriteLine("Found Seven!");
                    break;
                }
            }




            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue) ;
            }




            Console.ReadLine();

        }
    }
}
