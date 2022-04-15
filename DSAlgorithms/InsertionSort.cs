using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithms
{
    public class InsertionSort
    {
        public static void InsertionSortList(string[] list)
        {
            for (int i = 1; i < list.Count(); i++)
            {
                string word = list[i];
                int j = i - 1;

                while (j >= 0 && list[j].CompareTo(word) > 0)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = word;
            }
            Console.WriteLine("The sorted array is: ");

        }
        
        static void Main(string[] args)
        {
            string[] list = { "beans", "apple", "orange", "pineapple", "mango" };
            InsertionSortList(list);
            foreach (var element in list)
            {
                Console.WriteLine(element + "\n");
            }
        }
    }
}
