using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG7321_Task1.Model
{
    public class DALRandomCallNums
    {
        /*https://www.geeksforgeeks.org/radix-sort/
         * Method to get the maximum number
         */



        public static void generateCallNumbers()
        {
            String words = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                double nums = Math.Round((double)random.NextDouble()*999,2);
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
                ListNums.callNums.Add(nums.ToString("#.##") + finalString); 
                //ListNums.nums[i] = random.Next(1000);
            }

           

            for(int n = 0; n < 10; n++)
            {

            }

           
        }
        public static Boolean CompareList(List<String> array1)
        {
            Boolean result = true;
            for(int i = 0; i< ListNums.callNums.Count; i++)
            {
               
                Console.WriteLine("Array 1: " +array1[i]);
                if(array1[i] != ListNums.callNums[i])
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
