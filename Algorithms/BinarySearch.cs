using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    static class Search
    {
        // Linear search method
        public static int FindIndexByLinearSearch(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == element) return i;
            return -1;
        }

        // Binary search method
        public static int FindIndexByBinarySearch(int[] array, int element)
        {
            // Set the left boundary.
            int left = 0;

            // Set the rigth boundary.
            int right = array.Length - 1;
            while (left < right)
            {
                // Find the middle of the interval.
                int middle = (right + left) / 2;

                if (element <= array[right]) right = middle;
                else left = middle + 1;
            }
            if (array[right] == element)
                return right;
            else return -1;
        }

    }
}
