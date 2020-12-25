using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Text_model.TextItems.SentenceItems.Symbols;

namespace Text_model.TextItems.SentenceItems.Words
{
    internal class Word : IWord
    {
        public Symbol[] Symbols { get; private set; }
        public Symbol this[int index]
        {
            get { return Symbols[index]; }
        }
        public Word(string chars)
        {
            Symbols = chars != null ? chars.Select(x => new Symbol(x)).ToArray() : null;
        }
        public string Value
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var s in Symbols)
                {
                    sb.Append(s.Chars);
                }
                return sb.ToString();
            }
            set
            {
                Symbols = value != null ? value.Select(x => new Symbol(x)).ToArray() : null;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Word word = (Word)obj;
            return (this.Value == word.Value);
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        public IEnumerator<Symbol> GetEnumerator()
        {
            return Symbols.AsEnumerable().GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Symbols.GetEnumerator();
        }
    }
}