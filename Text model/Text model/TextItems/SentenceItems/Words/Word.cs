using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Text_model
{
    internal class Word : IWord
    {
        public int Length { get; private set; }
        public Symbol[] Symbols { get; private set; }
        public string Chars
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
                Length = Symbols.Length != 0 ? Symbols.Length : 0;
            }
        }
        public Symbol this[int index]
        {
            get { return Symbols[index]; }
        }
        public Word(string chars)
        {
            Symbols = chars != null ? chars.Select(x => new Symbol(x)).ToArray() : null;
            Length = Symbols.Length != 0 ? Symbols.Length : 0;
        }
        public IEnumerator<Symbol> GetEnumerator()
        {
            return Symbols.AsEnumerable().GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Symbols.GetEnumerator();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Word word = (Word)obj;
            return (this.Chars == word.Chars);
        }
        public override int GetHashCode()
        {
            return Chars.GetHashCode();
        }
    }
}