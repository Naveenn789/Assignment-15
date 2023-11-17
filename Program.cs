using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment15
{
    public class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            int noswap = 0;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;

                        noswap++;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        static int BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                if (arr[mid] < key)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1; // Key not found
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }






        static void Main(string[] args)
        {
            //int n;
            //Console.WriteLine("Enter the length of array : ");
            //n = int.Parse(Console.ReadLine());
            //int[] arr =new int[n];
            //Console.WriteLine("Enter the elements in array");
            //for (int i=0;i<arr.Length; i++)
            //{
            //    arr[i]= int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Elements in the array Before Sorting");
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //    for (int i = 0; i < n - 1; i++)
            //    {
            //        int count = 0;
            //        if (arr[i] > arr[i + 1])
            //        {
            //            int temp = arr[i + 1];
            //            arr[i + 1] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }

            //Console.WriteLine("Elements after the sorting is");
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}


            int[] arr = { 5, 2, 4, 9, 6, 7 };
            Console.WriteLine("print array without sort");
            Print(arr);
            BubbleSort(arr);
            Console.WriteLine("after bubble sort");
            Print(arr);

            // Binary Search demonstration
            Console.WriteLine("ENter element to find in the array : ");
            int n = int.Parse(Console.ReadLine());
            int key = n; // Change this value to search for a different key
            int result = BinarySearch(arr, key);
            if (result != -1)
            {
                Console.WriteLine($"Element {key} found at index {result}");
            }
            else
            {
                Console.WriteLine($"Element {key} not found in the array");
            }






            Console.ReadKey();

        }
    }
}
