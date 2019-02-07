using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitMiniResults.Helpers
{
    public static class ReadResults
    {
        public static List<Result> ReadFile(string filePath)
        {
            filePath = @"C:\Temp\results.txt";
            string[] resultLines = File.ReadAllLines(filePath);
            List<Result> previousResults = new List<Result>();

            foreach(var line in resultLines)
            {
                var result = line.Split(";");
                Result previousResultFromFile = new Result();
                try
                {
                    previousResultFromFile.EmitCardNumber = int.Parse(result[0]);
                    previousResultFromFile.EndResultTime = int.Parse(result[1]);
                    previousResultFromFile.CompetitorName = result[2];
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                previousResults.Add(previousResultFromFile);
            }

            return previousResults;
        }
    }
}
