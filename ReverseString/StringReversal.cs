using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class StringReversal
    {
        private string ForwardWord;
        private string BackwardsWord;

        public void SetWord(string word) 
        {
            ForwardWord = word;
            word = string.Concat(word);
            BackwardsWord = "";
            for (int i = word.Length - 1; i >= 0; i--) 
            {
                BackwardsWord += word[i];
            }
        }
        public string GetWord() 
        {
            return ForwardWord;
        }
        public string GetDrow() 
        {
            return BackwardsWord;
        }
    }
}
