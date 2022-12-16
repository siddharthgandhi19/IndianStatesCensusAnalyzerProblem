using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzerProblem
{
    public class CSVStateCode
    {
        string filePath1 = @"E:\Bridgelabz\IndianStatesCensusAnalyzerProblem\IndianStateCensusAnalyzerProblem\Files\StateCode.csv";
        public int ReadStateCodeData(string filePath1)
        {
            using (var reader = new StreamReader(filePath1))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<StateCodeDAO>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data);
                }
                return records.Count() - 1;
            }
        }
    }
}
