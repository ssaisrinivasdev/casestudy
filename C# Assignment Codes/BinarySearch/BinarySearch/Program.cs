using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Sorted Array Elements:");
            String[] arr = Console.ReadLine().Split(' ');
            int[] int_Arr= new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) {
                int_Arr[i] = int.Parse(arr[i]);
            }
            Array.Sort(int_Arr);
            Console.WriteLine("Enter Any Value to Search: ");
            int searchNum =int.Parse(Console.ReadLine());
            int output = binarySearch(int_Arr,0, int_Arr.Length,searchNum);
            if (output == -1)
            {
                Console.WriteLine("The Value is not found in the array");
            }
            else {
                Console.WriteLine("The Value is found at {0}",output);
            }
        }
        static int binarySearch(int[] ar,int low,int high, int searchNo) {
            if (high >= low) {
                int mid = low + (high - low) / 2;

                if (ar[mid] == searchNo)
                    return mid;

                if (ar[mid] > searchNo)
                    return binarySearch(ar, low, mid - 1, searchNo);

                return binarySearch(ar, mid + 1, high, searchNo);
            }
            return -1;
        }
    }
}
