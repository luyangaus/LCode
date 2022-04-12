using LCode.Sort;
using System;
using Xunit;

namespace LCodeUnitTests
{
    public class InsertSortUnitTests
    {
        [Fact]
        public void InsertSortWithArray_RandomOrder()
        {
            InsertSort sort = new InsertSort();
            int[] array = new int[] { 1, 3, 2, 0 };
            int[] expected = new int[] { 0, 1, 2, 3 };
            array = sort.InsertSortWithArray(array);

            Assert.Equal(expected, array);
        }

        [Fact]
        public void InsertSortWithArray_ReverseOrder()
        {
            InsertSort sort = new InsertSort();
            int[] array = new int[] { 3, 2, 4 };
            int[] expected = new int[] { 2, 3, 4 };
            array = sort.InsertSortWithArray(array);

            Assert.Equal(expected, array);
        }

        [Fact]
        public void InsertSortWithArray_OneItem()
        {
            InsertSort sort = new InsertSort();
            int[] array = new int[] { 0 };
            int[] expected = new int[] { 0 };
            array = sort.InsertSortWithArray(array);

            Assert.Equal(expected, array);
        }
    }
}
