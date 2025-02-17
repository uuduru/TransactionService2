using System.Transactions;
using ExerciceTransaction._1._Domain;
using ExerciceTransaction._3._Infrastructure;
using ExerciceTransaction._2._Application;

var Transac_repo = new Transactions_Repository();
var Transaction_service = new TransactionServices(Transac_repo);

while(true)
{
    Console.WriteLine("debit, credit ,view_id, view");
    var action = Console.ReadLine();
    try
    {

        if(action == "debit")
        {
            Console.WriteLine("Amount of debit:\n");
            var amount_debit = Console.ReadLine();
            var amount_debit_int = Int32.Parse(amount_debit);
            Console.WriteLine("Description:\n");
            var description = Console.ReadLine();
            Transaction_service.Transaction(DateTime.Now, amount_debit_int, "debit", description);

        }
        else if (action == "credit")
        {
            Console.WriteLine("Amount of credit:\n");
            var amount_credit = Console.ReadLine();
            var amount_credit_int = Int32.Parse(amount_credit);
            Console.WriteLine("Description:\n");
            var description = Console.ReadLine();
            Transaction_service.Transaction(DateTime.Now, amount_credit_int, "credit", description);

        }
        else if (action =="view_id")
        {
            Console.WriteLine("Id of order:\n");
            var Id = Console.ReadLine();
            var Guuid_Id = new Guid(Id);
            Transac_repo.GetTransaction(Guuid_Id);
        }
        else if (action == "view")
        {
            Transac_repo.GetAllTransactions();
        }

    }

    catch (Exception ex) 
    {
        Console.WriteLine("Oops:\n");
    }
}
