using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAlgorithms
{
    public class Anagram
    {
        static void Main(string[] args)
        {
            //taking user input
            Console.WriteLine("Enter First string");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter Second string");
            string s2 = Console.ReadLine();

            //Store the string in the char array after converting to lower case
            char[] a1 = s1.ToLower().ToCharArray();
            char[] a2 = s2.ToLower().ToCharArray();

            //Sort the characters in the char array
            Array.Sort(a1);
            Array.Sort(a2);

            //reating object of string by passing the char array to it
            string res1 = new string(a1);
            string res2 = new string(a2);

            //Condition to check if strings are anagram or not
            if (res1 == res2)
            {
                Console.WriteLine("Strings are anagram");
            }
            else
            {
                Console.WriteLine("Strings are not anagram");
            }

        }
    }
}
