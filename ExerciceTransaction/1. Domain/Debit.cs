using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciceTransaction._2._Application;

namespace ExerciceTransaction._1._Domain
{
    public class Debit : Transaction_Entity
    {
        
        public Debit( DateTime Date, int Amount, string Type, string Description)
        {
            SetBaseVariables(Date, Amount, Type, Description);
        }

        public bool VerifyDebit(int account_amount)
        {
            if (account_amount - this._Amount < -5000)
            {
                Console.WriteLine("There was an error. Amount of Debit is inferior to -5000");
                return false;
            }

            return true;
        }
    }
}
