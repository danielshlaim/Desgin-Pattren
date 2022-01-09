using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class EtkinesDiet : IDietBase
    {
        public string Menu { get; set; } = "Hard Diet";
        public void GetDiet()
        {
            Console.WriteLine(Menu);
        }
    }
}
