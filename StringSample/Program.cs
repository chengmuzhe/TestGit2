using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string emptyString = string.Empty;
            string firstString = "abcdef";
            string secondString = "I Love You";
            Console.WriteLine("使用Chars");
            char ch = firstString[3];
            Console.WriteLine(ch);

            Console.WriteLine("使用Length");
            Console.WriteLine(firstString.Length);

            Console.WriteLine("使用Concat:连接");
            string thirdstring = string.Concat(firstString, secondString);
            Console.WriteLine(thirdstring);

            Console.WriteLine("使用EndsWith");
            bool endwith = thirdstring.EndsWith("You");
            Console.WriteLine(endwith);

            Console.WriteLine("使用StartsWith");
            bool startwith = thirdstring.StartsWith("You");
            Console.WriteLine(startwith);

            string fourString = thirdstring.Substring(0, 3);
            Console.WriteLine(fourString);

            char[] chars = secondString.ToCharArray();
            foreach (char a in chars)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("使用ToLower");
            Console.WriteLine(secondString.ToLower());
            Console.WriteLine("使用ToUpper");
            Console.WriteLine(secondString.ToUpper());

            string fiveString = "  ABC   ";
            Console.WriteLine(fiveString.Trim());
            Console.WriteLine(fiveString.TrimEnd());
            Console.WriteLine(fiveString.TrimStart());

            string[] spliterString = secondString.Split(' ');
            for (int i = 0; i < spliterString.Length; i++)
            {
                Console.WriteLine(spliterString[i]);
            }

            string words = "this is a list of words, with: a.bit of puncation";

            string [] split = words.Split(new char[] {' ',',','.',':'});

            foreach (string  item in split)
            {
                if (item.Trim() != "")
                {
                    Console.WriteLine(item);
                }

            }

            string joinString = string.Join("-", split);
            Console.WriteLine(joinString);

            string s1 = "abcdb";
            string s2 = "";
            string s3 = null;

            if (String.IsNullOrEmpty(s1) == true)
            {
                Console.WriteLine("is null or empty");
            }
            else
            {
                Console.WriteLine(string.Format("(\"{0}\") is not null or empty",s1));

            }


            if (String.IsNullOrEmpty(s2) == true)
            {
                Console.WriteLine("is null or empty");
            }
            else
            {
                Console.WriteLine(string.Format("(\"{0}\") is not null or empty", s2));

            }

            if (String.IsNullOrEmpty(s3) == true)
            {
                Console.WriteLine("is null or empty");
            }
            else
            {
                Console.WriteLine(string.Format("(\"{0}\") is not null or empty", s3));

            }

            int indexb = s1.IndexOf("b");
            Console.WriteLine("使用IndexOf:");
            Console.WriteLine(indexb);

            int index1 = s1.LastIndexOf("b");
            Console.WriteLine("使用LastIndexOf");
            Console.WriteLine(index1);

            string insertstring = s1.Insert(2, "e");
            Console.WriteLine("使用Insert:");
            Console.WriteLine(insertstring);

            string one = "abcd";
            string two = "abcd";
            Console.WriteLine("使用op_Equality ==:");
            Console.WriteLine("\"{0}\" == \"{1}\" ? {2}",one,two,one == two);

            string one1 = "abcd";
            string two1 = "abcd";
            Console.WriteLine("使用op-Equality !=:");
            Console.WriteLine("\"{0}\" != \"{1}\" ? {2}", one1, two1, one1 == two1);

            Console.ReadLine();
        }
    }
}
