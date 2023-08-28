using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Array2D
    {
        static void Main(string[] args)
        {
            // syntax of 2D array
            // here 4 is row size and 5 is column size
            int[,] arr = new int[4, 5]
            {
                {10,20,30,40,50 },
                {60,70,80,90,100 },
                {110,120,130,140,150 },
                {160,170,180,190,200 }
            };

            // nested for loop to display the 2D array

            for (int row = 0; row < arr.GetLength(0); row++) // row --> 0 
            {
                for (int col = 0; col < arr.GetLength(1); col++) //col --> 1
                {
                    Console.Write($"arr[{row},{col}] = {arr[row, col]}  ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("=======================================================");

            int[,] arr1 = new int[4, 5];

            //accept 2D data from user
            for (int row = 0; row < arr.GetLength(0); row++) // row --> 0 
            {
                for (int col = 0; col < arr.GetLength(1); col++) //col --> 1
                {
                    arr[row, col] = Convert.ToInt32(Console.ReadLine());
                }

            }

            
            // nested for loop to display the 2D array

            for (int row = 0; row < arr.GetLength(0); row++) // row --> 0 
            {
                for (int col = 0; col < arr.GetLength(1); col++) //col --> 1
                {
                    Console.Write($"arr[{row},{col}] = {arr[row, col]}  ");
                }
                Console.WriteLine("\n");
            }


        }
    }
}
