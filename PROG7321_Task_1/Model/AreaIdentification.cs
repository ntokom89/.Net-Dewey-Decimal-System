
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
        //Method to randomly generate Call Numbers
        //https://mkyong.com/java/java-generate-random-integers-in-a-range/
        //https://learn.microsoft.com/en-us/dotnet/api/system.math.round?view=net-7.0
        public static void generateCallNumbers(int level)
        {
            Boolean noDup = false;
            CallNumber.callNumbersDictionary.Clear();
            List<double> numsList = new List<double>();
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
                    var check = (from x in numsList
                                 where x.Equals(nums)
                                 select x).ToList();
                    if (check.Count > 0)
                    {
                        numsList.Clear();
                        i = 0;
                    }
                    else
                    {
                        numsList.Add(nums);
                    }
                    var stringChars = new char[3];
                    for (int j = 0; j < stringChars.Length; j++)
                    {
                        stringChars[j] = words[random.Next(words.Length)];
                    }

                    var finalString = new String(stringChars);
                    //https://stackoverflow.com/questions/164926/how-do-i-display-a-decimal-value-to-2-decimal-places
                    //Convert nums to String
                    String Callnumber = nums.ToString("0##.00", nfi) + finalString;
                    getArea(nums, Callnumber, level);
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

        //https://www.dps61.org/Page/17444
        //Method to get description according to Dewey Decimal System
        //https://stackoverflow.com/questions/20147879/switch-case-can-i-use-a-range-instead-of-a-one-number Steve Gomez
        public static void getArea(double num, String CallNum, int level)
        {
            CallNumber number = new CallNumber();

            if (level == 1)
            {
                switch (num)
                {
                    case < 100:
                        number.CallNum = CallNum;
                        number.CallType = "General Works";
                        number.CallNumDescription = " general works";
                        CallNumber.callNumbersDictionary.Add(number.CallNum, number.CallNumDescription);

                        break;
                    case >= 100 and < 200:
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
            }else if(level == 2)
            {
                //Declare new class to get the level 2 descriptions
                Level2AreaDescription level2AreaDescription = new Level2AreaDescription();
                switch (num)
                {
                    case < 100:
                        number.CallNum = CallNum;
                        number.CallType = "General Works";
                        number.CallNumDescription = "General Works";
                        level2AreaDescription.getDesGenWorks(num,CallNum,number.CallNumDescription);
                        

                        break;
                    case >= 100 and < 200:
                        number.CallNum = CallNum;
                        number.CallType = "Philosophy";
                        number.CallNumDescription = "Philosophy";
                        level2AreaDescription.getDesPhilosophy(num, CallNum, number.CallNumDescription);
                        break;
                    case >= 200 and < 300:
                        number.CallNum = CallNum;
                        number.CallType = "Religion";
                        number.CallNumDescription = "Religion";
                        level2AreaDescription.getDesReligion(num, CallNum, number.CallNumDescription);
                        break;
                    case >= 300 and < 400:
                        number.CallNum = CallNum;
                        number.CallType = "Social Sciences";
                        number.CallNumDescription = " Social Sciences";
                        level2AreaDescription.getDesSocialSciences(num, CallNum, number.CallNumDescription);
                        break;
                    case >= 400 and < 500:
                        number.CallNum = CallNum;
                        number.CallType = "Language";
                        number.CallNumDescription = "Language";
                        level2AreaDescription.getDesLanguage(num, CallNum, number.CallNumDescription);
                        break;
                    case >= 500 and < 600:
                        number.CallNum = CallNum;
                        number.CallType = "Science";
                        number.CallNumDescription = "Science";
                        level2AreaDescription.getDesScience(num, CallNum, number.CallNumDescription);
                        break;
                    case >= 600 and < 700:
                        number.CallNum = CallNum;
                        number.CallType = "Technology";
                        number.CallNumDescription = "Technology";
                        level2AreaDescription.getDesTechnology(num, CallNum, number.CallNumDescription);
                        break;
                    case >= 700 and < 800:
                        number.CallNum = CallNum;
                        number.CallType = "The Arts";
                        number.CallNumDescription = "Arts";
                        level2AreaDescription.getDesTheArts(num, CallNum, number.CallNumDescription);
                        break;
                    case >= 800 and < 900:
                        number.CallNum = CallNum;
                        number.CallType = "Literature";
                        number.CallNumDescription = "Literature";
                        level2AreaDescription.getDesLiterature(num, CallNum, number.CallNumDescription);
                        break;
                    case >= 900 and < 999:
                        number.CallNum = CallNum;
                        number.CallType = "History and Geography";
                        number.CallNumDescription = "History and Geography";
                        level2AreaDescription.getDesHistoryGeography(num, CallNum, number.CallNumDescription);
                        break;


                }
            }
        }


    }
}
