using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model.TextItems.SentenceItems
{
    internal interface ISentence : IEnumerable<ISentenceItem>
    {
        public IList<ISentenceItem> Items { get; }
        public void Remove(ISentenceItem item);
        public void Add(ISentenceItem item);
    }
}