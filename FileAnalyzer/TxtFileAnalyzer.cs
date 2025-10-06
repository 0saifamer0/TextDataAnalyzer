using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzerProject
{
    public class TxtFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            // Add Logic
            string fileString = File.ReadAllText(fileInfo.FullName);

            AnalysisResults results = new AnalysisResults();
            
            results.CharacterCount = fileString.Length;

            var words = fileString.Split(new char[] { ' ', '\n', '\r' });

            results.WordCount = words.Length;

            var lines = fileString.Split(new char[] { '\n' });

            results.LineCount = lines.Length;

            SetAnalysisResults(results);
        }
    }
}
