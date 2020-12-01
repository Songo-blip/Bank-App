using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Banking
{
    public class Bank
    {
       [PrimaryKey, AutoIncrement]
        public int BankId { get; set; }
        public string BankName { get; set; }
        public int BranchCode { get; set; }
        public string BranchName { get; set; }

        [OneToMany(CascadeOperation = CascadeOperation.All)]
        public List<Customer> BankingCustomers { get; set; }

        public Bank()
        {
            BankingCustomers = new List<Customer>();
        }

        public Bank(string bankName, int branchCode, string branchName)
        {
            BankName = bankName;
            BranchCode = branchCode;
            BranchName = branchName; 

            BankingCustomers = new List<Customer>();   
        }

        public void AddCustomer(Customer customer)
        {
            BankingCustomers.Add(customer);
        }
    }
}