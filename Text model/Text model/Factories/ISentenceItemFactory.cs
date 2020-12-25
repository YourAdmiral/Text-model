using System;
using System.Collections.Generic;
using System.Text;
using Text_model.TextItems.SentenceItems;

namespace Text_model.Factories
{
    internal interface ISentenceItemFactory
    {
        ISentenceItem Create(string chars);
    }
}