using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SortingAlgorithms
{
    public class MergeSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort<T>(T[] array, int left, int right) where T : IComparable
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Sort<T>(array, left, middle);       
                Sort<T>(array, middle + 1, right);
                Merge<T>(array, left, middle, right);
            }
        }

        private static void Merge<T>(T[] array, int left, int middle, int right) where T : IComparable
        {
            T[] leftArray = new T[middle - left + 1];
            T[] rightArray = new T[right - middle];

            System.Array.Copy(array, left, leftArray, 0, middle - left + 1);
            System.Array.Copy(array, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++) 
            {
                if (i == leftArray.Length)
                {
                    array[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length) 
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i].CompareTo(rightArray[j]) < 0) 
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
            }
        }

        public static void Sort<T>(T[] array, Shared.SortDirection sortDirection = Shared.SortDirection.Ascending) where T : IComparable
        {
            Sort(array, 0, array.Length - 1, sortDirection);
        }
        private static void Sort<T>(T[] array, int left, int right, Shared.SortDirection sortDirection = Shared.SortDirection.Ascending) where T : IComparable
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Sort<T>(array, left, middle, sortDirection);
                Sort<T>(array, middle + 1, right, sortDirection);
                Merge<T>(array, left, middle, right, sortDirection);
            }
        }

        private static void Merge<T>(T[] array, int left, int middle, int right, Shared.SortDirection sortDirection = Shared.SortDirection.Ascending) where T : IComparable
        {
            var comparer = new DataStructures.Shared.CustomComparer<T>(sortDirection, Comparer<T>.Default);
            T[] leftArray = new T[middle - left + 1];
            T[] rightArray = new T[right - middle];

            System.Array.Copy(array, left, leftArray, 0, middle - left + 1);
            System.Array.Copy(array, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++) 
            {
                if (i == leftArray.Length) 
                {
                    array[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else if (comparer.Compare(leftArray[i], rightArray[j]) < 0) 
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
            }
        }
    }
}
