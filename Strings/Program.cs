using System;

namespace Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //   \ required to create characters otherwise difficult to reproduce
            // in string, \ is an escape character to produce special characters

            // string myString = "Go to your c:\\ drive"; // \ for folder name

            //string myString = "My\" so called\" life"; // Double Quotes with \

            //string myString = "What if I need \n a new line?";

            //string myString = string.Format("{0}!", "Bonzai"); // Substitute 2nd Perameter

            //string myString = string.Format("Make: {0} (Model: {1})", "BMW", "760li");

            //string myString = string.Format("{0:C}", 123.45); // Format to currency

            //string myString = string.Format("{0:N}", 123456789); // Format with , and .

            //string myString = string.Format("{0:P}", .123); // Format to %

            string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890);
            // begins on the right hand side, moves to the left, extra value put at beginning

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
