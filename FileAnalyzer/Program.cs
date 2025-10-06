namespace FileAnalyzerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File Analyzer");
            Console.WriteLine("Please enter the folder path to analyze");
            Console.WriteLine("========================================");

            string folderPath = Console.ReadLine();

            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);

            if (directoryInfo.Exists == false) 
            {
                Console.WriteLine("Folder doesn't exist");
                return;
            }

            FileInfo[] files = directoryInfo.GetFiles();

            IFileAnalysis fileAnalysis;

            foreach (var file in files)
            {
                if (file.IsTxtFile())
                {
                    fileAnalysis = new TxtFileAnalyzer();

                    fileAnalysis.AnalyzeFile(file);

                    var results = ((FileAnalyzer)fileAnalysis).GetAnalysisResults();

                    Console.WriteLine($"File Name: {file.Name}");
                    Console.WriteLine($"Character Count: {results.CharacterCount}");
                    Console.WriteLine($"Word Count: {results.WordCount}");
                    Console.WriteLine($"Line Count: {results.LineCount}");
                    Console.WriteLine("----------------------");
                }
                else if (file.IsCsvFile())
                {
                    fileAnalysis = new CsvFileAnalyzer();

                    fileAnalysis.AnalyzeFile(file);

                    var results = ((FileAnalyzer)fileAnalysis).GetAnalysisResults();

                    Console.WriteLine($"File Name: {file.Name}");
                    Console.WriteLine($"Field Count: {results.FieldCount}");
                    Console.WriteLine("----------------------");
                }
            }
        }
    }
}
