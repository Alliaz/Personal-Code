using System;
using System.Collections.Generic;
using System.Text;
using FileProcessing.Business;
using System.IO;

namespace FileProcessing.View
{
    public class Program {
        public static void Main()
        {
            BusinessLogic businessLogic = new BusinessLogic();
            ExceptionHandler exceptionHandler = new ExceptionHandler();
            try
            {
                var splitLine = businessLogic.createSplitString(Console.ReadLine());
                businessLogic.readFiles(splitLine);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                int exceptionCode = exceptionHandler.NegativeExceptionCodeHandler(e);
                Console.WriteLine("Error Code: " + "-" + exceptionCode);
                Console.ReadKey();
            }

        }
    }
}
