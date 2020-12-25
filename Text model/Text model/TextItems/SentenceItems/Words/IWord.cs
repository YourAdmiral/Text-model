using System;
using System.Collections.Generic;
using System.Text;
using Text_model.TextItems.SentenceItems.Symbols;

namespace Text_model.TextItems.SentenceItems.Words
{
    internal interface IWord : ISentenceItem, IEnumerable<Symbol>
    {
        public Symbol this[int index] { get; }
        public Symbol[] Symbols { get; }
    }
}