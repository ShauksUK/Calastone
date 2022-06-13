namespace TextFiltersConsoleApp.Logging
{
    public interface ILog
    {
        void Info(string message);

        void Warn(string message);

        void Error(string message);

        void Header(string message);
    }
}
