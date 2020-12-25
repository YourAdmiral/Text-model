using System;
using System.Collections.Generic;
using System.Text;
using Text_model.TextItems.SentenceItems.Symbols;

namespace Text_model.TextItems.SentenceItems.Punctuations
{
    internal interface IPunctuation : ISentenceItem
    {
        public Symbol Symbol { get; }
    }
}