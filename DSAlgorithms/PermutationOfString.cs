using System;

namespace DSAlgorithms
{
    class Program
    {
        public static void permute(string str, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(str);
            }
            else
            {
                //from l --> r
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r); //Find combination
                    str = swap(str, l, i); //backtrack
                }
            }
        }
        public static string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
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
