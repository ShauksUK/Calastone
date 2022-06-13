using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using StructureMap;
using TextFiltersConsoleApp.Logging;

namespace TextFiltersConsoleApp
{
    public class Application
    {
        private static string _directoryName = AppDomain.CurrentDomain.BaseDirectory;
        private static string _fileName = "Source-Text.txt";
        private readonly ILog _logger;

        public Application(ILog logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            var strFullPath = Path.Combine(_directoryName, _fileName);
            if (File.Exists(strFullPath))
            {
                var originalContent = ReadFile(strFullPath);
                
                WriteStateToConsole("Before Applying Filters...", originalContent);

                var textToWords = new TextToWords();
                var words = textToWords.ConvertToList(originalContent);

                var container = Container.For<ConsoleRegistry>();
                var filterProcessor = container.GetInstance<TextFilterProcessor>();
                var dictionary = filterProcessor.ProcessWords(words);

                var updatedContent = ReplaceTextUsingDictionary(dictionary, originalContent);

                WriteStateToConsole("After Applying Filters...", updatedContent);
            }
        }

        private string ReadFile(string fileName)
        {
            try
            {
                return File.ReadAllText(fileName);
            }
            catch (Exception e)
            {
                _logger.Error(e.Message);
                throw;
            }
        }

        private string ReplaceTextUsingDictionary(IDictionary<string, string> dictionary, string sourceText)
        {
            if (dictionary.Count == 0)
            {
                return sourceText;
            }

            foreach (var entry in dictionary)
            {
                var pattern = @"\b" + entry.Key + @"\b";
                sourceText = Regex.Replace(sourceText, pattern, entry.Value);
            }

            return sourceText;
        }

        private void WriteStateToConsole(string title, string message)
        {
            _logger.Header($" * ** {title} ***");
            _logger.Info(message);
        }
    }
}
