using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class PrimeNumber
    {
        public void Primenumber()
        {
            int num, Start, End, flag;
            Console.WriteLine("Enter a Range for Prime number ");
            Console.WriteLine("Enter a start value");
            Start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a End value");
            End = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime numbers between {0} and {1} are : \n", Start, End);

            for (num = Start; num <= End; num++)
            {
                flag = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.ReadLine();
        }
    }
}
