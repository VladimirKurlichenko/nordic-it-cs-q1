using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            int[] array = new int[10000];
            var rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
            }

            int[] array2 = new int[10000];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array[i];
            }


            stopWatch.Start();
            BubbleSort(array);
            stopWatch.Stop();

            Console.WriteLine($"Time Bubble Sort: {stopWatch.ElapsedMilliseconds}\n");
 

            stopWatch.Reset();

            stopWatch.Start();
            Array.Sort(array2, (x, y) => x.CompareTo(y));
            stopWatch.Stop();
            Console.WriteLine($"Time Array Sort: {stopWatch.ElapsedMilliseconds}");
        }

        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var limit = array.Length - 1 - i;

                for (int j = 0; j < limit; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var tamp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tamp;
                    }
                }
            }
        }
    }
}
