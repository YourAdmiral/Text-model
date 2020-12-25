using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model.TextItems.SentenceItems.Symbols
{
    internal struct Symbol
    {
        public string Chars { get; private set; }
        public Symbol(string chars)
        {
            Chars = chars;
        }
        public Symbol(char source)
        {
            Chars = String.Format("{0}", source);
        }
        public bool IsUpperCase => Chars != null && Chars.Length >= 1 && char.IsLetter(Chars[0]) && char.IsUpper(Chars[0]);
        public bool IsLower => Chars != null && Chars.Length >= 1 && char.IsLetter(Chars[0]) && char.IsLower(Chars[0]);
    }
}