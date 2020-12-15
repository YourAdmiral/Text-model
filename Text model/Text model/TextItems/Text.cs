using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_model
{
    internal class Text : IText
    {
        public IList<ISentence> Sentences { get; private set; }
        public Text()
        {
            Sentences = new List<ISentence>();
        }
        public Text(IList<ISentence> sentences)
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
        public ISentence this[int index] => Sentences[index];
        public string TextToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (ISentence sentence in Sentences)
            {
                sb.Append(sentence.SentenceToString() + "\n");
            }
            return sb.ToString();
        }
    }
}