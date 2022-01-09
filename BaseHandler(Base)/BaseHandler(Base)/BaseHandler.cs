using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHandler_Base_
{
    public abstract class BaseHandler
    {
        protected BaseHandler Next; // שדה 

        public void SetNext(BaseHandler mynext) // פונקציה שעוברת עלאה אם היא לא מצליחה לטפל
        {
            Next = mynext;
        }

        public abstract void HandleRequest(int amount); // פונקציה שמשתמשים בה כדיי למשמש את ה - Next
      
    }
}
