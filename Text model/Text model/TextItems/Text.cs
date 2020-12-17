using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
        public IEnumerable<ISentence> GetOrderSentences()
        {
            return Sentences.OrderBy(sentence => sentence.Items.Where(item => item.GetType() == typeof(Word)).Count());
        }
        public IEnumerable<ISentenceItem> GetWordsFromQuestions(int length)
        {
            var words = new List<ISentenceItem>();
            foreach (var sentence in Sentences
                .Where(sentence => sentence.Items.Last().Chars == "?"
            || sentence.Items.Last().Chars == "!?"
            || sentence.Items.Last().Chars == "?!"))
            {
                words.AddRange(sentence.Items.Where(item => item.GetType() == typeof(Word) && item.Chars.Length == length));
            }
            return words.Distinct();
        }
        public void DeleteWords(int length)
        {
            string pattern = @"^[qwrtypsdfghjklzxcvbnm](w*)";
            foreach (var sentence in Sentences)
            {
                foreach (var item in sentence.Items.ToList())
                {
                    if (item.GetType()==typeof(Word)
                        && item.Chars.Length==length
                        && Regex.IsMatch(item.Chars, pattern, RegexOptions.IgnoreCase))
                    {
                        sentence.Remove(item);
                    }
                }
            }
        }
    }
}