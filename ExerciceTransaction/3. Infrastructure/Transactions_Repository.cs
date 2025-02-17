using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciceTransaction._1._Domain;
using ExerciceTransaction._2._Application;

namespace ExerciceTransaction._3._Infrastructure
{
    public class Transactions_Repository : ITransactionRepo
    {
        private List<Transaction_Entity> _transactions = [];
        private int  _Curent_account_value = 20000;

        public void AddTransaction(Transaction_Entity transaction) 
        { 
            _transactions.Add(transaction);
        }

        public void GetTransaction(Guid Id) 
        {
            foreach (var transaction_entity in _transactions) 
            { 
                if(transaction_entity._Id == Id)
                {
                    Console.WriteLine("The transaction details:\n Date: {0}\n Montant: {1}\n Type: {2}\n Description: {3}\n",
                    transaction_entity._Date, transaction_entity._Amount, transaction_entity._Type, transaction_entity._Description);
                }
            }
        
        }

        public void GetAllTransactions()
        {
            foreach (var transaction_entity in _transactions)
            {
               
                Console.WriteLine("The transaction details:\n Date: {0}\n Montant: {1}\n Type: {2}\n Description: {3}\n",
                transaction_entity._Date, transaction_entity._Amount, transaction_entity._Type, transaction_entity._Description);
          
            }
        }

        public int CurrentAccountAmount()
        {
          return _Curent_account_value;
        }

        public void ChangeAccountAmount(int amount)
        {
             this._Curent_account_value = this._Curent_account_value - amount;
        }

    }
}
