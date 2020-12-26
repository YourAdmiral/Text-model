using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Text_model.TextItems.SentenceItems;
using Text_model.TextItems.SentenceItems.Words;

namespace Text_model.TextItems
{
    internal class Text : IText
    {
        public IList<ISentence> Sentences { get; private set; }
        public ISentence this[int index] => Sentences[index];
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
        public void DeleteWords(int length)
        {
            int previous;
            string pattern = @"^[qwrtypsdfghjklzxcvbnm](w*)";
            foreach (var sentence in Sentences)
            {
                previous = 0;
                for (int i = 0; i < sentence.Items.Count; i++)
                {
                    if (sentence.Items[i].GetType() == typeof(Word)
                    && sentence.Items[i].Value.Length == length
                    && Regex.IsMatch(sentence.Items[i].Value, pattern, RegexOptions.IgnoreCase))
                    {
                        sentence.Items[i].Value = "";
                        if (sentence.Items[previous].Value == " ")
                        {
                            sentence.Items[previous].Value = "";
                        }
                    }
                    previous = i;
                }
            }
        }
        public IEnumerable<ISentence> GetOrderSentences()
        {
            return Sentences.OrderBy(sentence => sentence.Items.Where(item => item.GetType() == typeof(Word)).Count());
        }
        public IEnumerable<ISentenceItem> GetWordsFromQuestions(int length)
        {
            var words = new List<ISentenceItem>();
            foreach (var sentence in Sentences
                .Where(sentence => sentence.Items.Last().Value == "?"
            || sentence.Items.Last().Value == "!?"
            || sentence.Items.Last().Value == "?!"))
            {
                words.AddRange(sentence.Items.Where(item => item.GetType() == typeof(Word) && item.Value.Length == length));
            }
            return words.Distinct();
        }
        public IEnumerator<ISentence> GetEnumerator()
        {
            return Sentences.AsEnumerable().GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Sentences.GetEnumerator();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Sentences.Count; i++)
            {
                sb.Append(Sentences[i].ToString() + "\n");
            }
            return sb.ToString();
        }
    }
}