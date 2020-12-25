using System;
using System.Collections.Generic;
using System.Text;
using Text_model.TextItems.SentenceItems;

namespace Text_model.TextItems
{
    internal interface IText : IEnumerable<ISentence>
    {
        public IList<ISentence> Sentences { get; }
        public void DeleteWords(int length);
        public void AddSentence(ISentence sentence);
        public void AddSentences(ICollection<ISentence> sentences);
    }
}