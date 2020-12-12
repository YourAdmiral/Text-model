using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model
{
    internal struct Symbol
    {
        private string _chars;
        public string Chars
        {
            get { return _chars; }
            private set { _chars = value; }
        }
        public Symbol(string chars)
        {
            _chars = chars;
        }
        public Symbol(char source)
        {
            _chars = String.Format("{0}", source);
        }
        public bool IsUppercase
        {
            get { return _chars != null && _chars.Length >= 1 && char.IsLetter(_chars[0]) && char.IsUpper(_chars[0]); }
        }
        public bool IsLower
        {
            get { return _chars != null && _chars.Length >= 1 && char.IsLetter(_chars[0]) && char.IsLower(_chars[0]); }
        }
    }
}