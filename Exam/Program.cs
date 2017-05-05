using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizaFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vizani Daxil Et");
            int viza = Convert.ToInt32(Console.ReadLine());
            Console.Write("Finali Daxil Et");
            int final = Convert.ToInt32(Console.ReadLine());
            double netice = Convert.ToDouble(final * 0.6) + Convert.ToDouble(viza * 0.4);

            if (netice <= 46)
            {
                Console.WriteLine(netice + " F Aldiniz");
            }

            else if (netice >= 46 && netice <= 60)
            {
                Console.WriteLine(netice + " D Aldiniz");
            }

            else if (netice >= 61 && netice <= 75)
            {
                Console.WriteLine(netice + " C Aldiniz");
            }
            else if (netice >= 75 && netice <= 90)
            {
                Console.WriteLine(netice + " B Aldiniz");
            }
            else
            {
                Console.WriteLine(netice + " A Aldiniz");
            }
        }
    }
}
