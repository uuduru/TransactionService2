using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceTransaction._1._Domain
{
    public class Transaction_Entity
    {
        public Guid _Id { get; private set; }
        public DateTime _Date { get; private set; }
        public int _Amount { get; private set; }

        public string _Type { get; private set; }

        public string _Description { get; private set; }

        public Transaction_Entity()
        {
            
        }
        public Transaction_Entity(DateTime Date, int Amount, string Type, string Description) 
        { 
            this._Date = Date;
            this._Amount = Amount;
            this._Type = Type;
            this._Description = Description;
            this._Id = Guid.NewGuid();
            Console.WriteLine("Your Id number is {0}", _Id);
        }

        public void SetBaseVariables(DateTime Date, int Amount, string Type, string Description)
        {
            this._Date = Date;
            this._Amount = Amount;
            this._Type = Type;
            this._Description = Description;
            this._Id = Guid.NewGuid();
            Console.WriteLine("Your Id number is {0}", _Id);
        }
    }
}
