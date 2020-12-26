using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Text_model;
using Text_model.TextItems;
using Text_model.TextItems.SentenceItems;
using Text_model.TextItems.SentenceItems.Words;

namespace Text_model.TextManager
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
                Console.WriteLine(text.ToString());
                Console.WriteLine("----------");

                Console.WriteLine("Ordered sentences: ");
                foreach (var sentence in (text as Text).GetOrderSentences())
                {
                    Console.WriteLine(sentence.ToString());
                }
                Console.WriteLine("----------");

                Console.WriteLine("Words of a certain length in interrogative sentences: ");
                int num1 = GetNumber();
                foreach (var word in (text as Text).GetWordsFromQuestions(num1))
                {
                    Console.WriteLine(word.Value);
                }
                Console.WriteLine("----------");

                Console.WriteLine("Delete words of a certain length beginning with a consonant: ");
                int num2 = GetNumber();
                text.DeleteWords(num2);
                Console.WriteLine(text.ToString());
                Console.WriteLine("----------");

                Console.WriteLine("Replace words of specified length with a specific substring: ");
                int num3 = GetNumber();
                string substring = GetWord();
                ISentence newSentence = text.Sentences[0];
                (newSentence as Sentence).ReplaceWords(num3, substring);
                text.Sentences[0] = newSentence;
                Console.WriteLine(text.ToString());

                Console.WriteLine("1 - Сохранить файл, 2 - Выйти");
                ConsoleKey choose = default;
                while (choose != ConsoleKey.D2)
                {
                    choose = Console.ReadKey(true).Key;
                    switch (choose)
                    {
                        case ConsoleKey.D1:
                            using (StreamWriter sw = new StreamWriter(@"E:\GitHub\Text-model\Text model\Text model\Text.txt", false, Encoding.Default))
                            {
                                foreach (var sentence in text.Sentences)
                                {
                                    sw.WriteLine(sentence.ToString());
                                }
                            }
                            Console.WriteLine("Файл сохранен!");
                            break;
                        case ConsoleKey.D2:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Вы выбрали неподходящее значение!");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static int GetNumber()
        {
            Console.WriteLine("Enter number: ");
            int num = 0;
            while (num == 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                    throw new Exception();
            }
            return num;
        }
        private static string GetWord()
        {
            Console.WriteLine("Enter substring: ");
            return Console.ReadLine();
        }
    }
}
