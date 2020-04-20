using System;

namespace ReverseString
{
    class Program
    {
        static void Main()
        {
            StringReversal s1 = new StringReversal();
            Console.Write("Enter a word: ");
            s1.SetWord(Console.ReadLine());
            Console.WriteLine(s1.GetWord());
            Console.WriteLine(s1.GetDrow());
        }
    }
}
