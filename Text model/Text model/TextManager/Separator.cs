using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_model
{
    internal class Separator
    {
        private static string[] _sentence = new string[] { "?", "!", ".", "...", "?!", "!?" };
        private static string[] _word = new string[] { " ", " - ", ",", ";", ":" };
        private static string[] _open = new string[] { "(", "[", "{", "<", "«" };
        private static string[] _close = new string[] { ")", "]", "}", ">", "»" };
        private static string[] _quotes = new string[] { "\"", "'" };
        private static string[] _math = new string[] { "*", "/", "-", "+", ">=", "=<", "=", "==", "!=" };
        private static string[] _all = new string[] { 
            "?", "!", ".", "...", "?!", "!?", ",", ":", ";", "'", " ", " - ",
            "(", ")", "[", "]", "{", "}", "<", ">",  
            "*", "/", "\"", "-", "+", ">=", "=<", "=", "==", "!=" 
        };
        public static IEnumerable<string> SentenceSeparators()
        {
            return _sentence.AsEnumerable();
        }
        public static IEnumerable<string> WordSeparators()
        {
            return _word.AsEnumerable();
        }
        public static IEnumerable<string> OpenSeparators()
        {
            return _open.AsEnumerable();
        }
        public static IEnumerable<string> CloseSeparators()
        {
            return _close.AsEnumerable();
        }
        public static IEnumerable<string> QuotesSeparators()
        {
            return _quotes.AsEnumerable();
        }
        public static IEnumerable<string> MathSeparators()
        {
            return _math.AsEnumerable();
        }
        public static IEnumerable<string> AllSeparators()
        {
            return _all.AsEnumerable();
        }
    }
}