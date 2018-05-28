using System; //NAMESPACE is SYSTEM
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Full name of the class below
            //System.Console.WriteLine("Hello World!");
            //Console.ReadLine();

            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
           
            File.WriteAllText(@"***PATH TO PROJECT**/HelloWorld/WriteText.txt", text);
        }
    }
}
