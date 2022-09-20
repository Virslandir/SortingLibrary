using System;
using System.Collections.Generic;
using System.Text;
using SortingLibrary;
using Xunit;

namespace SortingLibrarty.Tests
{
    public class ArraySortingTests
    {
        [Fact]
        public void BubbleSortDescendingShouldReturnSortedArray()
        {
            // arrange
            int[] actual = ArraySorting.BubbleSortDescending(new int[]{ 7, 8});
            // act
            int[] expected = {8,7};

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BubbleSortAscendingShouldReturnSortedArray()
        {
            // arrange
            int[] actual = ArraySorting.BubbleSortAscending(new int[] { 6, 5 });
            // act
            int[] expected = { 5,6};

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SelectionSortDescendingShouldReturnSortedArray()
        {
            //arrange
            int[] expected = { 1, 2};

            //act
            int[] actual = ArraySorting.SelectionSortDescending(new int[] { 2, 1 });

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SelectionSortAscendingShouldReturnSortedArray()
        {
            //arrange
            int[] expected = { 5,4,3,2,1 };

            //act
            int[] actual = ArraySorting.SelectionSortAscending(new int[] { 1,2,3,4,5});

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
