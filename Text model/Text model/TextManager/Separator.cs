using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_model
{
    internal class Separator
    {
        private string[] _sentenceSeparators = new string[] { "?", "!", ".", "...", "?!", "!?" };
        private string[] _wordSeparators = new string[] { " ", " - " };
        private string[] _allSeparators = new string[] { 
            "?", "!", ".", "...", "?!", "!?", ",", ":", ";", "'", " ", " - ",
            "(", ")", "[", "]", "{", "}", "<", ">",  
            "*", "/", "\"", "-", "+", ">=", "=<", "=", "==", "!=" 
        };
        public IEnumerable<string> SentenceSeparators()
        {
            return _sentenceSeparators.AsEnumerable();
        }
        public IEnumerable<string> WordSeparators()
        {
            return _wordSeparators.AsEnumerable();
        }
        public IEnumerable<string> All()
        {
            return _allSeparators.AsEnumerable();
        }
    }
}