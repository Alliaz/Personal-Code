using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class ShortAndLongMeasurements
    {
        public string sMeasurement { get; set; }
        public string lMeasurement { get; set; }

        public ShortAndLongMeasurements(string s, string l)
        {
            sMeasurement = s;
            lMeasurement = l;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 42 ft in inch

            int index = 0;
            int firstCalculationNumber = 0;
            int secondCalculationNumber = 0;

            List<int> conversionNumbers = new List<int> { 1, 1000, 12, 3, 22, 10, 8, 3 };
            string input = Console.ReadLine();
            string[] splitString = input.Split(new char[] { ' ' }, StringSplitOptions.None);
            var givenMeasurements = (splitString[1], splitString[3]);
            List<ShortAndLongMeasurements> measurementTypes = new List<ShortAndLongMeasurements>();
            measurementTypes.Add(new ShortAndLongMeasurements("th", "thou"));
            measurementTypes.Add(new ShortAndLongMeasurements("in", "inch"));
            measurementTypes.Add(new ShortAndLongMeasurements("ft", "foot"));
            measurementTypes.Add(new ShortAndLongMeasurements("yd", "yard"));
            measurementTypes.Add(new ShortAndLongMeasurements("ch", "chain"));
            measurementTypes.Add(new ShortAndLongMeasurements("fur", "furlong"));
            measurementTypes.Add(new ShortAndLongMeasurements("mi", "mile"));
            measurementTypes.Add(new ShortAndLongMeasurements("lea", "league"));

            foreach (var s in measurementTypes)
            {
                if (givenMeasurements.Item1 == measurementTypes[index].sMeasurement || givenMeasurements.Item1 == measurementTypes[index].lMeasurement)
                {
                    firstCalculationNumber = index;
                    break;
                }
                index++;

            }
            index = 0;
            foreach (var s in measurementTypes)
            {
                if (givenMeasurements.Item2 == measurementTypes[index].sMeasurement || givenMeasurements.Item2 == measurementTypes[index].lMeasurement)
                {
                    secondCalculationNumber = index;
                    break;
                }
                index++;
            }

            double tempNumber = Convert.ToDouble(splitString[0]);

            if (firstCalculationNumber < secondCalculationNumber)
            {
                while (firstCalculationNumber < secondCalculationNumber)
                {
                    tempNumber = tempNumber / conversionNumbers[firstCalculationNumber+1];
                    firstCalculationNumber++;
                }
            }
            if(firstCalculationNumber > secondCalculationNumber)
            {
                while (firstCalculationNumber > secondCalculationNumber)
                {
                    tempNumber = tempNumber * conversionNumbers[firstCalculationNumber];
                    firstCalculationNumber--;
                }
            }
            Console.WriteLine(tempNumber);
            Console.ReadLine();
        }
    }
}
