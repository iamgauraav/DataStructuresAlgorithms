using System;

namespace DSAlgorithms
{
    class Program
    {
        public static void permute (string str, int l, int r)
        {
            /* Function to print permutations of string 
            This function takes three parameters: 
            1. String 
            2. Starting index of the string 
            3. Ending index of the string. */

            //If string has one char than we will return that one only 
            if (l == r)
            {
                Console.WriteLine(str);
            }
            else
            {
                //from l=left, r-right
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i); //swapping A-A as l=0,i=0
                    permute(str, l + 1, r); //calling recursive function, finding combination
                    str = swap(str, l, i); //backtracking
                }
            }
        }
        public static string swap(string a, int i, int j)
        {
            //swapping temp -> charArray[i] ->charArray[i] -> charArray[j] -> temp
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            // new object 
            string s = new string(charArray);
            return s;
        }
        static void Main(string[] args)
        {
            string str = "ABC";
            int n = str.Length;
            permute(str, 0, n - 1);
        }
    }
}
