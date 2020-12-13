using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Text_model
{
    internal class Parser
    {
        private Separator _separator = new Separator();
        private ISentenceItemFactory _wordFactory;
        private ISentenceItemFactory _punctuationFactory;
        public IText ParseText(StreamReader fileReader)
        {
            return null;
        }
        public ISentence ParseSentence(string sentence)
        {
            return null;
        }
    }
}