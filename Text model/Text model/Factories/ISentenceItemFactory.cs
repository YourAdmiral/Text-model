﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Text_model
{
    internal interface ISentenceItemFactory
    {
        ISentenceItem Create(string chars);
    }
}