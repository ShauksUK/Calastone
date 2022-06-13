namespace TextFiltersConsoleApp.TextFilters
{
    public class LengthLessThan3Filter : ITextFilter
    {
        public string Apply(string source)
        {
            return source.Length < 3 ? string.Empty : source;
        }
    }
}
