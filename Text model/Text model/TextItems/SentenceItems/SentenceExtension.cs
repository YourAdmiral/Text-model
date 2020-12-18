using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model.TextItems.SentenceItems
{
    public static class SentenceExtension
    {
        public static void AddSentence<T>(this ICollection<T> collection, IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                collection.Add(item);
            }
        }
    }
}
