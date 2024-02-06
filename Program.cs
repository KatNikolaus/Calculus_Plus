using System.ComponentModel;

namespace Calculus_Plus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            double sqrt = math.Sqrt(9.0);
            Console.WriteLine($"Calculation of Sqrt(9) = {sqrt.ToString()}");
        }
    }

    
}