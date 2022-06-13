using System;
using System.Collections.Generic;
using TextFiltersConsoleApp.TextFilters;

namespace TextFiltersConsoleApp
{
    public class TextFilterProcessor
    {
        private readonly IEnumerable<ITextFilter> _textFilters;

        public TextFilterProcessor(IEnumerable<ITextFilter> textFilters)
        {
            _textFilters = textFilters;
        }

        public IDictionary<string, string> ProcessWords(IEnumerable<string> words)
        {
            IDictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
            foreach (var word in words)
            {
                var filteredWord = ApplyFilters(word);

                if (filteredWord == word)
                {
                    continue;
                }

                dictionary.Add(word, filteredWord);
            }

            return dictionary;
        }

        private string ApplyFilters(string word)
        {
            foreach (var textFilter in _textFilters)
            {
                word = textFilter.Apply(word);
            }

            return word;
        }
    }
}
