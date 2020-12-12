using System;
using System.Collections.Generic;
using Text_model;

namespace Text_model
{
    class Program
    {
        static void Main(string[] args)
        {
            Symbol symbol = new Symbol("D");
            Console.WriteLine(symbol.Chars);
            IPunctuation punctuation = new Punctuation(".");
            Console.WriteLine(punctuation.Chars);
            Word word = new Word("Привет");
            Console.WriteLine(word.Chars);
            ISentence mySentence = new Sentence(new List<ISentenceItem>()
            {
                new Word("Hello"),
                new Punctuation(","),
                new Punctuation(" "),
                new Word("this"),
                new Punctuation(" "),
                new Punctuation("is"),
                new Punctuation(" "),
                new Word("my"),
                new Punctuation(" "),
                new Word("Sentence"),
                new Punctuation(".")
            });
            IText text = new Text();
            text.AddSentence(mySentence);
            foreach (var sentence in text)
            {
                foreach (var item in sentence)
                {
                    Console.Write(item.Chars);
                }
            }
        }
    }
}
