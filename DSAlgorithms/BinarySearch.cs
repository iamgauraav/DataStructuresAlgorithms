using System;

namespace DSAlgorithms
{
    class BinarySearch
    {
        public static int BinarySearchWord(string[] arr, string searchItem)
        {
            //Declare local variable
            int start = 0;
            //Initializing end as list.Length-1 means as array index start from 0 
            int end = arr.Length - 1;
            

            while (start <= end)
            {
                //Initialize mid position of array
                int mid = (start + end) / 2;
                //declaring a variable res, and use CompareTo method to check between input and array words
                //Tolower() method to convert the string to lower case 
                int res = searchItem.ToLower().CompareTo(arr[mid]);

                if (res == 0)
                {
                    return mid;
                }
                if(res > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            string[] arr = { "apple", "banana", "mango", "carrot", "watermelon" };
            string searchItem = "mumu";
            int result = BinarySearchWord(arr, searchItem);

            if (result == -1)
            {
                Console.WriteLine("Element not found");
            }
            else
            {
                Console.WriteLine($"{searchItem} is  found at index: {result}");
            }
        }
    }
}
