using System;
using System.Collections.Generic;
using System.Text;
using Text_model.TextItems.SentenceItems.Symbols;

namespace Text_model.TextItems.SentenceItems.Punctuations
{
    internal class Punctuation : IPunctuation
    {
        public Symbol Symbol { get; private set; }
        public Punctuation(string chars)
        {
            Value = chars;
        }
        public string Value
        {
            get { return Symbol.Chars; }
            set { Symbol = new Symbol(value); }
        }
    }
}