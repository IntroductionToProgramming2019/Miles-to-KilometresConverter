/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Converting Miles to Kilometres
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Please enter the number of miles: ");
            int miles = int.Parse(Console.ReadLine());
            double km = miles * 0.65;
            Console.WriteLine(miles + " miles in kilometres is " + km);
        }
   
    }
}
