using System.ComponentModel;

namespace Calculus_Plus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] sep = new char[]{ '+','-','*','/','%','#','W'};
            bool modus=true; // quit-control
            char[] opt = new char[10]; 

            Console.WriteLine("Welcome to Calculus_Plus 1.0:");

            while (modus)
            {
                Console.WriteLine("Please edit your mathematical Term:\n");
                for (int i = 0;i < sep.Length - 1;i++)
                {
                    Console.Write($" {sep[i].ToString()} |");
                }
                Console.Write($" {sep[sep.Length-1]}\n or choose one of the implemented Mathematical Special Methods:\nSquare-Calculation of Double x (Heron-Algorithm) [use: Wx] | Prim-Finder for (0,x) [use: #x] \n");

                string? term = Console.ReadLine();

                if (term == null || term == String.Empty)
                {
                    Console.WriteLine("Wrong Input! Please try again!");
                    continue;
                }
                else
                {
                    double? [] result = new double?[100]; // result-Array: mostly only result[0] is filled
                    bool rdy = true;
                    string[] num = term.Split(sep);
                    double[] no = new double[num.Length];
                    
                    for(int i=0;i<sep.Length;i++)
                    {
                        if (term.Contains(sep[i]))
                            opt[i] = sep[i];
                    }

                    for(int i=0; i < num.Length ;i++)
                    {
                        //rdy &= 
                            double.TryParse(num[i],out no[i]);
                    }

                    if (rdy)
                    {

                        for (int i = 0;i < opt.Length;i++)
                        {

                            switch (opt[i])
                            {
                                case '+':
                                    result[0] = Math.Add(no[0],no[1]);
                                    break;

                                case '-':
                                    result[0] = Math.Sub(no[0],no[1]);
                                    break;
                                case '*':
                                    result[0] = Math.Mul(no[0],no[1]);
                                    break;
                                case '/':
                                    result[0] = Math.Div(no[0],no[1]);
                                    break;
                                case '%':
                                    bool x_rdy = int.TryParse(no[0].ToString(), out int x);
                                    bool y_rdy = int.TryParse(no[1].ToString(), out int y);
                                    if(x_rdy && y_rdy)
                                        result[0] = Math.Mod(x,y);
                                    else result[0] = null;
                                    break;
                                case 'W': 
                                    result[0] = Math.Sqrt(no[1]);
                                    break;
                                case '#': 
                                    bool z_rdy = int.TryParse(no[1].ToString(),out int z);
                                    if (z_rdy)
                                    {
                                        int?[] tmp = new int?[result.Length];
                                        tmp = Math.Sieve_of_Eratosthenes(z);
                                   
                                        for(int h=0; h<result.Length;h++)
                                        {
                                            result[h] = tmp[h];
                                        }
                                    }
                                    else
                                        result[0] = null;
                                    break;
                                default:
                                    result[1] = null;
                                    break;

                            }
                        }

                        if (result != null)
                        {

                            for (int i = 0;i < result.Length;i++)
                            {
                                if (result[i] != null)
                                {
                                    Console.WriteLine($"{term} = {result[i].ToString()}");
                                    break;
                                }
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