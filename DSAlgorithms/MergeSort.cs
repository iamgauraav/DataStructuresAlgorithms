using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class MergeSort
    {
        //si=starting index
        //ei=ending index
        public static void conquer(int[] arr, int si, int mid, int ei)
        {
            //created new array for merging 
            int[] merged = new int[ei - si + 1];
            //inserting element in new array
            int indx1 = si;
            int indx2 = mid + 1;
            //merged index which is staring from zero
            int x = 0;

            while (indx1 <= mid && indx2 <= ei)
            {
                //indx1 is having small element
                //indx2 is having bigger  element
                if (arr[indx1] <= arr[indx2])
                {
                    merged[x++] = arr[indx1++];
                }
                else
                {
                    merged[x++] = arr[indx2++];
                }
            }
            //If element remains in second array
            //they are sorted so just insert them as it is
            while (indx1 <= mid)
            {
                merged[x++] = arr[indx1++];
            }

            while(indx2 <= ei)
            {
                merged[x++] = arr[indx2++];
            }
            //copying merged array in original array
            for (int i = 0, j = si;  i < merged.Length; i++, j++)
            {
                arr[j] = merged[i];
            }
        }
        //in divide we need an array, si ,ei
        public static void divide(int[] arr, int si, int ei )
        {
            //is si >= ei it means we have got the values
            if (si >= ei)
            {
                return;
            }
            
            int mid = si + (ei - si) / 2;
            divide(arr, si, mid);
            divide(arr, mid + 1, ei);
            conquer(arr, si, mid, ei);
        }
        static void Main(string[] args)
        {
            int[] arr = { 76, 89, 23, 1, 55, 78, 99, 12, 65, 100 };
            //size of array
            int n = arr.Length;

            divide(arr, 0, n - 1);
            //print
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");

        }
    }
}