using System;
using System.Collections.Generic;
using Text_model;

namespace Text_model
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<ISentenceItem> senteceItems = new List<ISentenceItem> {
                new Word("This"),
                new Punctuation(" "),
                new Word("is"),
                new Punctuation(" - "),
                new Word("text"),
                new Punctuation(","),
                new Punctuation(" "),
                new Word("and"),
                new Punctuation(" "),
                new Word("another"),
                new Punctuation(" "),
                new Word("text"),
                new Punctuation(".")
            };
            Sentence sentence = new Sentence(senteceItems);
            Console.WriteLine(sentence.SentenceToString());
        }
    }
}
