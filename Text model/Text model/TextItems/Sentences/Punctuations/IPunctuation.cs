using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model
{
    internal interface IPunctuation : ISentenceItem
    {
        public Symbol Value { get; set; }
    }
}