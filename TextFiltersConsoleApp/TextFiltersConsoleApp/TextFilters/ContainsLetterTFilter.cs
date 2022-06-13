using System.Text.RegularExpressions;

namespace TextFiltersConsoleApp.TextFilters
{
    public class ContainsLetterTFilter : ITextFilter
    {
        public string Apply(string source)
        {
            return Regex.Matches(source, @"\w[t]").Count > 0 ? string.Empty : source;
        }
    }
}
