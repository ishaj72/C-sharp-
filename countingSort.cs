using System;

namespace MyApplication{
    class Program{
        static void CountingSort(int[] arr){
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++){
                if (arr[i] > max){
                    max = arr[i];
                }
            }
            int[] count = new int[max + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i]]++;
            }
            int index = 0;
            for (int i = 0; i <= max; i++){
                while (count[i] > 0){
                    arr[index] = i;
                    index++;
                    count[i]--;
                }
            }
        }
        static void Main(string[] args){
            Console.WriteLine("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the element values: ");
            for (int i = 0; i < n; i++){
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            CountingSort(arr);
            Console.WriteLine("\nSorted Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
