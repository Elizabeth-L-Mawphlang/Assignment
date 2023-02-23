using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
           // p.Q1();
            p.Q2();
            //p.sort();
            Console.ReadLine();

        }


        public void Q1()
        {
            int[] arr1 = new int[100];
            int i, max, min, n;
            float sum = 0, avg = 0;


            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element  {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = arr1[0];
            min = arr1[0];
            for (i = 1; i < n; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }


                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }


            for (i = 0; i < n; i++)
            {
                sum += arr1[i];
            }
            avg = sum / n;
            Console.Write("Maximum element is : {0}\n", max);
            Console.Write("\n Minimum element is : {0}\n\n", min);
            Console.Write("\nSum {0}  ", sum);
            Console.Write("\nAverage {0} ", avg);
        }

        public void Q2()
        {
            int[] arr1 = new int[50];
            int i, max, min;
            float sum = 0, avg = 0;


            Console.Write("Enter the 10 Marks:\n");
            for (i = 0; i <= 10; i++)
            {
                Console.Write("Mark {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            max = arr1[0];
            min = arr1[0];


            for (i = 1; i <= 10; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }


            for (i = 0; i <= 10; i++)
            {
                sum += arr1[i];
            }
            avg = sum / 10;


            Console.Write("Maximum Marks is : {0}\n", max);
            Console.Write("Minimum Marks  is : {0}\n\n", min);
            Console.Write("Sum  of Marks {0} \n ", sum);
            Console.Write("Average of Marks  {0} \n ", avg);

            Array.Sort(arr1);
            Console.WriteLine("Ascending :\n ");

            foreach (int value in arr1)
            {
                Console.Write(value + " ");
            }

            Array.Reverse(arr1);
            Console.WriteLine("\nDecending :");

            foreach (int value in arr1)
            {
                Console.Write(value + " ");
            }

        }
    }
}
