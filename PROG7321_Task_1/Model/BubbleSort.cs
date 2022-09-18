using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7321_Task_1.Model
{
    public  class BubbleSort
    {
        //A method to swap the string List using BubbleSort
        public static void Sort(List<string> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }
        //Method to swap the elements in the first and second in the array selected.
        private static void Swap(List<string> array, int first, int second)
        {
            string temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
