using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FileProcessing.Entities;
using System.Threading.Tasks;

namespace FileProcessing.Business
{
    public class BusinessLogic
    {
        public List<BankTransaction> bankTransactions = new List<BankTransaction>();
        string _outputLocation;
        string type;
        DateTime _referenceDate;

        public string[] createSplitString(string currentLine) //Gets initial string from user and splits it into usable parts
        {
            var splitLine = currentLine.Split(' ');
            return splitLine;
        }
        public void readFiles(string[] splitLine) //gets the splitline which is an array and uses that to read the file
        {
            string currentLine;
            string txtFileName = splitLine[0];
            string outputLocation = splitLine[1];
            string referenceDate = splitLine[2];

            StreamReader inputFile = new StreamReader(@"c:\temporary\" + txtFileName);  //ADD LOCAL LOCATION FOR FILE
            inputFile.ReadLine(); //Skips First line as it's not important to the program itself
            while ((currentLine = inputFile.ReadLine()) != null) 
            {
                createBankTransaction(currentLine);
            }
            inputFile.Close();
            printOutTransactions(outputLocation, referenceDate); //Calls for the program to print out the bank transactions
        }
        public void createBankTransaction(string currentLine){ //Creates the object bankTransactions
            var splitLine = currentLine.Split(';') ;

            BankTransaction bankTransactionTemp = new BankTransaction(); 

            bankTransactionTemp.AccountNr = splitLine[0];
            bankTransactionTemp.Amount = Convert.ToDouble(splitLine[1]);
            bankTransactionTemp.Date = splitLine[2];
            bankTransactionTemp.BankName = splitLine[3];

            bankTransactions.Add(bankTransactionTemp);
        }
        public void printOutTransactions(string outputLocation, string referenceDate){ //Prints the transactions into it's respective .txt file
            int i = 0;
            _outputLocation = outputLocation;
            _referenceDate = Convert.ToDateTime(referenceDate);

            while (i < bankTransactions.Count){ //Loops through the banktransactions
                int CompareDateTime = DateTime.Compare(Convert.ToDateTime(bankTransactions[i].Date), _referenceDate); //checks the reference date and compares it with the date in the transaction (the int becomes 0, -1 or 1)

                if (CompareDateTime == -1) type = "OLD"; // -1 = Older than the reference date
                if (CompareDateTime == 0) type = "ACTIVE"; // 0 is the same date
                if (CompareDateTime == 1) type = "FUTURE"; // 1 is in the future

                string objectBank = bankTransactions[i].BankName;
                if (File.Exists(_outputLocation + objectBank + ".txt")) //this checks if an file already exists with the given bankname.txt
                {
                    using (StreamWriter sw = File.AppendText(_outputLocation + objectBank + ".txt"))
                    {
                        sw.WriteLine(bankTransactions[i].AccountNr + ";" + bankTransactions[i].Amount + ";" + bankTransactions[i].Date + ";" + type); //writes to the current existing file
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(_outputLocation + objectBank + ".txt")) //if no text file exists, creates a new one with the bankname as the .txt filename
                    {
                        sw.WriteLine("Konto;Belopp;Datum;Typ"); //Adds this first in the file
                        sw.WriteLine(bankTransactions[i].AccountNr + ";" + bankTransactions[i].Amount + ";" + bankTransactions[i].Date + ";" + type); //writes to the new file
                        sw.Close();
                    }
                }
                i++;
            }
        }
    }
}
