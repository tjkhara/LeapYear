using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            LeapYear();    
        }

        static void LeapYear()
        {
            int year = 0;
            Console.WriteLine("Please enter a year");
            year = Convert.ToInt32(Console.ReadLine());
            
            if(year%100 == 0 && year%400 == 0)
            {
                Console.WriteLine("The year is a leap year");

            } else if (year%100 == 0 && year%400 != 0)
            {
                Console.WriteLine("Not a leap year");
            } else if(year%4 == 0)
            {
                Console.WriteLine("The year you entered is a leap year.");
            }
            
            else 

            {
                Console.WriteLine("The year you entered is not a leap year.");    
            }
        }
    }
}
