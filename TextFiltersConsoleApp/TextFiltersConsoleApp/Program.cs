using System;
using StructureMap;
using TextFiltersConsoleApp.Logging;
using TextFiltersConsoleApp.TextFilters;

namespace TextFiltersConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var container = Container.For<ConsoleRegistry>();
            var app = container.GetInstance<Application>();
            app.Run();
            Console.ReadLine();
        }
    }

    public class ConsoleRegistry : Registry
    {
        public ConsoleRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });

            For<ITextFilter>().Use<ContainsMiddleVowelFilter>();
            For<ITextFilter>().Use<LengthLessThan3Filter>();
            For<ITextFilter>().Use<ContainsLetterTFilter>();

            For<ILog>().Use<ConsoleLogger>();
        }
    }
}