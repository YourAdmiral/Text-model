using System;
using System.Collections.Generic;
using System.Text;
using Text_model.TextItems.SentenceItems;
using Text_model.TextItems.SentenceItems.Words;

namespace Text_model.Factories
{
    internal class WordFactory : ISentenceItemFactory
    {
        public ISentenceItem Create(string chars)
        {
            return new Word(chars);
        }
    }
}