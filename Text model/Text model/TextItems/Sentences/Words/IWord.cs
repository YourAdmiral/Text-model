using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model
{
    internal interface IWord : ISentenceItem, IEnumerable<Symbol>
    {
        public int Length { get; }
        public Symbol this[int index] { get; }
        public Symbol[] Symbols { get; }
    }
}