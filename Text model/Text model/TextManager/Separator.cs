using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_model
{
    internal class Separator
    {
        private string[] _sentence = new string[] { "?", "!", ".", "...", "?!", "!?" };
        private string[] _word = new string[] { " ", " - ", ",", ";", ":" };
        private string[] _open = new string[] { "(", "[", "{", "<", "«" };
        private string[] _close = new string[] { ")", "]", "}", ">", "»" };
        private string[] _quotes = new string[] { "\"", "'" };
        private string[] _math = new string[] { "*", "/", "-", "+", ">=", "=<", "=", "==", "!=" };
        private string[] _all = new string[] { 
            "?", "!", ".", "...", "?!", "!?", ",", ":", ";", "'", " ", " - ",
            "(", ")", "[", "]", "{", "}", "<", ">",  
            "*", "/", "\"", "-", "+", ">=", "=<", "=", "==", "!=" 
        };
        public IEnumerable<string> SentenceSeparators()
        {
            return _sentence.AsEnumerable();
        }
        public IEnumerable<string> WordSeparators()
        {
            return _word.AsEnumerable();
        }
        public IEnumerable<string> OpenSeparators()
        {
            return _open.AsEnumerable();
        }
        public IEnumerable<string> CloseSeparators()
        {
            return _close.AsEnumerable();
        }
        public IEnumerable<string> QuotesSeparators()
        {
            return _quotes.AsEnumerable();
        }
        public IEnumerable<string> MathSeparators()
        {
            return _math.AsEnumerable();
        }
        public IEnumerable<string> AllSeparators()
        {
            return _all.AsEnumerable();
        }
    }
}