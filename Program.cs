using System.ComponentModel;

namespace Calculus_Plus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] sep = new char[]{ '+','-','*','/','%'};
            bool modus=true;
            string[] opt = new string[100]; 

            Console.WriteLine("Welcome to Calculus_Plus 1.0:");

            while (modus)
            {
                Console.WriteLine("Please edit your el. mathematical Calculation");
                for (int i = 0;i < sep.Length - 1;i++)
                {
                    Console.Write($" {sep[i]} |");
                }
                Console.Write($" {sep[sep.Length-1]} or choose one of the implemented Mathematical Special Methods:\nSquare-Calculation of Double x (Heron-Algorithm) | [Sqrt(x)], Prim-Finder [Sieve_of_Ethothostemes(int max_num)] More coming soon!\n");

                string? term = Console.ReadLine();

                if (term == null || term == String.Empty)
                {
                    Console.WriteLine("Wrong Input! Please try again!");
                    continue;
                }
                else
                {
                    double? [] result = new double?[100];
                    bool rdy=true;
                    string[] num = term.Split(sep);
                    double[] no=new double[num.Length];

                    if (term.Contains("Sieve_of_Ethothostemes"))
                    {
                        num[0] = term.Split('[').ToString();
                    }
                    if (term.Contains("Sqrt"))
                    {
                        num[0] = term.Split('[').ToString();
                    }
                    
                    for(int i=0; i < num.Length ;i++)
                    {
                        rdy = double.TryParse(num[i],out no[i]);
                    }
                    if (rdy)
                    {

                        for (int i = 0;i < opt.Length;i++)
                        {

                            switch (opt[i])
                            {
                                case "+":
                                    result[0] = Math.Add(no[0],no[1]);
                                    break;
                                case "-":
                                    result[0] = Math.Sub(no[0],no[1]);
                                    break;
                                case "*":
                                    result[0] = Math.Mul(no[0],no[1]);
                                    break;
                                case "/":
                                    result[0] = Math.Div(no[0],no[1]);
                                    break;
                                case "%":
                                    bool x_rdy = int.TryParse(no[0].ToString(), out int x);
                                    bool y_rdy = int.TryParse(no[1].ToString(), out int y);
                                    if(x_rdy && y_rdy)
                                        result[0] = Math.Mod(x,y);
                                    else result[0] = null;
                                    break;
                                case "W": // need to be implemented W should be an alias for the Math.Sqrt()-method
                                    result[0] = Math.Sqrt(no[0]);
                                    break;
                                case "P": // need to be implemented P should be an alias for the Math.Sieves_of_Eratosthenes()-method
                                    bool z_rdy = int.TryParse(no[0].ToString(),out int z);
                                    if (z_rdy)
                                    {
                                        int[] tmp = new int[result.Length];
                                        tmp = Math.Sieve_of_Eratosthenes(z);
                                   
                                        for(int h=0; h<result.Length;h++)
                                        {
                                            result[h] = tmp[h];
                                        }
                                    }
                                    else
                                        result = null;
                                    break;
                                default:
                                    result = null;
                                    break;

                            }
                        }

                        if (result != null)
                        {

                            for (int i = 0;i < result.Length;i++)
                            {
                                if (result[i] != null)
                                    Console.WriteLine($"{term} = {result}");
                                else
                                    Console.WriteLine("Unknown Mistake! Please try again!");
                            }
                        }
                        else Console.WriteLine("Unknown Mistake!");

                        Console.WriteLine("Once again? [Y / N]");

                        string ui = Console.ReadLine().ToUpper();

                        if (ui == "Y")
                            continue;
                        else if(ui == "N")
                        {
                            modus=false;
                        }
                        else
                        { Console.WriteLine("Wrong Input!"); }
                    }
                    else 
                        Console.WriteLine("Parameter-Mistake: One of your Input-Numbers is wrong!");
                }
                
            }
        }
    }   
}