using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Text_model.TextItems.SentenceItems;

namespace Text_model
{
    internal class Parser
    {
        private ISentenceItemFactory _wordFactory;
        private ISentenceItemFactory _punctuationFactory;
        private Regex _sentenceItems = new Regex(
        @"(\W*)(\w+[\-|`]\w+)(\!\=|\>\=|\=\<|\/|\=\=|\?\!|\!\?|\.{3}|\W)|(\W*)(\w+|\d+)(\!\=|\>\=|\=\<|\/|\=\=|\?\!|\!\?|\.{3}|\W)|(.*)",
        RegexOptions.Compiled);
        private Regex _sentences = new Regex(
        @"(?<=[\.*!\?])\s+(?=[А-Я]|[A-Z])|(?=\W&([А-Я]|[A-Z]))",
        RegexOptions.Compiled);
        public IText ParseText(StreamReader reader)
        {
            IText textResult = new Text();
            string readLine = null;
            string buffer = null;
            try
            {
                while ((readLine = reader.ReadLine()) != null)
                {
                    if (Regex.Replace(readLine.Trim(), @"\s+", @" ") != "")
                    {
                        readLine = buffer + readLine;
                        var sentences =
                            _sentences.Split(readLine)
                            .Select(x => Regex.Replace(x.Trim(), @"\s+", @" "))
                            .ToArray();
                        if (!Separator.SentenceSeparators().Contains(sentences.Last().Last().ToString()))
                        {
                            buffer = sentences.Last();
                            textResult.Sentences.AddSentence(sentences.Select(x => x)
                                .Where(x => x != sentences.Last()).Select(ParseSentence));
                        }
                        else
                        {
                            textResult.Sentences.AddSentence(sentences.Select(ParseSentence));
                            buffer = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                reader.Close();
            }
            finally
            {
                reader.Close();
                reader.Dispose();
            }
            return textResult;
        }
        private ISentence ParseSentence(string source)
        {
            ISentence result = new Sentence();
            Func<string, ISentenceItem> sentenceItems =
                sentenceItem => (!Separator.AllSeparators().Contains(sentenceItem))
                ?_wordFactory.Create(sentenceItem)
                : _punctuationFactory.Create(sentenceItem);
            foreach (Match match in _sentenceItems.Matches(source))
            {
                for (int i = 1; i < match.Groups.Count; i++)
                {
                    if (match.Groups[i].Value.Trim() != "")
                    {
                        result.Items.Add(sentenceItems(match.Groups[i].Value.Trim()));
                    }
                }
            }
            return result;
        }
        public Parser()
        {
            _wordFactory = new WordFactory();
            _punctuationFactory = new PunctuationFactory();
        }
    }
}