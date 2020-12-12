using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model
{
    internal interface IWord : ISentenceItem
    {
        public int Length { get; set; }
        public Symbol this[int index] { get; set; }
    }
}