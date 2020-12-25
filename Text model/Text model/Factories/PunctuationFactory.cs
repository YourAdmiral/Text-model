using System;
using System.Collections.Generic;
using System.Text;
using Text_model.TextItems.SentenceItems;
using Text_model.TextItems.SentenceItems.Punctuations;

namespace Text_model.Factories
{
    internal class PunctuationFactory : ISentenceItemFactory
    {
        public ISentenceItem Create(string chars)
        {
            return new Punctuation(chars);
        }
    }
}