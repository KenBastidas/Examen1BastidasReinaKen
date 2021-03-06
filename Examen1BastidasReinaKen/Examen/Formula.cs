﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Formula
    {
        public static double Formu(int k, int d)
        {
            //S= (2x5!) + (2^2x 4!) + (2^3x 3!) + (2^4x2!) + (2^5 x 1!)
            double total = 0;
            double calula = 0;
            for (int x = k; x <= d; x++)
            {
                calula += ((Math.Pow(2,x*5)) + (Math.Pow(2^2, x * 4)) + (Math.Pow(2^3,x*3)) + (Math.Pow(2^4,x*2)) + (Math.Pow(2^5,x*1)));
            }
            total = total + calula;


            return total;
        }
    }
}
