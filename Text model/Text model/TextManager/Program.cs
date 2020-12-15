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
            var parser = new Parser();
            var streamReader = new StreamReader(@"E:\GitHub\Text-model\Text model\Text model\Text.txt", Encoding.Default);
            var text = parser.ParseText(streamReader);
            Console.WriteLine(text.TextToString());
            Console.WriteLine("First sentence: ");
            foreach (var item in text.Sentences[1])
            {
                Console.WriteLine(item.Chars + " " + item.GetType());
            }
        }
    }
}
