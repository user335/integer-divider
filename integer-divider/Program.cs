using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer_divider
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intlist = new List<int>()
            {
                1, 2, 3, 4, 5, 6,
                2, 4, 6, 8, 10, -12
            };
            float divisor = -1;
            bool succeeded = false;
            while (!succeeded) PromptForDivision();

            void PromptForDivision()
            {
                Console.WriteLine("I have here a secret list of integers. What would you like to divide them all by?");
                var answer = Console.ReadLine();
                try
                {
                    divisor = Convert.ToSingle(answer);
                    Console.WriteLine("Here are your results: ");

                    //this will be caught by dividebyzeroexception. 
                    //Required because the block that's actually expected to work does not produce exceptions when dividing by zero
                    //no clue why that is but if you don't believe me comment out the following 7 lines and run the program with 0 for input. everything returns infinity symbols
                    if (divisor == 0) 
                    {
                        for (int i = 0; i < intlist.Count; i++)
                        {
                            Console.WriteLine(intlist[i] + " / 0 = " + intlist[i] / 0);
                        }
                    }

                    //this will NOT be caught by dividebyzeroexception even when dividing by zero! console writes infinity symbols for every result
                    for (int i = 0; i < intlist.Count; i++)
                    {                        
                        Console.WriteLine(intlist[i] / divisor);  
                    }

                    Console.WriteLine("Everything seems fine.");
                    succeeded = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Argument Exception detected. Definitely your fault.");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Argument Exception detected. I blame you.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Are you trying to make me divide by zero? Not cool, bro!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("I have no idea what you did. Error message = " + ex);
                }
                //if (divisor == 0) Console.WriteLine("Are you trying to make me divide by zero? Not cool, bro!");
                if (!succeeded) Console.WriteLine("Let's try that again...");
            }


            Console.Read();
        }

    }
}
