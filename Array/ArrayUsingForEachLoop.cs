using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Array
{
    internal class ArrayUsingForEachLoop
    {
        static void Main(string[] args)
        {
            // One Dimentional Array

            /*int[] arr = { 10, 20, 30, 40, 50 };
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }

            // Two Dimentional Array
            int[,] arr2 = new int[3, 4]
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12}
            };
            foreach(var item in arr2)
            {
                Console.WriteLine(item);
            }*/

            //print 5 names using foreach loop
            /*string[] arr3 = { "Shubham","Satyam", "Smita", "Vrushali", "Yash" };
            foreach (var name in arr3)
            {
                Console.WriteLine(name);
            }*/


            //Declare an array of 5 elements and display it inn ascending order.
            //bubble sort --> data structure
            // in the first iteration smalest  element will be place at first position
            // Write Dry Run for program

            /*int[] arr = { 14, 28, 9, 75, 8 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Ascending Order");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }*/

            // WAP to count frequency of each element in an array
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                int cnt = 1;
                bool flag = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (array[k] == array[i])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            cnt++;
                        }
                    }
                }
                if (cnt > 1)
                {
                    Console.WriteLine($"Number={array[i]} frequency={cnt}");
                }

            }
        }
    }
}
