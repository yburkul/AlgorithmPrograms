﻿using System;

namespace AlgorithmProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1: For String Permutation");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    String str = "ABC";
                    int n = str.Length;
                    Permutations permutations = new Permutations();
                    permutations.Permute(str, 0, n - 1);
                    permutations.IterationPermutation(str);
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Number is Invalid");
                    break;
            }
        }
        
    }
}