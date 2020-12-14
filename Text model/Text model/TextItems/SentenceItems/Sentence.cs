using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Text_model
{
    internal class Sentence : ISentence
    {
        private Separator _separator = new Separator();
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
            foreach (var item in Items)
            {
                sb.Append(item.Chars);
            }
            return sb.ToString();
        }
    }
}