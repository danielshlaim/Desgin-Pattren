﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class PaleoDiet : IDietBase
    {
        public string Menu { get; set; } = "Meat Diet";
        public void GetDiet()
        {
            Console.WriteLine(Menu);
        }
    }
}
