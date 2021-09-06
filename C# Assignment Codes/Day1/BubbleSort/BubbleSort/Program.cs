using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Array Elements:");
            String[] arr = Console.ReadLine().Split(' ');
            int[] int_Arr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int_Arr[i] = int.Parse(arr[i]);
            }
            for (int i = 0; i < int_Arr.Length; i++) {
                for (int j = i+1; j < int_Arr.Length-i; j++) {
                    if (int_Arr[i] > int_Arr[j]) {
                        int temp = int_Arr[i];
                        int_Arr[i] = int_Arr[j];
                        int_Arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(int_Arr[i]);
            }
        }
    }
}
