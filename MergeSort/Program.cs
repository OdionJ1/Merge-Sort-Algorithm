using System;

namespace CP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--------------Testing MergeSort--------------");

            //------------- Sorting between 2 indexes  ---------------------
            int[] array1 = { 300, -45, 5, 2, -7, 1, 13, -25, 19, 30, 25, 250 };
            Console.Write("Array is : "); WriteArray(array1); Console.WriteLine();
            Console.WriteLine("Sorting array between indexes 2 and 10 ...");
            MergeSort.Sort(array1, 2, 10); // Sort array between index 2 and index 10
            Console.Write("Would write 300 -45 -25 -7 1 2 5 13 19 30 25 250: "); WriteArray(array1);
            Console.WriteLine();

            //------------- Sorting the whole array  ---------------------
            int[] array2 = { 300, -45, 5, 2, -7, 1, 13, -25, 19, 30, 25, 250 };
            Console.Write("Array is : "); WriteArray(array2); Console.WriteLine();
            Console.WriteLine("Sorting the whole array ...");
            MergeSort.Sort(array2); // Sort the whole array
            Console.Write("Would write -45 -25 -7 1 2 5 13 19 25 30 250 300: "); WriteArray(array2);

            Console.WriteLine();
        }

        static void WriteArray(int[] a)
        {
            for (int i = 0 ; i < a.Length ; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}
