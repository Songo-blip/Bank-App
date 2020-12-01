using SQLite;
using SQLiteNetExtensions.Attributes;
using System;

namespace Banking
{
    public class Transaction
    {
        [PrimaryKey,AutoIncrement]
        public int TransationId { get; set; }
        public decimal Amount {get;set;}
        public string Description {get;set;}
        public DateTime TransactionDate {get;set;}
    
        [ForeignKey(typeof(BankAccount))] public int TransactionId { get; set; }
        public Transaction(decimal amount, DateTime date, string description)
        {
         Amount = amount;
         TransactionDate = date;
         Description = description;
        }
    }
}