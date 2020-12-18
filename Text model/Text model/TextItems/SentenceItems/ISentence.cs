using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model
{
    internal interface ISentence : IEnumerable<ISentenceItem>
    {
        public IList<ISentenceItem> Items { get; }
        public void Remove(ISentenceItem item);
        public int Count { get; }
        public void Add(ISentenceItem item);
        public string SentenceToString();
        public void ReplaceWords(int length, string word);
    }
}