using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Text_model;

namespace Text_model
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var parser = new Parser();
                var streamReader = new StreamReader(@"E:\GitHub\Text-model\Text model\Text model\Text.txt", Encoding.Default);
                var text = parser.ParseText(streamReader);
                Console.WriteLine(text.TextToString());
                Console.WriteLine("First sentence: ");
                foreach (var sentence in text.Sentences[1])
                {
                    Console.WriteLine(sentence.Chars + " " + sentence.GetType());
                }
                Console.WriteLine("----------");
                Console.WriteLine("Ordered sentences: ");
                foreach (var sentence in text.GetOrderSentences())
                {
                    Console.WriteLine(sentence.SentenceToString());
                }
                Console.WriteLine("----------");
                Console.WriteLine("Words of a certain length in interrogative sentences: ");
                foreach (var word in text.GetWordsFromQuestions(3))
                {
                    Console.WriteLine(word.Chars);
                }
                Console.WriteLine("----------");
                Console.WriteLine("Delete words of a certain length beginning with a consonant: ");
                text.DeleteWords(3);
                Console.WriteLine(text.TextToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
