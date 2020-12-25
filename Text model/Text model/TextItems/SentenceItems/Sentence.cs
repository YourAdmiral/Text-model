using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
using Text_model.TextManager;
using Text_model.TextItems.SentenceItems.Punctuations;
using Text_model.TextItems.SentenceItems.Words;

namespace Text_model.TextItems.SentenceItems
{
    internal class Sentence : ISentence
    {
        public IList<ISentenceItem> Items { get; private set; }
        public Sentence()
        {
            Items = new List<ISentenceItem>();
        }
        public Sentence(IList<ISentenceItem> source)
        {
            Items = source;
        }
        public void Add(ISentenceItem item)
        {
            if (item != null)
                Items.Add(item);
            else
                throw new NullReferenceException("");
        }
        public void Remove(ISentenceItem item)
        {
            if (item != null && Items.Contains(item))
            {
                Items.Remove(item);
            }
        }
        public void ReplaceWords(int length, string word)
        {
            foreach (var item in Items)
            {
                if (item.GetType() == typeof(Word)
                    && item.Value.Length == length)
                {
                    item.Value = word;
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Items.Count; i++)
            {
                sb.Append(Items[i].Value);
            }
            return sb.ToString();
        }
        public IEnumerator<ISentenceItem> GetEnumerator()
        {
            return Items.AsEnumerable().GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}