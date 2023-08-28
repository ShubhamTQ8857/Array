using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class JaggedArray1
    {
        static void Main(string[] args)
        {
            // By Print Statement
            /*int[] [] jarray = new int[4][];

            jarray[0] = new int[] { 1, 2, 3, 4, 5 };
            jarray[1] = new int[] { 10, 20, 30 };
            jarray[2] = new int[] { 100, 200 };
            jarray[3] = new int[] { 1000 };

            //      row = 0    0<4     
            for(int row = 0; row<jarray.Length; row++ ) //row length
            {
                //      col = 0    0<5     --> jarray[0].Length
                for(int col = 0; col < jarray[row].Length; col++)
                {
                    Console.WriteLine(jarray[row][col]+ " ");
                }
                Console.WriteLine("\n");
            }*/

            //By taking input from user
            int[][] jarray = new int[4][];

            jarray[0] = new int[5];
            jarray[1] = new int[3];
            jarray[2] = new int[2];
            jarray[3] = new int[1];

            for (int row = 0; row < jarray.Length; row++)
            {
                for (int col = 0; col < jarray[row].Length; col++)
                {
                    Console.WriteLine("Enter VAlue");
                    jarray[row][col] = Convert.ToInt32(Console.ReadLine());
                }

            }

        }
    }
}
