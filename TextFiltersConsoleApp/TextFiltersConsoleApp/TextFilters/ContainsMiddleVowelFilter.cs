using System.Collections.Generic;

namespace TextFiltersConsoleApp.TextFilters
{
    public class ContainsMiddleVowelFilter : ITextFilter
    {
        private readonly List<char> _vowels = new List<char>
        {
            'a', 'e', 'i', 'o', 'u'
        };

        public string Apply(string source)
        {
            return ReplaceMiddleVowels(source);
        }

        private string ReplaceMiddleVowels(string source)
        {
            var result = string.Empty;
            var startIndex = (source.Length % 2) == 0 ? (source.Length / 2) - 1 : (source.Length / 2);
            var length = ((source.Length / 2) - 1) == startIndex ? 1 : 0;

            if (source.Length <= 2)
            {
                return source;
            }

            for (var i = 0; i < source.Length; i++)
            {
                var c = source.ToLower()[i];
                if ((i == startIndex || i == (startIndex + length)) && IsAVowel(c))
                {
                    continue;
                }

                result += source[i];
            }

            return result; 
        }

        private bool IsAVowel(char c)
        {
            return _vowels.Contains(c);
        }
    }
}
