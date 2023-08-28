using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Array
{
    public class Array1
    {

        static void Main(string[] args)
        {
            // declaration of array for int data type
            //data type [] variale name =new data type[size];
            /* int[] numbers = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

             // how to access single element - using index
             Console.WriteLine(numbers[4]);

             Console.WriteLine(numbers[0]);

             numbers[7] = 800;
             Console.WriteLine(numbers[7]);

             Console.WriteLine("Using For Loop");
             //Using for loop
             for (int i = 0; i < numbers.Length; i++) // to assume i is your index value
             {
                 Console.WriteLine($"numbers[{i}]= {numbers[i]}");
             }

             Console.WriteLine("Using ForEach Loop");
             //Using foreach loop
             foreach (int item in numbers)
             {
                 Console.WriteLine(item);
             }*/


            //Write code int type of array & Calculate Sum Of Even Elements of array.
            /* int sum = 0;
             int[] array = new int[6];

             for(int i = 0; i<array.Length; i++)
             {
                 Console.WriteLine("Enter Array Number");
                 array[i] = Convert.ToInt32(Console.ReadLine());
             }
             for(int i=0; i<array.Length; i++)
             {
                 if (array[i] % 2 == 0)
                 {
                     sum = sum + array[i];
                 }
             }
             Console.WriteLine(sum);*/

            //Find the average of prime element from an array
            int count = 0;
            int sum=0;
            int[] array = new int[7] {25,7,3,13,56,45,27};

            for(int i=0; i<array.Length; i++)
            {
                bool isPrime = true;
                for(int j = 2; j<i; j++)
                {
                    if(array[i]%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Console.WriteLine(array[i]);
                    sum = sum + array[i];
                    count++;
                }   
            }
            double avg = (double)(sum) / count;
            Console.WriteLine($"Average of Prime Numbers In Array Is: {avg} ");




            //Write code int type of array & display odd position of array.
            /*int[] array = new int[6];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Array Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                }
            }*/

            //Write Code To Display Alternate Elements from the array.
            /*int[] array = new int[6];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Array Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i=i+2)
            {
                Console.WriteLine(array[i]);
            }*/

            /*//Write code to display prime elements from an aaray.
            int[] array = new int[6];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Array Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < array[i]; j++)
                {
                    if (array[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(array[i]);
                }*/

            // WAP to accept rainfall for a week from the user & display the rainfall using an array.
            /* double[] rainfall =  new double[7];

             for(int i=0; i<rainfall.Length; i++)
             {
                 Console.WriteLine($"Enter Rainfall For day{i}");
                 rainfall[i] = Convert.ToDouble(Console.ReadLine());

             }
             for(int j=0; j<rainfall.Length; j++)
             {
                 Console.WriteLine($"Rain Fall For Day{j} is {rainfall[j]}");
             }*/

            //WAP to declare an array of 10 size, accept the value & print only even numbers.
            /*int[] evenarray = new int[10];
            for(int i = 0; i<evenarray.Length; i++)
            {
                Console.WriteLine($"Enter Number {i}");
                evenarray[i] = Convert.ToInt32(Console.ReadLine());
             }

            for(int j=0; j<evenarray.Length; j++)
            {
                if (evenarray[j]%2==0)
                {
                    Console.WriteLine($"Even Number {evenarray [j]}");
                }
            }*/

            //WAP to Print all the negative numbers from array. array count is 10 & print that negative element and also count
            /* int[] negnums = new int[10];
             for(int i = 0; i<negnums.Length; i++)
             {

                 negnums[i] = Convert.ToInt32(Console.ReadLine());
             }

             int count=0;
             for(int i = 0; i<negnums.Length; i++)
             {
                 if (negnums[i] < 0)
                 {
                     count++;
                     Console.WriteLine(negnums[i] + "Is a negativr number");

                 }
             }
             Console.WriteLine(count);*/


            // WAP to search for a given number in an array and accordingly print the index if exists.
            /*int[] array = new int[5];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter A Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter A Number To Be Search");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine($"{num} found at {i} Index");
                }
            }*/

            //WAP to search for a given number in an array and accordingly print the index if exists & if not then print not found
            /*int count = 0;
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter A Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter A Number To Be Search");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<array.Length; i++)
            {
                if (array[i] == num)
                {
                    count++;
                }
            }
            if(count>0)
            {
                Console.WriteLine($"{num} found in array");
            }
            else
            {
                Console.WriteLine($"{num} is not found in array");
            }*/


            //WAP to search for a even number in an array and accordingly print the index if exists
            /*int[] array = new int[10];

            for(int i = 0; i<array.Length; i++)
            {
                Console.WriteLine("Enter Array Numbers");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i<array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine($"Even Number Is {array[i]} with Index {i}");
                }
            }*/

            // WAP to find the maximum and minimum value in an array
            /* int[] array = new int[5];

             for(int i = 0; i < array.Length; i++)
             {
                 Console.WriteLine("Enter Array Number");
                 array[i] = Convert.ToInt32(Console.ReadLine());
             }

            int max = array[0];
            int min = array[0];
            for(int i =0; i<array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                else if (array[i]<min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"Max Number Is: {max}");
            Console.WriteLine($"Min Number Is: {min}");*/

            //WAP to put even and odd elements of array in two separate arrays.
            /*int[] array = new int[7];
            int[] evenarray = new int[7];
            int[] oddarray = new int[7];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Array Numbers");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenarray[i] = array[i];
                }
                else
                {
                    oddarray[i] = array[i];
                }
            }

            for (int i = 0; i < evenarray.Length; i++)
            {
                Console.WriteLine("Even Numbers" + evenarray[i]);

            }

            Console.WriteLine("------------------------------------");

            for (int i = 0; i < oddarray.Length; i++)
            {
                Console.WriteLine("Odd Numbers" + oddarray[i]);
            }*/

            //WAP to accept 5 names using 1D array and display using for loop
            /*string[] name = new string[5];

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Enter Name");
                name[i] = Console.ReadLine();
            }

            for(int i=0; i<name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }*/

            //WAP to find second the second smallest in an array
            /*int[] array = new int[5];

            for(int i = 0; i<array.Length; i++)
            {
                Console.WriteLine("Enter Array Numbers");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int small1 = array[0];
            int small2 = array[1];

            for(int i=0; i<array.Length; i++)
            {
                if (array[i] < small1)
                {
                    small2 = small1;
                    small1 = array[i];
                }
                if (array[i]>small1 && array[i]<small2)
                {
                    small2 = array[i];
                }
            }
            Console.WriteLine($"Second Smallest Number In Array Is: {small2}");*/

            //WAP to put even and odd elements of in two seperate arrays.
            /* int[] arr1 = new int[] { 77, 34, 59, 42, 99 };
             int[] arr2 = new int[5];
             int[] arr3 = new int[5];
             int i, j = 0, k = 0;
             for (i = 0; i < 5; i++) // 77,34
             {
                 if (arr1[i] % 2 == 0) //77%2-false; 34%2-true; 59%2-false; 42%2-true; 99%2-false;
                 {
                     arr2[j] = arr1[i]; // arr2[34,42]
                     j++;
                 }
                 else
                 {
                     arr3[k] = arr1[i]; // arr3[77,59,99]
                     k++;
                 }
             }
             Console.WriteLine("Even numbers...");
             for (i = 0; i < j; i++)
             {
                 Console.WriteLine(arr2[i]);
             }
             Console.WriteLine("Odd numbers...");
             for (i = 0; i < k; i++)
             {
                 Console.WriteLine(arr3[i]);
             }
            }*/

            //Write program to find frequency of each element in array
            /*int[] array = new int[10];

            for(int i = 0; i<array.Length; i++)
            {
                Console.WriteLine("Enter Array Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i<array.Length; i++)
            {
                int count = 1;
                bool flag = false;

                for(int k=i-1; k>=0;k--) 
                {
                    if (array[k] == array[i]) 
                    {
                        flag = true; 
                        break;
                    }
                }
                if(flag==false)
                {
                    for(int j=i+1;j<array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            count++;
                        }
                    }
                }
                if(count>1)
                {
                    Console.WriteLine($"Number={array[i]} Frequency={count}");
                }
            }*/

            //Write program to find and count total number of duplicates elements in an aray.
            /*int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Array Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
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
                            count++;
                        }
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine($"Duplicate Found {array[i]} : {count} Times");
                }
            }*/
            /*
                        //Write program to print all unique elements in array

                        int[] array = new int[10];

                        for(int i=0; i<array.Length; i++)
                        {
                            Console.WriteLine($"Enter Array Numbr of index {i}");
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        for(int i=0; i<array.Length; i++)
                        {
                            int count = 0;
                            for(int j=0; j<array.Length; j++)
                            {
                                if (array[j] == array[i])
                                {
                                    count++;
                                }   
                            }
                            if (count == 1)
                            {
                                Console.WriteLine($"{array[i]} is a unique element in array");
                            }
                        }*/

            //Write a program to sort array elements in ascending & descending orders.
            /*int[] arr = { 14, 28, 9, 75, 8 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
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

            /* WAP to replace all negative value with its immediate left elements square.
             Means arr[] = [12, 3, -19, 29, 5, -61, 44, 7, -9] 
             Output array will be[12, 3, 9, 29, 5, 25, 44, 7, 49].*/

            /* int[] array = new int[] { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
             int[] array1 = new int[] { -12, 3, -19, 29, 5, -61, 44, 7, -9 };

             int temp = array[1];
             if (array[0] < 0)
             {
                 array[0] = array[array.Length - 1] * array[array.Length - 1];
             }
             for (int i = 0; i < array.Length; i++)
             {

                 if (array[i] < 0)
                 {
                     array[i] = temp * temp;
                     temp = array[i];
                 }
                 else
                 {
                     temp = array[i];
                 }

             }
             for (int i = 0; i < array.Length; i++)
             {
                 Console.WriteLine(array[i]);
             }*/

            /**//*WAP to arrange the elements of an given array of integers
            where all negative integers appear before all the positive integers.*//*
            int[] array = new int[] { 1, 2, -3, -4, -5, 6, 7 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > 0)
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }*/



            /* Write a  program to test the equality of two arrays.
            Means e.g arr1[] = [12, 22, 32, 42, 52, 62] and arr2[] = [52, 22, 62, 12, 42, 22]
             Here both arrays are equal.*/

            /* WAP to reverse the array itself, don’t print array in reverse – I want current array reverse. 
             Means e.g.arr[] = [3, 90, 45, 29, 37, 78] so your same array must be [78, 37, 29, 45, 90, 3] 
             without using temporary array.*/
            /*int[] array = new int[] { 3, 90, 45, 29, 37, 78 };
            int last = array.Length - 1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[last];
                array[last] = temp;
                last--;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }*/

            //WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.




        }

    }


    }







    



