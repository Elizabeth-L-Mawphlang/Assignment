using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.strlen();
            p.strrev();
            p.strcompare();
            Console.ReadLine();
        }
        public void strlen()
        {
            string str;
            int l = 0;

            Console.Write("\n C# to accept a word from the user and display the length :\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }
            Console.Write("Length of the string is : {0}\n\n", l);
        }

        public void strrev()
        {
            string Str, rev = "";
            int Length;
            Console.Write("\n C# to accept a word from the user and reverse the length :\n");
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                rev = rev + Str[Length];
                Length--;
            }
            Console.WriteLine("Reverse  String::  {0} \t", rev);
            Console.ReadLine();
        }

        public void strcompare()
        {
            string str1, str2;
            Console.Write("\n C# to accept two words from user and find out if they are same:\n");
            Console.WriteLine("Enter the First word");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter the Another word");
            str2 = Console.ReadLine();
            if (str1 == str2)
            {
                Console.WriteLine("Same word");
            }
            else
                Console.WriteLine("Not Same");
        }





    }
}
