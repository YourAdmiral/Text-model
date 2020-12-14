using System;
using System.Collections.Generic;
using Text_model;

namespace Text_model
{
    class Program
    {
        static void Main(string[] args)
        {
            WordFactory wordFactory = new WordFactory();
            PunctuationFactory punctuationFactory = new PunctuationFactory();
            IList<ISentenceItem> sentenceItems1 = new List<ISentenceItem>
            {
                wordFactory.Create("This"),
                punctuationFactory.Create(" "),
                wordFactory.Create("is"),
                punctuationFactory.Create(" - "),
                wordFactory.Create("text"),
                punctuationFactory.Create("."),
            };
            IList<ISentenceItem> sentenceItems2 = new List<ISentenceItem>
            {
                wordFactory.Create("And"),
                punctuationFactory.Create(" "),
                wordFactory.Create("another"),
                punctuationFactory.Create(" "),
                wordFactory.Create("text"),
                punctuationFactory.Create(".")
            };
            ISentence sentence1 = new Sentence(sentenceItems1);
            ISentence sentence2 = new Sentence(sentenceItems2);
            IText text = new Text(new List<ISentence> { sentence1, sentence2 });
            Console.WriteLine(text.TextToString());
        }
    }
}
