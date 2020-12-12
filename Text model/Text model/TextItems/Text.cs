using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_model
{
    internal class Text : IText
    {
        public ICollection<ISentence> Sentences { get; private set; }
        public Text()
        {
            Sentences = new List<ISentence>();
        }
        public Text(ICollection<ISentence> sentences)
        {
            Sentences = sentences;
        }
        public void AddSentence(ISentence sentence)
        {
            Sentences.Add(sentence);
        }
        public void AddSentences(ICollection<ISentence> sentences)
        {
            foreach (var sentence in sentences)
            {
                AddSentence(sentence);
            }
        }
        public IEnumerator<ISentence> GetEnumerator()
        {
            return Sentences.AsEnumerable().GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Sentences.GetEnumerator();
        }
    }
}