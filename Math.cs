using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculus_Plus
{
    internal class Math
    {
        public static int Add(int x,int y) { return x + y; }

        public static int Sub(int x,int y) { return x - y; }

        public static int Mul(int x,int y) { return x * y; }
        public static int? Div(int x,int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Input-Error! Divisor = 0!");
                return null;
            }
            else
                return x / y;
        }

        public static double Add(double x,double y) { return x + y; }

        public static double Sub(double x,double y) { return x - y; }

        public static double Mul(double x,double y) { return x * y; }
        public static double Div(double x,double y) { return x / y; }
        public static double? Div(double? x,double? y)
        {
            if (x == null || y == null)
            {
                Console.WriteLine("Para-Mistake!");
                return null;
            }
            if (y == 0)
            {
                Console.WriteLine("Input-Error! Divisor = 0!");
                return null;
            }
            else
                return x / y;
        }

        public static int Mod(int x,int y) { return x % y; }

        // Heron Method to find the root of x with a accuracy of diff=0,0000001
        public static double Sqrt(double x)
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
                        double diff_real= Sub(sqrt,b_n);

                        while (diff_real >= diff)
                        {
                            sqrt = Div(Add(sqrt,b_n),2.0);
                            b_n = Div(x,sqrt);
                            diff_real = Sub(sqrt,b_n);
                        }

                        return sqrt;
                    }

                    else
                    {
                        double sqrt = 1;
                        double b_n = x;
                        double diff_real= Sub(sqrt,b_n);

                        while (diff_real <= diff)
                        {
                            sqrt = Div(Add(sqrt,b_n),2.0);
                            b_n = Div(x,sqrt);
                            diff_real = Sub(sqrt,b_n);
                        }

                        // missing: formatting sqrt= X.XXXXXX
                        return sqrt;
                    }
                }
            }
        }

        public static int? Fak(int x)
        {
            int f = x;

            if (f == 0)
                return 0;
            else if (f == 1)
                return 1;
            else if (f > 1)
            {
                return f*Fak(f - 1);
            }
            else
            {
                Console.WriteLine("Fak-Error!");
                return null;
            }    
        }

        // Simple Method to find all Prim-Numbers in [2,max]
        public static int?[] Sieve_of_Eratosthenes(int max)
        {
            int?[] result = new int?[max+1];
            int ?[] tmp = new int?[max+1];

            if (max+1 < 99999)
            {
                for (int i = 0;i <= max;i++)
                {
                    tmp[i] = i;
                }
            }
            else
            {
                Console.WriteLine("Input-Mistake! Please minorize your Sieve-Border!");
                return null;
            }

            for (int i = 0;i <= max;i++)   // Arrayvergleichswertdurchlauf
            {
                if (tmp[i] == 0 || tmp[i] == 1)
                {
                    tmp[i] = -1;
                    continue;
                }
                if (tmp[i] == -1)
                {
                    continue;
                }
                for (int j = 0;j <= max - 1;j++) 
                {
                    if (tmp[j] % i == 0 && tmp[j] / i != 1)
                    {
                        tmp[j] = -1;
                    }
                }
            }

            for (int j = 0;j <= max;j++)
            {
                for (int i = 0;i <= max;i++)
                {
                    if (tmp[i] != -1)
                    {
                        result[j] = tmp[i];
                        tmp[i] = -1;
                        break;
                    }
                }
            }

            return result;

        }

    }

}

