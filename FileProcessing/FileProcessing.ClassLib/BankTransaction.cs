using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessing.Entities
{
    public class BankTransaction
    {
        public string AccountNr { get; set; }
        public double Amount { get; set; }
        public string Date { get; set; }
        public string BankName { get; set; }

        public BankTransaction(string accountNr, double amount, string date, string bankName)
        {
            AccountNr = accountNr;
            Amount = amount;
            Date = date;
            BankName = bankName;
        }

        public BankTransaction()
        {
        }
    }
}
