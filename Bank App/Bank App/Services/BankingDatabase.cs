using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_App.Services
{
    public class BankingDataBase

    {
        private SQLiteConnection
         public BankingDataBase()

        {
            var path = GetDbPath()



            _database = new SQLiteconnection(path);
            _database.CreateTable<Banking>
                 _database.CreateTable<Customer>
                 _database.CreateTable<Transaction>
                 _database.CreateTable<BankAccount>

         }





        public seedDataBase
        {
          if  (_database.Table<Banking>() Count() == 0)
            {

        Bank fnb = new Bank("First National Bank", 4324, "Kenilworth");
        Customer myNewCustomer = new Customer("7766445424", "10 me at home", "Bob", "The Builder");
        fnb.AddCustomer(myNewCustomer);

        _database.Insert(myNewCustomer);
        _database.Insert(fnb);
       
         _database.UpdateWithChildren(fnb);

        var account = myNewCustomer.ApplyForBankAccount();
        _database.Insert(account);
        _database.Insert(myNewCustomer);
            }

        }

        public Customer GetCustomerByIdNumber(string saIdNumber)
        {
        return _database.Table<Customer>().Where(X => IdNumber == saIdNumber).FirstorDefault();
         }

    public List<Transation> GetTransactions(BankAccount account)
    { 

    return _database.Table<Transation> ().Where (X=> X.BankAccountId== account.BankAccountId).ToList();
    }

    public List<Transation> GetCurrentAccount(BankAccount account)
    {

    return _database.Table<Transation>().Where(X => X.BankAccountId == account.BankAccountId).ToList();
    }
public void saveTransaction (bankAccount account, Transaction trans)
{
    _database.Insert(Trans);
    _database.updateWithChildren
}
    }
}
