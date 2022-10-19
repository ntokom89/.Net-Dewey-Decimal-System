
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
            Boolean noDup = false;
            CallNumber.callNumbersDictionary.Clear();
            String words = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            //https://stackoverflow.com/questions/23156197/format-a-number-with-dots-and-decimals-in-c-sharp Me.Name
            var nfi = new NumberFormatInfo { NumberGroupSeparator = "." };
            while (noDup == false)
            {
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
                    getArea(nums, number + finalString);
                    //ListNums.callNums.Add(number + finalString);
                    //ListNums.nums[i] = random.Next(1000);
                }

                //noDup = true;
                //int duplicate = 0;
                var duplicatesValue = CallNumber.callNumbersDictionary.GroupBy(x => x.Value).Where(x => x.Count() > 1);
             


                if (duplicatesValue.Count() > 0)
                {
                    CallNumber.callNumbersDictionary.Clear();
                    
                }
                else
                {
                    noDup = true;
                    break;
                }

            }

        }

        public static void getArea(double num, String CallNum)
        {
            CallNumber number = new CallNumber();


            switch (num)
            {
                case <100:
                    number.CallNum = CallNum;
                    number.CallType = "General Works";
                    number.CallNumDescription = " general works";
                    CallNumber.callNumbersDictionary.Add(number.CallNum, number.CallNumDescription);
                    
                    break;
                case >= 100 and <200:
                    number.CallNum = CallNum;
                    number.CallType = "Philosophy";
                    number.CallNumDescription = " Philosophy";
                    CallNumber.callNumbersDictionary.Add(number.CallNum, number.CallNumDescription);
                    break;
                case >= 200 and < 300:
                    number.CallNum = CallNum;
                    number.CallType = "Religion";
                    number.CallNumDescription = "Religion";
                    CallNumber.callNumbersDictionary.Add(number.CallNum, number.CallNumDescription);
                    break;
                case >= 300 and < 400:
                    number.CallNum = CallNum;
                    number.CallType = "Social Sciences";
                    number.CallNumDescription = " Social Sciences";
                    CallNumber.callNumbersDictionary.Add(number.CallNum, number.CallNumDescription);
                    break;
                case >= 400 and < 500:
                    number.CallNum = CallNum;
                    number.CallType = "Language";
                    number.CallNumDescription = "language";
                    CallNumber.callNumbersDictionary.Add(number.CallNum, number.CallNumDescription);
                    break;
                case >= 500 and < 600:
                    number.CallNum = CallNum;
                    number.CallType = "Science";
                    number.CallNumDescription = "Science";
                    CallNumber.callNumbersDictionary.Add(number.CallNum, number.CallNumDescription);
                    break;
                case >= 600 and < 700:
                    number.CallNum = CallNum;
                    number.CallType = "Technology";
                    number.CallNumDescription = "Technology";
                    CallNumber.callNumbersDictionary.Add(number.CallNum, number.CallNumDescription);
                    break;
                case >= 700 and < 800:
                    number.CallNum = CallNum;
                    number.CallType = "The Arts";
                    number.CallNumDescription = " Arts";
                    CallNumber.callNumbersDictionary.Add(number.CallNum, number.CallNumDescription);
                    break;
                case >= 800 and < 900:
                    number.CallNum = CallNum;
                    number.CallType = "Literature";
                    number.CallNumDescription = " Literature";
                    CallNumber.callNumbersDictionary.Add(number.CallNum, number.CallNumDescription);
                    break;
                case >= 900 and < 999:
                    number.CallNum = CallNum;
                    number.CallType = "History and Geography";
                    number.CallNumDescription = " History and Geography";
                    CallNumber.callNumbersDictionary.Add(number.CallNum, number.CallNumDescription);
                    break;


            }
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
