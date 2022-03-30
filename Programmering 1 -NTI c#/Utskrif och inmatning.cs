using System;

namespace Minapp2
{
    class Program
    {

        static void Main(string[] args)
        {

            string fename = Console.ReadLine();   // read name from the console and put in variable from typstring.

            Console.WriteLine("Welcome : " + fename); // use this method to print the welcome message with the person name.
            Console.WriteLine("How old are you ?");// use this method to ask about thier age.
            String v = Console.ReadLine();// take in values from user
            int year = Convert.ToInt32(v); //o convert value from string to int.

            Console.WriteLine( year * 365); //print out amount of days.


            
        }
    }
}
