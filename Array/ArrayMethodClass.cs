using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ArrayMethodClass
    {
        /*Write two methods that return the average of an array with following headers.
           i. public static int average(int[] array)
           ii.  public static double average(double[] array).
           iii.Write main and invoke the 2 methods.*/
        public static int Average(int[] array)
        {
            int cnt = 0, sum = 0, avg;
            for(int i = 0; i<array.Length; i++)
            {
                Console.WriteLine("Enter Num");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<array.Length; i++)
            {
                sum += array[i];
                cnt++;
            }
            avg = sum / cnt;
            return avg;
        }

        public static double Average(double[] array)
        {
            int cnt = 0;
            double avg, sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Number");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                cnt++;
            }
            avg = sum / cnt;
            return avg;
        }

        static void Main(string[] args)
        {
            /*int[] array = new int[6];
            Console.WriteLine(Average(array));

            double[] array2 = new double[4];
            Console.WriteLine(Average(array2));*/

        }
    }
}
