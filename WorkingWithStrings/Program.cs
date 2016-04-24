using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need\n a new line?";
            //string myString = "Go to your C:\\ drive.";
            //string myString = @"Go to your C:\ drive";

            //string myString = string.Format("{0} = {0} - {1}", "first", "second");
            //string myString = string.Format("Currency: {0:C}", 123.45);
            //string myString = string.Format("Number: {0:N}", 1234567890);
            //string myString = string.Format("Percentage: {0:P}", .123);
            //string myString = 
            //    string.Format("Phone: {0:(###) ###-####}", 773588292700);
            //
            string myString = "  That summer we took threes across the board  ";

            myString = myString.Substring(2);

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
