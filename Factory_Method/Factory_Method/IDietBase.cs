﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal interface IDietBase
    {
        public string Menu { get; set; }
        public void GetDiet();

    }
}
