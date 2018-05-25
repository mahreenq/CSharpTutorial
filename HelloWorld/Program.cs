using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //ALLOWS YOU TO USE QUOTATIONS MARKS IN STRING
            //string myString = "My \"so-called\" life";

            //LINE BREAK
            //string myString = "What if I need a \nnew line"; 

            //ALLOWS YOU YO USE BACKSLASH CHARACTERS
            //string myString = "Go to you c:\\ drive";
            //string myString = @"Go to you c:\ drive";

            //string myString = String.Format("{0} = {1}", "First", "Second");

            //FORMATS TO CURRENCY
            //string myString = string.Format("{0:C}", 123.45);

            //FORMATS NUMBER SO IT IS EASY TO READ
            //string myString = string.Format("{0:N}", 1234567890);

            //FORMATS TO PERCENTAGE
            //string myString = string.Format("Percentage: {0:P}", 0.123);

            //CUSTOM FORMAT
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);

            string myString = " Summer is here yaaaaaayyy  ";
            //StART AT 6TH CHAR, END AT 10TH CHAR
            //myString = myString.Substring(6, 10);
            //TO UPPERCASE
            //myString = myString.ToUpper();
            //REPLACE CHARACTERS
            //myString = myString.Replace(" ", "--");
            //REMOVES CHARACTERS FROM STRING
            //myString = myString.Remove(6, 10);

            myString = String.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length);

            /*  string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */
            /*  
             StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
             {
                 myString.Append("--");
                 myString.Append(i);
             }
            */



            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
