using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Text_model
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
        public bool Remove(ISentenceItem item)
        {
            if (item != null && Items.Contains(item))
            {
                Items.Remove(item);
                return true;
            }
            return false;
        }
        public int Count
        {
            get { return Items.Count; }
        }
        public IEnumerator<ISentenceItem> GetEnumerator()
        {
            return Items.AsEnumerable().GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }
        public string SentenceToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].GetType() == typeof(Word))
                {
                    if (i != Items.Count - 1 && Items[i + 1].GetType() == typeof(Word))
                    {
                        sb.Append(Items[i].Chars + " ");
                    }
                    else
                    {
                        sb.Append(Items[i].Chars);
                    }
                }
                if (Items[i].GetType() == typeof(Punctuation))
                {
                    if (i != Items.Count - 1 && Items[i + 1].GetType() == typeof(Word))
                    {
                        if (Separator.QuotesSeparators().Contains(Items[i].Chars))
                        {
                            sb.Append(Items[i].Chars);
                        }
                        else
                        {
                            sb.Append(Items[i].Chars + " ");
                        }
                    }
                    else
                    {
                        sb.Append(Items[i].Chars);
                    }
                }
            }
            return sb.ToString();
        }
    }
}