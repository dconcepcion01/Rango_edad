using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rango_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            // este programa evalua la edad de una persona 

            int edad;

            Console.WriteLine("Este programa evalua tu edad para saber tu rango de juventud");
            Console.ReadLine();

            Console.WriteLine("Digite una edad");
            edad = int.Parse(Console.ReadLine());

            if (edad <=10 )
            {
                Console.WriteLine("Es un menor");
            }
           else if  (edad > 60 )
            {
                Console.WriteLine("Es un adulto mayor");
            }

            Console.ReadKey();
        }
    }
}
