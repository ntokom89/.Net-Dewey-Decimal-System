using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PROG7321_Task1.Model
{
    public class DALRandomCallNums
    {
        /*https://www.geeksforgeeks.org/radix-sort/
         * Method to get the maximum number
         */


        //Method to randomly generate Call Numbers
        //https://mkyong.com/java/java-generate-random-integers-in-a-range/
        //https://learn.microsoft.com/en-us/dotnet/api/system.math.round?view=net-7.0
        public static void generateCallNumbers()
        {
            String words = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            //https://stackoverflow.com/questions/23156197/format-a-number-with-dots-and-decimals-in-c-sharp Me.Name
            var nfi = new NumberFormatInfo { NumberGroupSeparator = "." };
            for (int i = 0; i < 10; i++)
            {
                double nums = (double)Math.Round(random.NextDouble()*999,2);
                Console.WriteLine(nums);
                //double digit = random.Next(99);
                var check = (from x in ListNums.nums
                             where x.Equals(nums)
                             select x).ToList();
                if (check.Count > 0)
                {
                    ListNums.nums.Clear();
                    i = 0;
                }
                else
                {
                    ListNums.nums.Add(nums);
                }
                var stringChars = new char[3];
                for (int j = 0; j < stringChars.Length; j++)
                {
                    stringChars[j] = words[random.Next(words.Length)];
                }

                var finalString = new String(stringChars);
                //https://stackoverflow.com/questions/164926/how-do-i-display-a-decimal-value-to-2-decimal-places
                //Convert nums to String
                String number = nums.ToString("0##.00", nfi);
                ListNums.callNums.Add(number + finalString); 
                //ListNums.nums[i] = random.Next(1000);
            }

           

            for(int n = 0; n < 10; n++)
            {

            }

           
        }
        //Method to compare the user submitted list to sorted list
        public static Boolean CompareList(List<String> listCallNumsUser)
        {
            Boolean result = true;
            for(int i = 0; i< ListNums.callNums.Count; i++)
            {
               
                Console.WriteLine("Array 1: " +listCallNumsUser[i]);
                if(listCallNumsUser[i] != ListNums.callNums[i])
                {
                    result = false;
                    Console.Write(listCallNumsUser[i]);
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
