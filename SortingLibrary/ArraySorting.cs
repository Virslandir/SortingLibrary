using System;
using System.Collections.Generic;
using System.Text;

namespace SortingLibrary
{
    public static class ArraySorting
    {
        public static int[] BubbleSortDescending(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length-1; i++)
            {
                for (int j = 0; j < (inputArray.Length-1-i); j++)
                {
                    if (inputArray[j] < inputArray[j+1])
                    {
                        Array.Reverse(inputArray, j, 2);
                    }
                }
            }

            return inputArray;
        }
        public static int[] BubbleSortAscending(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = 0; j < (inputArray.Length - 1 - i); j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        Array.Reverse(inputArray, j, 2);
                    }
                }
            }
            return inputArray;
        }

        public static int[] SelectionSortDescending(int[] inputArray)
        {
            int lastIndex = inputArray.Length - 1;
            int minValue;

            for (int i = 0; i < lastIndex; i++)
            {
                minValue = i;
                for (int j = i+1; j <= lastIndex; j++)
                {
                    if (inputArray[minValue] > inputArray[j])
                    {
                        minValue = j;
                    }

                    int tempVariable = inputArray[minValue];
                    inputArray[minValue] = inputArray[i];
                    inputArray[i] = tempVariable;
                }
            }

            return inputArray;
        }

        public static int[] SelectionSortAscending(int[] inputArray)
        {
            int lastIndex = inputArray.Length - 1;
            int minValue;

            for (int i = 0; i < lastIndex; i++)
            {
                minValue = i;
                for (int j = i + 1; j <= lastIndex; j++)
                {
                    if (inputArray[minValue] < inputArray[j])
                    {
                        minValue = j;
                    }

                    int tempVariable = inputArray[minValue];
                    inputArray[minValue] = inputArray[i];
                    inputArray[i] = tempVariable;
                }
            }

            return inputArray;
        }


    }
}
