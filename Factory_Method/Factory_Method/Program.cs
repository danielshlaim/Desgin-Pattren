using System;

namespace Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDietBase diet1 = DietFactory.IneedDiet(50, 190, 1.72);
            IDietBase diet2 = DietFactory.IneedDiet(50, 69, 1.72);
            IDietBase diet3 = DietFactory.IneedDiet(50, 110, 1.72);
            IDietBase diet4 = DietFactory.IneedDiet(20, 100, 1.72);

            diet1.GetDiet();
            diet2.GetDiet();
            diet3.GetDiet();
            diet4.GetDiet();

        }
    }
}
