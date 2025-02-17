using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciceTransaction._1._Domain;

namespace ExerciceTransaction._2._Application
{
    public interface ITransactionRepo
    {
        void AddTransaction(Transaction_Entity transaction);
        void GetTransaction(Guid Id);
        void GetAllTransactions();
        int CurrentAccountAmount();
        void ChangeAccountAmount(int amount);
    }
}
