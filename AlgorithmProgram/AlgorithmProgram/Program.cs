using System;

namespace AlgorithmProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1: For String Permutation");
            Console.WriteLine("2: For Bubble Sort");
            Console.WriteLine("3: For Insertion Sort");
            Console.WriteLine("4: For Prime Number");
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
                case 2:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.Bubblesort();
                    Console.WriteLine();
                    break;
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.Insert();
                    Console.WriteLine();
                    break;
                case 4:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.Primenumber();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Number is Invalid");
                    break;
            }
        }
        
    }
}