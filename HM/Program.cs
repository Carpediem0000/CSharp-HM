using System;


namespace HM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] str = new char[] { 'M', 'y', ' ', 'f', 'r', 'i', 'e', 'n', 'd', ' ', 'w', 'i', 't', 'h', ' ', 'h', 'i' };
            MyString str1 = new MyString(str);
            str1.Replace(new char[] { 'h', 'i' }, new char[] {'H','e','l','l','o'});

            //char[] chars;
            //chars = new char[] { 'A', 'B', 'C'};
            //chars.
            //Console.WriteLine(chars);
            Console.ReadLine();
        }
    }
}
