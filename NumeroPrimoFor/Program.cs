using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int ContadorPrimo = 0;
            Console.Write("Ingrese un Número por favor: ");
            Num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= Num; i++)
            {
                if(Num % i == 0)
                {
                    ContadorPrimo = ContadorPrimo + 1;
                }
            }
            if(ContadorPrimo == 2)
            {
                Console.WriteLine("El Número {0} es primo", Num);
            }
            else
            {
                Console.WriteLine("El Número {0} no es primo", Num);
            }
            Console.Read();
        }
    }
}
