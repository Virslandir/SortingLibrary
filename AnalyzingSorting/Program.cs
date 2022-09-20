using SortingLibrary;
using System;
using System.Collections.Generic;
using System.IO;

namespace AnalyzingSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            do
            {
                Console.WriteLine("Input array length:");
                int arrayLength = Convert.ToInt32(Console.ReadLine());

                int[] testArray = (int[])CreateRandomArray(random, arrayLength);

                var watch1 = System.Diagnostics.Stopwatch.StartNew();
                int[] sortedArray = ArraySorting.SelectionSortDescending(testArray);
                watch1.Stop();
                var elapsedMsSelectionSort = watch1.ElapsedMilliseconds;

                var watch2 = System.Diagnostics.Stopwatch.StartNew();
                sortedArray = ArraySorting.BubbleSortDescending(testArray);
                watch2.Stop();
                var elapsedMsBubbleSort = watch2.ElapsedMilliseconds;

                var watch3 = System.Diagnostics.Stopwatch.StartNew();
                Array.Sort(testArray);
                watch3.Stop();
                var elapsedMsArraySort = watch3.ElapsedMilliseconds;

                Console.WriteLine($"The running time of SELECTION SORT for {arrayLength} elements was {elapsedMsSelectionSort}ms");
                Console.WriteLine($"The running time of BUBBLE SORT for {arrayLength} elements was {elapsedMsBubbleSort}ms");
                Console.WriteLine($"The running time of Array.Sort for {arrayLength} elements was {elapsedMsArraySort}ms");

                string textRow = $"{arrayLength},0,0,{elapsedMsArraySort},\n";

                File.AppendAllText(@"C:\Users\sspir\source\repos\SortingLibrary\TimeOfSorts.txt", textRow);

            } while (true);

            Console.ReadLine();
        }

        private static Array CreateRandomArray(Random random, int length)
        {
            var testArray = Array.CreateInstance(typeof(int), length);
            for (int i = 0; i < testArray.Length; i++)
            {
                testArray.SetValue(random.Next(100), i);
            }

            return testArray;
        }
    }
}
