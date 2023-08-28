using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 12.	WAP to reverse the array itself, don’t print array in reverse – I want current array reverse. 
Means e.g. arr[] = [3, 90, 45, 29, 37, 78]
so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array.
 */

namespace Array
{
    public class ArrayBasicToAdvance
    {
        public static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int temp;
                temp = array[i];
                array[i] = array[array.Length - 1];
                array[array.Length - 1] = temp;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


        }

        public static void Main(string[] args)
        {


            int[] array = new int[] { 3, 90, 45, 29, 37, 78 };
            ReverseArray(array);
        }
    }
}