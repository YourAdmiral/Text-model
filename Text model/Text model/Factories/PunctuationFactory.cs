using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model
{
    internal class PunctuationFactory : ISentenceItemFactory
    {
        public ISentenceItem Create(string chars)
        {
            return new Punctuation(chars);
        }
    }
}