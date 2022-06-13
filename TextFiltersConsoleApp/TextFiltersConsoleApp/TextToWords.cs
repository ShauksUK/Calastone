using System;
using System.Collections.Generic;
using System.Linq;

namespace TextFiltersConsoleApp
{
    public class TextToWords
    {
        public List<string> ConvertToList(string text)
        {
            if (text.Length == 0)
            {
                return new List<string>();
            }

            return PopulateListFromWords(text);
        }

        private List<string> PopulateListFromWords(string text)
        {
            string[] separators = { ",", ".", "!", "\'", " ", "\'s", ";", ":", "`", "(", ")" };
            return text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToList();
        }
    }
}
