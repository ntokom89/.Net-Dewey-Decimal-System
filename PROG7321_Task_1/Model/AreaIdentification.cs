
using PROG7321_Task1.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7321_Task_1.Model
{
    internal class AreaIdentification
    {
        public static void generateCallNumbers()
        {
            String words = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            //https://stackoverflow.com/questions/23156197/format-a-number-with-dots-and-decimals-in-c-sharp Me.Name
            var nfi = new NumberFormatInfo { NumberGroupSeparator = "." };
            for (int i = 0; i < 7; i++)
            {
                double nums = (double)Math.Round(random.NextDouble() * 999, 2);
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
                CallNumber numberC = getArea(nums, number + finalString);
                CallNumber.callNumbers.Add(numberC);
                //ListNums.callNums.Add(number + finalString);
                //ListNums.nums[i] = random.Next(1000);
            }



            for (int n = 0; n < 10; n++)
            {

            }


        }

        public static CallNumber getArea(double num, String CallNum)
        {
            CallNumber number = new CallNumber();


            switch (num)
            {
                case <100:
                    number.CallNum = CallNum;
                    number.CallType = "General Works";
                    number.CallNumDescription = "The call number is of type general works";
                    
                    break;
                case >= 100 and <200:
                    number.CallNum = CallNum;
                    number.CallType = "Philosophy";
                    number.CallNumDescription = "The call number for book is of type Philosophy";
                    break;
                case >= 200 and < 300:
                    number.CallNum = CallNum;
                    number.CallType = "Religion";
                    number.CallNumDescription = "The call number is of type Religion";
                    break;
                case >= 300 and < 400:
                    number.CallNum = CallNum;
                    number.CallType = "Social Sciences";
                    number.CallNumDescription = "The call number is of type Social Sciences";
                    break;
                case >= 400 and < 500:
                    number.CallNum = CallNum;
                    number.CallType = "Language";
                    number.CallNumDescription = "The call number is of type language";
                    break;
                case >= 500 and < 600:
                    number.CallNum = CallNum;
                    number.CallType = "Science";
                    number.CallNumDescription = "The call number is of type Science";
                    break;
                case >= 600 and < 700:
                    number.CallNum = CallNum;
                    number.CallType = "Technology";
                    number.CallNumDescription = "The call number is of type Technology";
                    break;
                case >= 700 and < 800:
                    number.CallNum = CallNum;
                    number.CallType = "The Arts";
                    number.CallNumDescription = "The call number is of type Arts";
                    break;
                case >= 800 and < 900:
                    number.CallNum = CallNum;
                    number.CallType = "Literature";
                    number.CallNumDescription = "The call number is of type Literature";
                    break;
                case >= 900 and < 999:
                    number.CallNum = CallNum;
                    number.CallType = "History and Geography";
                    number.CallNumDescription = "The call number is of type History and Geography";
                    break;


            }
            return number;
        }

        public CallNumber getAreaPart2(double num,char place)
        {
            CallNumber number = new CallNumber();
            

            switch (num)
            {
                case < 100:
                    break;
                case >= 100 and < 200:
                    break;
                case >= 200 and < 300:
                    break;
                case >= 300 and < 400:
                    break;
                case >= 500 and < 600:
                    break;
                case >= 600 and < 700:
                    break;
                case >= 800 and < 900:
                    break;
                case >= 900 and < 999:
                    break;


            }
            return number;
        }
    }
}
