using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Solution
{
        public class SolutionClass
        {
            public static string EvenOrOdd(int number)
            {
                number = Convert.ToInt32(Console.ReadLine());
                float x = number / 2;

                if(x > number / 2 || x < number / 2)
                {
                    return "Odd";
                }
                else
                {
                    return "even";
                }
            }
        }
}

