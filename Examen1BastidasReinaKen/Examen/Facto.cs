using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facto
{
    class Factori
    {
        public static long factorial(int num)
        {
            long fac = 1;
            if (num == 0)
                return 1;  //retorna y abandona la funcion

            for (int i = 1; i <= num; i++)
                fac *= i;

            return fac;
        }
        public static long Serie(int Limite)
        {
            long a = 0;
            long suma = 0;
            for (int i = 1; i <= Limite; i++)
            {
                a = factorial(i);
                suma += a;
            }
            return suma;
        }
    }
}
