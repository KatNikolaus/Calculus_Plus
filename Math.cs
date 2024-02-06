using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculus_Plus
{
    internal class Math
    {
        public int Add(int x,int y) { return x + y; }

        public int Sub(int x,int y) { return x - y; }
        public int? Div(int x,int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Input-Error! Divisor = 0!");
                return null;
            }
            else
                return x / y;
        }

        public int Mod(int x,int y) { return x % y; }

        // Heron Method to find the root of x with a accuracy of diff=0,0000001
        public double Sqrt(double x)
        {
            const double diff=0.000001;

            if (x == 0)
                return 0;
            else
            {
                if (x < 0)
                {
                    x = (-1) * x;
                    return (-1) * Sqrt(x);
                }
                else
                {
                    if (x >= 1)
                    {
                        double sqrt=x;
                        double b_n=1;
                        double diff_real= sqrt-b_n;

                        while (diff_real <= diff)
                        {
                            sqrt = (sqrt + b_n) / 2;
                            b_n = x / sqrt;
                            diff_real = sqrt - b_n;
                        }

                        return sqrt;
                    }

                    else
                    {
                        double sqrt=1;
                        double b_n=x;
                        double diff_real= sqrt-b_n;

                        while (diff_real <= diff)
                        {
                            sqrt = (sqrt + b_n) / 2;
                            b_n = x / sqrt;
                            diff_real = sqrt - b_n;
                        }

                        return sqrt;
                    }
                }
            }  
        }

        // Simple Method to find all Prim-Numbers in [2,max]
        public int[] Sieve_of_Eratosthenes(int max) 
        {
            int[] num=new int[max-2];
            int[] prim= new int[max-2];

            int x=0;

            for(int i=0; i<max;i++)
            {
                num[i] = i;
                
            }

            for(int i=0;i<max-2;i++)
            { 
                if (prim[i] == x)
                { }
                    
            }

            return prim;
        }

    }
}
