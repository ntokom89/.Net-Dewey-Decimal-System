using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7321_Task_1.Model
{
    public  class RadixSort
    {
        /*https://www.geeksforgeeks.org/radix-sort/
        * Method to get the maximum number
        */
        public static String getMaximum(List<string> numbers, int n)
        {
            string mx = numbers[0];
            for (int i = 1; i < n; i++)
                if (numbers[i].CompareTo(mx) > 0)
                    mx = numbers[i];
            return mx;
        }

        // A function to do counting sort of arr[] according to
        // the digit represented by exp.
        public static void countSort(List<String> numbers, int position, int radix)
        {
            //String[] output = new String[n]; // output array
            int nos = numbers.Count;
            int[] count = new int[radix];

            // initializing all elements of count to 0
            foreach (String value in numbers)
            {
                count[getDigit(position, value, radix)]++;
            }
            // Store count of occurrences in count[]
            for (int i = 1; i < radix; i++)
            {
                count[i] = count[i] + count[i - 1];
            }
            String[] tempArray = new String[nos];
            // Change count[i] so that count[i] now contains
            // actual
            //  position of this digit in output[]
            for (int i = nos - 1; i >= 0; i--)
            {
                tempArray[--count[getDigit(position, numbers[i], radix)]] = numbers[i];
            }
            // Copying into the actual array
            for (int i = 0; i < nos; i++)
            {
                numbers[i] = tempArray[i];
            }
        }

        public static int getDigit(int position, String value, int radix)
        {
            var nos = value.Length - 1;
            var c = value.ToLower()[nos - position];
            return (int)c - 97;
        }

        // The main function to that sorts arr[] of size n using
        // Radix Sort
        public static void radixsort(List<String> nums, int radix, int width)
        {
            // Find the maximum number to know number of digits
            // Do counting sort for every digit. Note that
            // instead of passing digit number, exp is passed.
            // exp is 10^i where i is current digit number
            for (int i = 0; i< width; i++)
                countSort(nums, i, radix);
        }


    }
}
