using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model
{
    internal interface IText : IEnumerable<ISentence>
    {
        public IList<ISentence> Sentences { get; }
        public IEnumerable<ISentence> GetOrderSentences();
        public IEnumerable<ISentenceItem> GetWordsFromQuestions(int length);
        public string TextToString();
        public void DeleteWords(int length);
        public void AddSentence(ISentence sentence);
        public void AddSentences(ICollection<ISentence> sentences);
    }
}