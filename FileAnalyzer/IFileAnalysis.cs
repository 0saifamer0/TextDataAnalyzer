using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzerProject
{
    public interface IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo);
    }
}
