using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceTransaction._1._Domain
{
    public class Credit : Transaction_Entity
    {
        public Credit(DateTime Date, int Amount, string Type, string Description)
        {
            SetBaseVariables(Date, Amount, Type, Description);
        }

        public bool VerifyCredit()
        {
            if (this._Amount >=10000) 
            {
                Console.WriteLine("There was an error. Amount of Credit is superior to 10000");
                return false;
            }

            return true;
        }
    }
}
