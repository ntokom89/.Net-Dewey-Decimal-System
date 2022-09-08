using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG7321_Task1.Models
{
    public class DALRandomCallNums
    {
        /*https://www.geeksforgeeks.org/radix-sort/
         * Method to get the maximum number
         */
        public static int getMaximum(List<int> numbers, int n)
        {
            int mx = numbers[0];
            for (int i = 1; i < n; i++)
                if (numbers[i] > mx)
                    mx = numbers[i];
            return mx;
        }

        // A function to do counting sort of arr[] according to
        // the digit represented by exp.
        public static void countSort(List<int> numbers, int n, int exp)
        {
            int[] output = new int[n]; // output array
            int i;
            int[] count = new int[10];

            // initializing all elements of count to 0
            for (i = 0; i < 10; i++)
                count[i] = 0;

            // Store count of occurrences in count[]
            for (i = 0; i < n; i++)
                count[(numbers[i] / exp) % 10]++;

            // Change count[i] so that count[i] now contains
            // actual
            //  position of this digit in output[]
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Build the output array
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(numbers[i] / exp) % 10] - 1] = numbers[i];
                count[(numbers[i] / exp) % 10]--;
            }

            // Copy the output array to arr[], so that arr[] now
            // contains sorted numbers according to current
            // digit
            for (i = 0; i < n; i++)
                numbers[i] = output[i];
        }

        // The main function to that sorts arr[] of size n using
        // Radix Sort
        public static void radixsort(List<int> nums, int n)
        {
            // Find the maximum number to know number of digits
            int m = getMaximum(nums, n);

            // Do counting sort for every digit. Note that
            // instead of passing digit number, exp is passed.
            // exp is 10^i where i is current digit number
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(nums, n, exp);
        }


        public static void generateCallNumbers()
        {
            String words = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                int nums = random.Next(1000);
                ListNums.nums.Add(nums);
                var stringChars = new char[3];
                for (int j = 0; j < stringChars.Length; j++)
                {
                    stringChars[j] = words[random.Next(words.Length)];
                }

                var finalString = new String(stringChars);
                ListNums.callNums.Add(nums+finalString); 
                //ListNums.nums[i] = random.Next(1000);
            }

           

            for(int n = 0; n < 10; n++)
            {

            }

           
        }
        public static Boolean CompareList(List<int> array1)
        {
            Boolean result = true;
            for(int i = 0; i< ListNums.nums.Count; i++)
            {
               
                Console.WriteLine("Array 1: " +array1[i]);
                if(array1[i] != ListNums.nums[i])
                {
                    result = false;
                    Console.Write(array1[i]);
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
