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
                2, 4, 6, 8, 10, 12
            };
            float divisor = -1;

            while (divisor <= 0) PromptForDivision();

            void PromptForDivision()
            {
                Console.WriteLine("I have here a secret list of integers. What would you like to divide them all by?");
                var answer = Console.ReadLine();
                try
                {
                    divisor = Convert.ToSingle(answer);
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
                if (divisor <= 0) Console.WriteLine("Let's try that again...");
            }

            //5
            Console.WriteLine("Seems like you entered a good value. Thanks, that makes my job easier.");
            Console.WriteLine("Here are your results: ");
            for (int i = 0; i < intlist.Count; i++)
            {
                Console.WriteLine(intlist[i] / divisor);
            }

            Console.Read();
        }

    }
}
