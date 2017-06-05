using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayString
{
    class Program
    {
        //Time Complexity - O(n)
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int start = 0;
            int end = arr.Length - 1;
            PrintArray(arr, "Initial Array");
            ReverseArrayIterativeMethod(arr, start, end);
            PrintArray(arr, "Reversed Array Iterative");
            ReverseArrayrecursiveMethod(arr, start, end);
            PrintArray(arr, "Reversed Array Recursive");
        }

        public static void ReverseArrayIterativeMethod(int[] arr, int start, int end)
        {
            int temp;
            while (start <= end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        public static void ReverseArrayrecursiveMethod(int[] arr, int start, int end)
        {
            if (start >= end)
                return;

            int temp;
            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            ReverseArrayrecursiveMethod(arr, ++start, --end);
        }

        public static void PrintArray(int[] arr, string msg)
        {
            Console.WriteLine(msg);
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
