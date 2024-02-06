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
                Console.Write($" {sep[sep.Length]} or choose one of the implemented Mathematical Special Methods:\nSquare-Calculation of Double x (Heron-Algorithm) | [Sqrt(x)], Prim-Finder [Sieve_of_Ethothostemes(int max_num)] More coming soon!\n");

                string? term = Console.ReadLine();

                if (term == null || term == String.Empty)
                {
                    Console.WriteLine("Wrong Input! Please try again!");
                    continue;
                }
                else
                {
                    int? [] result = new int?[100];
                    bool rdy=true;
                    string[] num = term.Split(sep);
                    int[] no=new int[num.Length];

                    if (term.Contains("Sieve_of_Ethothostemes"))
                    {
                        num[0] = term.Split('[').ToString();
                    }
                    if (term.Contains("Sqrt"))
                    {
                        num[0] = term.Split('[').ToString();
                    }
                    
                    for(int i=0; i<num.Length;i++)
                    {
                        rdy = int.TryParse(num[i],out no[i]);
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
                                    result[0] = Math.Mod(no[0],no[1]);
                                    break;
                                case "W":
                                    result[0] = Math.Sqrt(no[0]);
                                    break;
                                case "P":
                                    result[] = Math.Sieve_of_Eratosthenes(no[0]);
                                    break;
                                default:
                                    result = null;
                                    break;

                            }
                        }

                        if (result != null)
                        {
                            Console.WriteLine($"{term} = {result}");
                        }
                        else 
                            Console.WriteLine("Unknown Mistake! Please try again!");

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