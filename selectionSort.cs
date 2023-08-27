using System;
using System.Collections.Generic;

namespace MyApplication
{
    class Program
    {
        static int FindMin(int[] arr)
        {
            int minInd = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minInd])
                {
                    minInd = i;
                }
            }
            return minInd;
        }

        static void Main(string[] args)
        {
            List<int> minVal = new List<int>();
            Console.WriteLine("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n]; // Corrected array initialization
            Console.WriteLine("Enter the element values: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                int minInd = FindMin(arr);
                minVal.Add(arr[minInd]);
                List<int> List2 = new List<int>(arr);
                List2.RemoveAt(minInd);
                arr = List2.ToArray();
            }
            Console.WriteLine("\nSorted Array: ");
            foreach (int value in minVal)
            {
                Console.Write(value + " ");
            }
        }
    }
}
