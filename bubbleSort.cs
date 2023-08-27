using System;
namespace MyAppication{
    class Program{
        static void Main(string[] args){
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n]; // Creating the array
            for (int i = 0; i < n; i++){
                Console.Write($"Enter element:");
                arr[i] = Convert.ToInt32(Console.ReadLine()); // Entering the values for the array
            }
            bool swapped;
            for (int i = 0; i < n - 1; i++){
                swapped = false;
                for (int j = 0; j < n - i - 1; j++){
                    if (arr[j] > arr[j + 1]){
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped){
                    break;
                }
            }
            Console.WriteLine("\nSorted array:");
            foreach (int num in arr){
                Console.Write(num + " ");
            }
        }
    }
}
