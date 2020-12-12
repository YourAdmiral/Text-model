using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Text_model
{
    internal class Sentence : ISentence
    {
        private ICollection<ISentenceItem> _items;
        public Sentence()
        {
            _items = new List<ISentenceItem>();
        }
        public Sentence(ICollection<ISentenceItem> source)
        {
            _items = source;
        }
        public void Add(ISentenceItem item)
        {
            if (item != null)
                _items.Add(item);
            else
                throw new NullReferenceException("");
        }
        public bool Remove(ISentenceItem item)
        {
            if (item != null && _items.Contains(item))
            {
                _items.Remove(item);
                return true;
            }
            return false;
        }
        public int Count
        {
            get { return _items.Count; }
        }
        public IEnumerator<ISentenceItem> GetEnumerator()
        {
            return _items.AsEnumerable().GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}