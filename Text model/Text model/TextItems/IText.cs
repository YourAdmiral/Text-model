using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model
{
    internal interface IText : IEnumerable<ISentence>
    {
        public ICollection<ISentence> Sentences { get; }
        public void AddSentence(ISentence sentence);
        public void AddSentences(ICollection<ISentence> sentences);
    }
}