using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class BubbleSort
    {
        public void Bubblesort()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - j -1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        Console.WriteLine("Sorted:");
                        foreach (int p in arr)
                            Console.WriteLine(p + " ");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
