using System;
using System.Collections.Generic;
using System.Text;
namespace ErstesCSharpPrgrV3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Berechnung eines Kugelvolumens
            double r, v;     
            Console.WriteLine("Berechnung eines Kugelvolumens:\n");
            Console.Write("Radius r= ");
            r = Convert.ToDouble(Console.ReadLine());
            v = ((double) 4/3) * Math.PI * (r * r * r);  // Integerdivision !!! -> Parse to double!!!
            Console.WriteLine("Das Kugelvolumen  v= (4/3)*{0}*({1}^3)= {2}", Math.PI, r, v);
            Console.ReadKey();
        }
    }
}
