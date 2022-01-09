using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal static class DietFactory
    {
        public static IDietBase IneedDiet(int age , double weight,double height)
        {
            double BmiCalc = weight / Math.Pow(height, 2);
            if (age >30 && (BmiCalc >= 22 && BmiCalc <= 28.9))
            {
                return new PaleoDiet();
            }
            else if (age > 40 && (BmiCalc >= 34.5 && BmiCalc < 37.4))
            {
                return new EtkinesDiet();
            }
            else if(age > 40 && BmiCalc >= 37.4)
            {
                return new VegetarianDiet();
            }
            return  new NoDiet();
        }
    }
}
