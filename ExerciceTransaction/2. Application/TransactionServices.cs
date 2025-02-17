using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciceTransaction._1._Domain;

namespace ExerciceTransaction._2._Application
{
    public class TransactionServices
    {
        private readonly ITransactionRepo _transactionRepo;

        public TransactionServices(ITransactionRepo transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }


        public bool Transaction(DateTime Date, int Amount, string Type, string Description)
        {

            if (Type.Equals("credit"))
            {
                var credit = new Credit(Date, Amount, Type, Description);
                if (credit.VerifyCredit()) 
                {      
                    _transactionRepo.AddTransaction(credit);
     
                }
            }

            else if (Type.Equals("debit"))
            {
                var debit = new Debit(Date, Amount, Type, Description);
                if (debit.VerifyDebit(_transactionRepo.CurrentAccountAmount()))
                {
                    _transactionRepo.AddTransaction(debit);
                    _transactionRepo.ChangeAccountAmount(Amount);
                    Console.WriteLine("Your acccount amount is {0}", _transactionRepo.CurrentAccountAmount());
                    return true;
                }
                else
                {
                    Console.WriteLine("Your current amount will be below -5000");
                    return false;
                }
            }

            else 
            {
                Console.WriteLine("I didn't understand the type");
                return false;
            }
            return false;
        }
    }
}
