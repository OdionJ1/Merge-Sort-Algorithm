using System;

namespace CP
{
    public static class MergeSort
    {
        //Sorts the the elements of array a in ascending order.
        public static void Sort(int[] arr)  //C
        {
            //first index of arr
            int low = 0;

            //last index of arr
            int high = arr.Length;

            //invokes the Sort2 method, passing in the whole range of the array to be sorted
            Sort(arr, low, high);
        }
        
        //Sorts the elements in a[low] through a[high] including a[low]
        // but excluding a[high] in ascending order.
        public static void Sort(int[] arr, int low, int high)  //C
        {
            //Recursively calculates the middle of the low and high indexes
            if (low < high - 1)
            {
                int middle = (low + high) / 2;
                Sort(arr, low, middle);
                Sort(arr, middle, high);
                Merge(arr, low, middle, high);
            }
        }       

        //Assumes the elements in the range [a[low], a[mid]) and the range
        // [a[mid], a[high]) are in ascending order. The method merges the
        // two ranges so that the elements in the range [a[low], a[high])
        // are in ascending order.
        private static void Merge(int[] arr, int low, int middle, int high)  //C
        {

            int i; //created variable 'i' to keep track of my current postion in the left array
            int m; //created variable 'm' to keep track of my current postion in the right array
            int c; //created variable 'c' to keep track of my current postion in the main array

            //Based on the low, middle and high values passed in, the size of the left array and right array is calculated
            //and stored in variables
            int leftLength = middle - low;
            int rightLength = high - middle;


            //Empty left and right arrays are created utilizing the calculated sizes above
            int[] leftArr = new int[leftLength];
            int[] rightArr = new int[rightLength];

            //The left array is filled appropriately with the elements from the main array
            for (i = 0; i < leftLength; i++)
            {
                leftArr[i] = arr[low + i];
            }

            //The right array is filled appropriately with the elements from the main array,
            for (i = 0; i < rightLength; i++)
            {
                rightArr[i] = arr[middle + i];
            }

            i = 0; m = 0; c = low;

            //The while loop iterately compares the elements in the left and right arrays,
            //and inserts the values in a sorted order back in the main array at the appropriate
            //indexes
            while (i < leftLength && m < rightLength)
            {
                if (leftArr[i] <= rightArr[m])
                {
                    arr[c] = leftArr[i];
                    c++;
                    i++;
                }
                else
                {
                    arr[c] = rightArr[m];
                    c++;
                    m++;
                }
            }

            //If the while loop has successfully inserted all the elements in the left array into the main array,
            //the remaining element in the right array gets inserted next into the main array
            if (i == leftLength)
            {
                for (int ii = m; ii < rightLength; ii++)
                {
                    arr[c++] = rightArr[ii];
                }
            }

            //If the while loop has successfully inserted all the elements in the right array into the main array,
            //the remaining element in the left array gets inserted next into the main array
            if (m == rightLength)
            {
                for (int ii = i; ii < leftLength; ii++)
                {
                    arr[c++] = leftArr[ii];
                }
            }
        }
    }
}