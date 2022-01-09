using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class NoDiet : IDietBase
    {
        public string Menu { get; set; } = "Im Thin I dont need Diet";

        public void GetDiet()
        {
            Console.WriteLine(Menu);
        }
    }
}
