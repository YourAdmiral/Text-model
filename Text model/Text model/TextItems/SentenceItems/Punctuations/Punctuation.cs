using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model
{
    internal class Punctuation : IPunctuation
    {
        private Symbol _value;
        public Symbol Value
        {
            get { return _value; }
        }
        public string Chars
        {
            get { return Value.Chars; }
            set { _value = new Symbol(value); }
        }
        public Punctuation(string chars)
        {
            _value = new Symbol(chars);
        }
    }
}