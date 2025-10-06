using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzerProject
{
    public class CsvFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            // Add Logic
            string[] stringFile = File.ReadAllLines(fileInfo.FullName);

            var fields = stringFile[0].Split(',');

            AnalysisResults results = new AnalysisResults();

            results.FieldCount = fields.Length;

            SetAnalysisResults(results);
        }
    }
}
