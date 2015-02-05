using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1202_W13_LT1B_MessamTyrell
{
    class Tyrell_Circle
    {
        /* Studwnt Id:100822745
         * Name: Tyrell Messam
         * Course Code: COMP 1202
         */
        static void Main(string[] args)
        {
            string inputValue;
            int radius;
            double area;
            //user input
            Console.WriteLine("Enter an interger for the radius ");
            inputValue= Console.ReadLine( );
            radius=int.Parse(inputValue);
            area = (double)radius;

          Console.WriteLine("The radius of the cirlce is " + radius);                
          Console.WriteLine("The radius squared is " + Tyrell_Square(radius) );
          Console.WriteLine("The area of the circle is " + "{0:##.00}", Tyrell_Area(area));
          Console.Read();
        }

        public static int Tyrell_Square (int radius)
        {
            
            return radius*radius ;
        }

        public static double Tyrell_Area (double area)
        {
               
               return 3.14* area*area;
        }

    
    
    
    
    
    
    }
}
